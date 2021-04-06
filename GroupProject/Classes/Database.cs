using System.Collections.Generic;
using GroupProject.Classes.Admin;
using MySql.Data.MySqlClient;



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


        public List<ClsApr> GetAPRs()
        {
            var conn = this.GetConnection();

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

        public List<ClsApr> Update()
        {
            var conn = this.GetConnection();

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
    }
}
