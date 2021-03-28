using System;
using System.Collections.Generic;
using System.Data;
using GroupProject.Classes.Car;
using GroupProject.Classes.Salesman;
using GroupProject.Classes.User;
using MySql.Data.MySqlClient;

namespace GroupProject.Classes
{
	class ClsDatabase
	{
		private const string ConnString =
			"Server=plesk.remote.ac;database=ws330584_dealership;user=ws330584_dealership;password=Password123;CharSet=utf8;";

		public MySqlConnection GetConnection()
		{
			MySqlConnection cnn = new MySqlConnection(ConnString);

			return cnn;
		}

		// Temporary hard coded value. We will get the actual ad when user selects a car
		public Tuple<List<ClsUserConfiguration>, List<ClsUserCarConfiguration>> GetUserCarConfigurations(int id = 1)
		{
			var conn = this.GetConnection();
			// Get all configurations for that user
			// Get all the details for each configuration
			MySqlCommand command = new MySqlCommand("GetUserCarConfigurations1", conn)
			{
				CommandType = CommandType.StoredProcedure
			};

			conn.Open();
			command.Parameters.AddWithValue("@ID", id);
			command.Prepare();

			// Alternative approach
			//using (MySqlDataAdapter adapter = new MySqlDataAdapter())
			//{
			//  adapter.SelectCommand = command;
			//  using (DataSet ds = new DataSet())
			//  {
			//    adapter.Fill(ds);
			//  }
			//}

			List<ClsUserConfiguration> userConfigurations = new List<ClsUserConfiguration>();
			List<ClsUserCarConfiguration> userCarConfigurations = new List<ClsUserCarConfiguration>();

			using (MySqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					userConfigurations.Add(new ClsUserConfiguration
					{
						Id = reader.GetInt32(0),
						Description = reader.GetString(1),
						UserId = reader.GetInt32(2),
						CarId = reader.GetInt32(3)
					});
				}

				// Get next data set
				reader.NextResult();

				while (reader.Read())
				{
					userCarConfigurations.Add(new ClsUserCarConfiguration
					{
						Id = reader.GetInt32(0),
						UserId = reader.GetInt32(1),
						Modification = reader.GetInt32(2),
						ConfigurationId = reader.GetInt32(3),
						ModificationName = reader.GetString(4),
						Price = reader.GetFloat(5)
					});
				}
			}

			conn.Close();

			return new Tuple<List<ClsUserConfiguration>, List<ClsUserCarConfiguration>>(userConfigurations,
				userCarConfigurations);
		}

		public ClsCar GetCar(int carId)
		{
			var conn = this.GetConnection();
			// Get all configurations for that user
			// Get all the details for each configuration
			string sql = @"SELECT t_Cars.*, t_Car_models.model, t_Cars_type.type FROM t_Cars
      LEFT JOIN t_Car_models ON t_Cars.model = t_Car_models.ID
      LEFT JOIN t_Cars_type ON t_Cars.type = t_Cars_type.ID
      WHERE t_Cars.ID = @ID";

			MySqlCommand command = new MySqlCommand(sql, conn);

			conn.Open();
			command.Parameters.AddWithValue("@ID", carId);
			command.Prepare();

			var reader = command.ExecuteReader();
			// read once
			reader.Read();
			var car = new ClsCar
			{
				Id = reader.GetInt32(0),
				ModelId = reader.GetInt32(1),
				TypeId = reader.GetInt32(2),
				Year = reader.GetInt32(3),
				Price = reader.GetFloat(4),
				Model = reader.GetString(5),
				Type = reader.GetString(6),
				CarConfigurationsChosen = new Dictionary<string, bool>()
			};
			conn.Close();

			return car;
		}

