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
using GroupProject.Classes;

namespace GroupProject
{
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
        }



        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            const string conString = "server=plesk.remote.ac;user=ws330584_dealership;database=ws330584_dealership;password=Password123;CharSet=UTF8;";
            MySqlConnection cnn = new MySqlConnection(conString);

            string sCom = "SELECT `user_type`, `id` FROM `t_User` WHERE `username` = @username AND `password` = @password";

            MySqlCommand comm = new MySqlCommand(sCom, cnn);

            try
            {
                cnn.Open();

                comm.Parameters.AddWithValue("@username", txtUsername.Text);
                comm.Parameters.AddWithValue("@password", txtPassword.Text);
                comm.Prepare();


                clsUser.SUsername = txtUsername.Text;
                clsUser.SPassowrd = txtPassword.Text;

                using (MySqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clsUser.SUser_type = reader.GetValue(0).ToString();
                        clsUser.ID1 = reader.GetInt32(1);
                    }

                    cnn.Close();
                }
            }
            catch (Exception ex)
            {

            }


            if (String.Equals(clsUser.SUser_type, "Customer"))
            {
                var CustomerDashboardform = new CustomerDashboardform();

                this.Hide();

                CustomerDashboardform.Show();
                          

            }

            else if (String.Equals(clsUser.SUser_type, "Admin"))
             {
                 var AdminDashboard = new AdminDashboard();

                 this.Hide();

                 AdminDashboard.Show();
             }
            
           else if  (String.Equals(clsUser.SUser_type, "Sales"))
             {
                 var SalesDashboard = new SalesDashboard();

                 this.Hide();

                 SalesDashboard.Show();
             }

           else
            {
                MessageBox.Show("Invalid Username or Password !");
            }



            }
    
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
