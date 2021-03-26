using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using GroupProject.Classes;

namespace GroupProject
{
    public partial class Delete : Form
    {
        private const string conString = "server=plesk.remote.ac;user=ws330584_dealership;database=ws330584_dealership;password=Password123;CharSet=UTF8;";
        public Delete()
        {
            InitializeComponent();
        }

        private void cboDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection(conString); //conection 

            string comString = "SELECT `ID` FROM `tbl_Car` WHERE `ID` = " + cboDelete.SelectedItem.ToString(); //command string 
            MySqlCommand sqlCom = new MySqlCommand(comString, cnn); //command 

            try
            {
                cnn.Open();    // open connection 

                using (MySqlDataReader reader = sqlCom.ExecuteReader()) //reciving information from database 
                {
                    while (reader.Read())
                    {
                        lblCarID.Text = reader.GetValue(0).ToString();
                       // lblScore.Text = reader.GetValue(1).ToString();
                    }
                }
                cnn.Close(); // close connection 
            }

            catch (Exception ex)
            {

            }

        }
    }
}
