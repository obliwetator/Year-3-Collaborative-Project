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
using GroupProject.Classes.Car;
using GroupProject.Forms.User;

namespace GroupProject
{
    public partial class UserBrowseVehicles : Form
    {
        const string conString = "server=plesk.remote.ac;user=ws330584_dealership;database=ws330584_dealership;password=Password123;CharSet=UTF8;";//get connection

      

        public UserBrowseVehicles()
        {
            InitializeComponent();
        }

        private void UserBrowseVehicles_Load(object sender, EventArgs e)
        {

            MySqlConnection myCon = new MySqlConnection(conString);
            //DataTable dtCars = new DataTable;

            string sComString = "SELECT `t_Cars`.`ID`, `t_Car_models`.`model` " +
                "FROM `t_Cars` " +
                "INNER JOIN `t_Car_models` ON `t_Cars`.`model`=`t_Car_models`.`ID`  ";
              
            MySqlCommand com = new MySqlCommand(sComString, myCon);


            try
            {
                myCon.Open();

                using (MySqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cboVehicles.Items.Add(reader.GetValue(0).ToString());
                    }
                }
                myCon.Close();
            }
            catch (Exception ex)
            {

            }
            cboVehicles.SelectedIndex = 0;


        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            var CustomerDashboardform = new CustomerDashboardform();
            this.Hide();
            CustomerDashboardform.Show();
        }

        private void cboVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            ClsCar car = new ClsCar();
          //  car.Id = cboVehicles.SelectedItem
          //  var ConfirmCarChoice = new UserConfirmCarChoice();
            this.Hide();
           // ConfirmCarChoice.Show();

        }
    }
}
