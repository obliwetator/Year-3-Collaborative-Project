using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupProject.Classes.User;
using MySql;
using MySql.Data.MySqlClient;

namespace GroupProject.Classes
{

  class clsDatabase
  {
    private const string connString = "Server=plesk.remote.ac;database=WS295203_new_db;user=WS295203_CollabUser;password=okcpli4t94;CharSet=utf8;";

    public MySqlConnection GetConnection()
    {
      MySqlConnection cnn = new MySqlConnection(connString);

      return cnn;
    }

    // Temporary hard coded value. We will get the actual ad when user selects a car
    public void GetUserCarConfigurations(int ID = 1)
    {
      var conn = this.GetConnection();
      // Get all configurations for that user
      // Get all the details for each configuration
      MySqlCommand command = new MySqlCommand("GetUserCarConfigurations", conn);
      command.CommandType = CommandType.StoredProcedure;

      conn.Open();


      command.Parameters.AddWithValue("@ID", ID);
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
          userConfigurations.Add(new clsUserConfiguration { 
            ID = reader.GetInt32(0),
            description = reader.GetString(1),
            user_id = reader.GetInt32(2),
            car_id = reader.GetInt32(3)
          });
        }

        if (reader.NextResult())
        {
          while (reader.Read())
          {
            userCarConfigurations.Add(new clsUserCarConfiguration
            {
              ID = reader.GetInt32(0),
              user_id = reader.GetInt32(1),
              modification = reader.GetInt32(2),
              configuration_id = reader.GetInt32(3)
            });
          }
        }
      }
      conn.Close();
    }


  }
}