		// Get all cars with given IDs
		public Dictionary<int, ClsCar> GetCars(int[] carIds)
		{
			var conn = this.GetConnection();
			// Get all configurations for that user
			// Get all the details for each configuration
			string sql = @"SELECT t_Cars.*, t_Car_models.model, t_Cars_type.type FROM t_Cars
      LEFT JOIN t_Car_models ON t_Cars.model = t_Car_models.ID
      LEFT JOIN t_Cars_type ON t_Cars.type = t_Cars_type.ID
      WHERE t_Cars.ID IN (";

			foreach (var t in carIds)
			{
				sql += $"{t},";
			}

			// Replace last comma
			sql = sql.Remove(sql.Length - 1, 1) + ");";

			MySqlCommand command = new MySqlCommand(sql, conn);

			conn.Open();

			var reader = command.ExecuteReader();
			Dictionary<int, ClsCar> cars = new Dictionary<int, ClsCar>();
			int i = 0;
			while (reader.Read())
			{
				cars.Add(reader.GetInt32(0), new ClsCar
				{
					Id = reader.GetInt32(0),
					ModelId = reader.GetInt32(1),
					TypeId = reader.GetInt32(2),
					Year = reader.GetInt32(3),
					Price = reader.GetFloat(4),
					Model = reader.GetString(5),
					Type = reader.GetString(6),
					CarConfigurationsChosen = new Dictionary<string, bool>()
				});
				i++;
			}

			conn.Close();

			return cars;
		}

		public List<CarCustomizationAvailable> CarConfigurationsAvailable(int carId)
		{
			var conn = this.GetConnection();

			// Get all modifications AVAILABLE for that car id
			string sql = @"SELECT T_modification_available.*
      FROM t_car_to_modification 
      LEFT JOIN T_modification_available ON t_car_to_modification.modification_id = T_modification_available.ID
      WHERE t_car_to_modification.car_id = @id";

			MySqlCommand command = new MySqlCommand(sql, conn);

			conn.Open();
			command.Parameters.AddWithValue("@ID", carId.ToString());
			command.Prepare();

			var reader = command.ExecuteReader();
			// read once
			var customizationsAvailable = new List<CarCustomizationAvailable>();
			while (reader.Read())
			{
				customizationsAvailable.Add(new CarCustomizationAvailable
				{
					Id = reader.GetInt32(0),
					Modifications = reader.GetString(1),
					Price = reader.GetFloat(2)
				});
			}

			;

			conn.Close();

			return customizationsAvailable;
		}

		public void AddUserCarConfiguration(ClsCar car, int userId)
		{
			var conn = this.GetConnection();
			// Add user config
			string addUserConfig = $@"INSERT INTO t_User_configuration (ID, description, user_id, car_id, review) 
                VALUES (NULL, 'App made config', '{userId}', '{car.Id}', 1); SELECT last_insert_id();";
			MySqlCommand command = new MySqlCommand(addUserConfig, conn);
			conn.Open();
			// We get the config id from the SELECT last_insert_id(); statement
			var configId = (ulong) command.ExecuteScalar();

			// Add modification to the config
			string AddUserCarConfig =
				"INSERT INTO t_User_car_configuration (ID, user_id, modification, configuration_id) VALUES";
			foreach (var config in car.CarConfigurationsChosen)
			{
				// User has selected that config option
				if (config.Value == true)
				{
					AddUserCarConfig += $"(NULL, '{userId}', '{config.Key}', '{configId}'),";
				}
			}

			// Replace last comma with a ';'
			AddUserCarConfig = AddUserCarConfig.Remove(AddUserCarConfig.Length - 1, 1) + ";";

			// re-use command
			command.Parameters.Clear();
			command.CommandText = AddUserCarConfig;
			command.ExecuteNonQuery();

			conn.Close();
		}

		public List<ClsSalesmanUserCarConfiguration> GetUsersCarsForReview()
		{
			var conn = this.GetConnection();

			string sql = @"SELECT
        `t_User_configuration`.*,
        `t_User_car_configuration`.`modification`,
        `t_Cars`.`model`,
        `t_Cars`.`type`,
        `t_Cars`.`year`,
        `t_Cars`.`price`,
        `t_Cars_type`.`type`,
        `t_Car_models`.`model`
      FROM
        `t_User_configuration`
      LEFT JOIN `t_User_car_configuration` ON `t_User_car_configuration`.`configuration_id` = `t_User_configuration`.`ID`
      LEFT JOIN `t_Cars` ON `t_User_configuration`.`car_id` = `t_Cars`.`ID`
      LEFT JOIN `t_Cars_type` ON `t_Cars`.`type` = `t_Cars_type`.`ID`
      LEFT JOIN `t_Car_models` ON `t_Cars`.`model` = `t_Car_models`.`ID` 
      WHERE `t_User_configuration`.`review` = 1
      ORDER BY `t_Cars_type`.`ID` ASC";

			MySqlCommand command = new MySqlCommand(sql, conn);
			conn.Open();

			var cars = new List<ClsSalesmanUserCarConfiguration>();
			using (MySqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					cars.Add(new ClsSalesmanUserCarConfiguration()
					{
						ConfigId = reader.GetInt32(0),
						ConfigDescription = reader.GetString(1),
						UserId = reader.GetInt32(2),
						CarId = reader.GetInt32(3),
						Review = reader.GetBoolean(4),
						WasReviewed = reader.GetBoolean(5),
						ModificationId = reader.GetInt32(6),
						ModelId = reader.GetInt32(7),
						TypeId = reader.GetInt32(8),
						Year = reader.GetInt32(9),
						Price = reader.GetFloat(10),
						Type = reader.GetString(11),
						Model = reader.GetString(12),
					});
				}
			}

			conn.Close();
			return cars;
		}

		public List<CarConfigsForReview> GetUsersConfigForReview()
		{
			var conn = this.GetConnection();
			string sql = "SELECT * FROM `t_User_configuration` WHERE `review` = 1";

			MySqlCommand command = new MySqlCommand(sql, conn);
			var cars = new List<CarConfigsForReview>();

			conn.Open();
			using (MySqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					cars.Add(new CarConfigsForReview()
					{
						Id = reader.GetInt32(0),
						Description = reader.GetString(1),
						UserId = reader.GetInt32(2),
						CarId = reader.GetInt32(3),
						Review = reader.GetBoolean(4),
						WasReviewed = reader.GetBoolean(5)
					});
				}
			}

			conn.Close();

			return cars;
		}
	}
}