using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace GroupProject
{
    public partial class StatsSalemen : Form
    {
        private const string conString = "server=plesk.remote.ac;user=ws330584_dealership;database=ws330584_dealership;password=Password123;CharSet=UTF8;";
        
        public StatsSalemen()
        {
            InitializeComponent();
        }

        private void cboSalesmen_SelectedIndexChanged(object sender, EventArgs e)
        {

            MySqlConnection cnn = new MySqlConnection(conString); //conection 

            string comString = "SELECT `Name`, `Completed`, `Outstanding`, `Income` FROM `t_Salesman` WHERE = " + cboSalesmen.SelectedItem.ToString(); //command string 
            MySqlCommand sqlCom = new MySqlCommand(comString, cnn); //command 

            try
            {
                cnn.Open();    // open connection 

                using (MySqlDataReader reader = sqlCom.ExecuteReader()) //reciving information from database 
                {
                    while (reader.Read())
                    {
                        lblName.Text = reader.GetValue(0).ToString();
                        lblComplete.Text = reader.GetValue(1).ToString();
                        lblOutstanding.Text = reader.GetValue(2).ToString();
                        lblIncome.Text = reader.GetValue(3).ToString();
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
