﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using GroupProject.Classes.Admin;
using GroupProject.Classes.Car;
using GroupProject.Classes.Salesman;
using GroupProject.Classes.User;
using MySql.Data.MySqlClient;

namespace GroupProject.Classes
{
	static class ClsDatabase
	{
		private const string ConnString =
			"Server=plesk.remote.ac;database=ws330584_dealership;user=ws330584_dealership;password=Password123;CharSet=utf8;";

		private static MySqlConnection GetConnection()
		{
			MySqlConnection cnn = new MySqlConnection(ConnString);

			return cnn;
		}

		// Temporary hard coded value. We will get the actual ad when user selects a car
		public static Tuple<List<ClsUserConfiguration>, List<ClsUserCarConfiguration>> GetUserCarConfigurations(int id = 1)
		{
			var conn = GetConnection();
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
						CarId = reader.GetInt32(3),
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

		public static ClsCar GetCar(int carId)
		{
			var conn = GetConnection();
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
		public static Dictionary<int, ClsCar> GetCars(int[] carIds)
		{
			var conn = GetConnection();
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

		public static Dictionary<int, CarCustomizationAvailable> GetCarConfigurationsAvailable(int carId)
		{
			var conn = GetConnection();

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
			var customizationsAvailable = new Dictionary<int, CarCustomizationAvailable>();
			while (reader.Read())
			{
				customizationsAvailable.Add(reader.GetInt32(0) ,new CarCustomizationAvailable
				{
					Id = reader.GetInt32(0),
					Modifications = reader.GetString(1),
					Price = reader.GetFloat(2)
				});
			};

			conn.Close();

			return customizationsAvailable;
		}

		public static ulong AddUserCarConfiguration(ClsCar car, int userId, string comment, int aprSelected,
			bool review, bool purchase)
		{
			var conn = GetConnection();
			// Add user config
			string addUserConfig = $@"INSERT INTO t_User_configuration (ID, description, user_id, car_id, review, purchase, comment_for_review, APR) VALUES (NULL, 'App made config', '{userId}', '{car.Id}', '{(review ? "1" : "0")}', '{(purchase? "1" : "0")}', '{comment}', {aprSelected}); SELECT last_insert_id();";
			MySqlCommand command = new MySqlCommand(addUserConfig, conn);
			conn.Open();
			// We get the config id from the SELECT last_insert_id(); statement
			var configId = (ulong) command.ExecuteScalar();

			// Add modification to the config
			string addUserCarConfig = "INSERT INTO t_User_car_configuration (ID, user_id, modification, configuration_id) VALUES";
			int originalQueryLength = addUserCarConfig.Length;
			foreach (var config in car.CarConfigurationsChosen)
			{
				// User has selected that config option
				if (config.Value == true)
				{
					addUserCarConfig += $"(NULL, '{userId}', '{config.Key}', '{configId}'),";
				}
			}
			// No configs were added don't run the query
			if (originalQueryLength != addUserCarConfig.Length)
			{
				// Replace last comma with a ';'
				addUserCarConfig = addUserCarConfig.Remove(addUserCarConfig.Length - 1, 1) + ";";

				// re-use command
				command.Parameters.Clear();
				command.CommandText = addUserCarConfig;
				command.ExecuteNonQuery();
			}

			conn.Close();

			return configId;
		}

		public static List<ClsSalesmanUserCarConfiguration> GetUsersCarsForReview()
		{
			var conn = GetConnection();

			MySqlCommand command = new MySqlCommand("GetCArConfigForReview")
			{
				Connection = conn,
				CommandType = CommandType.StoredProcedure,
			};
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
						// We will still load configuration that were reviewed in case we might add the functionality
						// to edit already submitted configuration 
						WasReviewed = reader.GetBoolean(5),
						Purchase = reader.GetBoolean(6),
						// There might be no comment
						CommentForReview = reader.IsDBNull(7) ? "" : reader.GetString(7),
						ModelId = reader.GetInt32(8),
						TypeId = reader.GetInt32(9),
						Year = reader.GetInt32(10),
						Price = reader.GetFloat(11),
						Model = reader.GetString(12),
						Type = reader.GetString(13)
					});
				}
			}

			conn.Close();
			return cars;
		}

		public static List<CarConfigsForReview> GetUsersConfigForReview()
		{
			var conn = GetConnection();
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

		public static void UpdateUserCarConfiguration(ClsCar car, int userId, int configId, bool review, bool purchase)
		{
			var conn = GetConnection();
			string sql = $"UPDATE `t_User_configuration` SET `review` = '{(review ? "1" : "0")}', `purchase` = '{(purchase ? "1" : "0")}' WHERE `t_User_configuration`.`ID` = {configId}";

			MySqlCommand command = new MySqlCommand(sql, conn);

			conn.Open();
			command.ExecuteNonQuery();
			conn.Close();
		}

		static public List<ClsApr> GetAPRs()
        {
            var conn = GetConnection();

            string sql = "SELECT `id`, `apr`, `time` FROM `t_APR`";

            MySqlCommand command = new MySqlCommand(sql, conn);
            
            conn.Open();

            var apr = new List<ClsApr>();
            
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    apr.Add(new ClsApr()
                    {
                        Id = reader.GetInt32(0),
                        Apr = reader.GetInt32(1),
                        Time = reader.GetString(2)
                    });
                }
            }
            
            conn.Close();
            
