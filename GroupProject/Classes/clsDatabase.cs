using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;

namespace practical_16_11.Classes
{

  class clsDatabase
  {
    private const string connString = "Server=plesk.remote.ac;database=WS295203_COllabDB;user=WS295203_CollabUser;password=CollabUser1;CharSet=utf8;";

    public MySqlConnection GetConnection()
    {
      MySqlConnection cnn = new MySqlConnection(connString);

      return cnn;
    }
  }
}
