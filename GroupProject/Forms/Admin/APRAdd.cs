using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using GroupProject.Forms;
using GroupProject.Classes;

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
            //                                                                  Needs .Text            and here
           //  string comString = "INSERT INTO `t_APR`( `APR`, `Time`) VALUES ('" + txtAPR + "', '" + txtTime + "')";
            // Looks cleaner
            string sql = $"INSERT INTO `t_APR` (`ID`, `APR`, `Time`) VALUES (NULL, '${txtAPR.Text}', ${txtTime.Text})";
            MySqlCommand sqlCom = new MySqlCommand(sql, cnn); 
            
            // TODO: Execute the query
            // TODO: Ability to delete APRs?
            
        }

        private void APR_Load(object sender, EventArgs e)
        {

        }
    }
}