            return apr;
        }

		public static List<int> GetModificationsForConfigId(int configId, int userId)
		{
			var conn = GetConnection();

			MySqlCommand command = new MySqlCommand("GetModificationsForConfigID", conn)
			{
				CommandType = CommandType.StoredProcedure,
			};

			command.Parameters.AddWithValue("@conf", configId);
			command.Parameters.AddWithValue("@user", userId);
			conn.Open();

			var mods = new List<int>();
			using (MySqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					mods.Add(reader.GetInt32(0));
				}
			}
			
			conn.Close();

			return mods;
		}

		public static Dictionary<int, ClsModifications> GetModificationsAvailable()
		{
			var conn = GetConnection();
			
			MySqlCommand command = new MySqlCommand("GetModificationsAvailable", conn)
			{
				CommandType = CommandType.StoredProcedure,
			};

			var mods = new Dictionary<int, ClsModifications>();
			
			conn.Open();
			using (MySqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					mods.Add(reader.GetInt32(0), new ClsModifications()
					{
						Id = reader.GetInt32(0),
						Modification = reader.GetString(1),
						Price = reader.GetFloat(2)
					});
				}
			}
			
			conn.Close();

			return mods;
		}

		public static void AddSalesmanConfigurationReview(string txtReviewText, HashSet<int> selectedMods, int configId, int salesmanId)
		{
			var conn = GetConnection();
			string sql = $@"INSERT INTO `t_Salesman_configuration_review` (`ID`, `salesman_id`, `config_id`, `comment`) VALUES (NULL, '{salesmanId}', '{configId}', '{txtReviewText}'); SELECT last_insert_id();
						UPDATE `t_User_configuration` SET `was_reviewed` = '1', `review` = 0 WHERE `t_User_configuration`.`ID` = {configId};		
			";
			
			MySqlCommand command = new MySqlCommand(sql, conn);
			conn.Open();
			// We get the config id from the SELECT last_insert_id(); statement
			var salesmanReviewId = (ulong) command.ExecuteScalar();
			
			// Add modification to the config
			string addUserCarConfig = "INSERT INTO `t_Salesman_configuration_review_car` (`ID`, `salesman_config_id`, `modification_id`) VALUES";
			int originalQueryLength = addUserCarConfig.Length;
			foreach (var modId in selectedMods)
			{
				addUserCarConfig += $"(NULL, '{salesmanReviewId}', {modId}),";
			}
			
			// No configs were added don't run the query
			if (originalQueryLength != addUserCarConfig.Length)
			{
				// Replace last comma with a ';'
				addUserCarConfig = addUserCarConfig.Remove(addUserCarConfig.Length - 1, 1) + ";";

				// re-use command
				command.Parameters.Clear();
				command.CommandText = addUserCarConfig;
				command.ExecuteNonQuery();
			}

			conn.Close();
		}

		public static List<ClsDiscount> GetAllDiscounts()
		{
			
			var conn = GetConnection();
			string sql = "SELECT * FROM `t_discount`";

			MySqlCommand command = new MySqlCommand(sql, conn);
			List<ClsDiscount> discount = new List<ClsDiscount>();
			conn.Open();
			using (MySqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					discount.Add(new ClsDiscount()
					{
						Id = reader.GetInt32(0),
						DiscountAmmount = reader.GetFloat(1),
						Type = reader.GetString(2),
					});
				}
			}
			
			conn.Close();

			return discount;
		}

		public static void FinalizeConfiguration(int configId, ClsDiscount discount, int userId, int salesmanId)
		{
			var conn = GetConnection();
			string sql = $"UPDATE `t_User_configuration` SET `purchased` = '1', `discount` = {discount.Id } WHERE `t_User_configuration`.`ID` = {configId};";
			string insertOrder = $"INSERT INTO `t_Order` (`salesman_id`, `user_id`, `config_id`) VALUES ('{salesmanId}', '{userId}', '{configId}')";
			MySqlCommand command = new MySqlCommand(sql, conn);
			
			conn.Open();

			command.ExecuteNonQuery();
			// new command
			command.CommandText = insertOrder;
			command.ExecuteNonQuery();
			
			conn.Close();
		}

		public static List<ClsSalesmanUserCarConfiguration> GetUsersCarsForApproval()
		{
			var conn = GetConnection();

			MySqlCommand command = new MySqlCommand("GetCArConfigForApproval")
			{
				Connection = conn,
				CommandType = CommandType.StoredProcedure,
			};
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
						// We will still load configuration that were reviewed in case we might add the functionality
						// to edit already submitted configuration 
						Purchase = reader.GetBoolean(4),
						// There might be no comment
						CommentForReview = reader.IsDBNull(5) ? "" : reader.GetString(5),
						ModelId = reader.GetInt32(6),
						TypeId = reader.GetInt32(7),
						Year = reader.GetInt32(8),
						Price = reader.GetFloat(9),
						Model = reader.GetString(10),
						Type = reader.GetString(11)
					});
				}
			}

			conn.Close();
			return cars;
		}

		public static void DeleteUserConfiguration(int configId)
		{
			string sql = $"DELETE FROM `t_User_configuration` WHERE `t_User_configuration`.`ID` = {configId}";
			var conn = GetConnection();

			MySqlCommand command = new MySqlCommand(sql, conn);
			conn.Open();

			command.ExecuteNonQuery();
			
			conn.Close();
		}

		public static long GetHowManyInvoicesHaveBeenCompleted()
		{
			string sql = "SELECT COUNT(ID) FROM `t_Order`";
			var conn = GetConnection();
			
			MySqlCommand command = new MySqlCommand(sql, conn);
			conn.Open();
	
			long count = (long)command.ExecuteScalar();
			
			conn.Close();

			return count;
		}
	}
}