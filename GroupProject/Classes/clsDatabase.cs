using System.Collections.Generic;
using System.Data;
using GroupProject.Classes.Car;
using GroupProject.Classes.User;
using MySql.Data.MySqlClient;

namespace GroupProject.Classes
{

  class ClsDatabase
  {
    private const string ConnString = "Server=plesk.remote.ac;database=ws330584_dealership;user=ws330584_dealership;password=Password123;CharSet=utf8;";

    public MySqlConnection GetConnection()
    {
      MySqlConnection cnn = new MySqlConnection(ConnString);

      return cnn;
    }

    // Temporary hard coded value. We will get the actual ad when user selects a car
    public void GetUserCarConfigurations(int id = 1)
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

      List<clsUserConfiguration> userConfigurations = new List<clsUserConfiguration>();
      List<clsUserCarConfiguration> userCarConfigurations = new List<clsUserCarConfiguration>();

      using (MySqlDataReader reader = command.ExecuteReader())
      {

        while (reader.Read())
        {
          userConfigurations.Add(new clsUserConfiguration
          {
            ID = reader.GetInt32(0),
            description = reader.GetString(1),
            user_id = reader.GetInt32(2),
            car_id = reader.GetInt32(3)
          });
        }
		// Get next data set
        reader.NextResult();

        while (reader.Read())
        {
          userCarConfigurations.Add(new clsUserCarConfiguration
          {
            ID = reader.GetInt32(0),
            user_id = reader.GetInt32(1),
            modification = reader.GetInt32(2),
            configuration_id = reader.GetInt32(3),
            modification_name = reader.GetString(4)
          });
        }
      }
      conn.Close();
    }

    public ClsCar GetCar(int carId)
    {
      var conn = this.GetConnection();
      // Get all configurations for that user
      // Get all the details for each configuration
      string sql = @"SELECT t_Cars.*, t_Car_models.model, t_Cars_type.type FROM t_Cars
      LEFT JOIN t_Car_models ON t_Cars.model = t_Car_models.ID
      LEFT JOIN t_Cars_type ON t_Cars.type = t_Cars_type.ID
      WHERE t_Cars.ID = 1";
      
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
        Model = reader.GetString(4),
        Type = reader.GetString(5)
      };
      conn.Close();

      return car;
    }

    public void GetCarCustomizations(int carId)
    {

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
      while (reader.Read()){
        customizationsAvailable.Add(new CarCustomizationAvailable
        {
          Id = reader.GetInt32(0),
          Modifications = reader.GetString(1)
        });
      };
      
      conn.Close();

      return customizationsAvailable;
    }
  }
}
