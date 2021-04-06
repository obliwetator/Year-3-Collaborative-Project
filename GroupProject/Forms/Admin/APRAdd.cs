using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace GroupProject.Forms.Admin
{
    
    public partial class APR : Form
    {
        private const string conString = "server=plesk.remote.ac;user=ws330584_dealership;database=ws330584_dealership;password=Password123;CharSet=UTF8;";
        public APR()
        {
            InitializeComponent();
        }

        private void btnAPR_Click(object sender, EventArgs e)
        {
            // TODO: Move th sql to the database file?
            MySqlConnection cnn = new MySqlConnection(conString);
            //                                                                 
          
            string sql = $"INSERT INTO `t_APR` (`ID`, `APR`, `Time`) VALUES (NULL, '${txtAPR.Text}', ${txtTime.Text})";
            MySqlCommand sqlCom = new MySqlCommand(sql, cnn);

            sqlCom.ExecuteNonQuery();

            //sqlcCom.ExecuteNonQuery();
            // TODO: Execute the query
            // TODO: Ability to delete APRs? // added this to APRUpdate. 

        }

        private void APR_Load(object sender, EventArgs e)
        {

        }
    }
}
