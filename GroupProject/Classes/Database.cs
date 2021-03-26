using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace GroupProject.Classes
{
    class Database
    {
        private const string conString = "server=plesk.remote.ac;user=ws330584_dealership;database=ws330584_dealership;password=Password123;CharSet=UTF8;";  //conect to plesk databse 

        public MySqlConnection GetConnection()
        {
            MySqlConnection cnn = new MySqlConnection(conString); // create SQL connection 
            return cnn;
        }

        
    }
}
