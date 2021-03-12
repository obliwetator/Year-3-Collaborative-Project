using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;

namespace GroupProject.Classes
{

  class clsDatabase
  {
    private const string connString = "Server=plesk.remote.ac;database=ws330584_dealership;user=ws330584_dealership;password=Password123;CharSet=utf8;";

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
      MySqlDataReader reader = command.ExecuteReader();

      while (reader.Read())
      {
        Console.WriteLine(reader.GetValue(0));
      }

      conn.Close();
    }
  }
}
