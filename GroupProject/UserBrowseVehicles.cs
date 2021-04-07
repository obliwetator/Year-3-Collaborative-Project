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
    public partial class UserBrowseVehicles : Form
    {
        public UserBrowseVehicles()
        {
            InitializeComponent();
        }

        private void UserBrowseVehicles_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            var CustomerDashboardform = new CustomerDashboardform();
            this.Hide();
            CustomerDashboardform.Show();
        }

        private void cboVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            const string conString = "server=plesk.remote.ac;user=ws330584_dealership;database=ws330584_dealership;password=Password123;CharSet=UTF8;";//get connection
            MySqlConnection cnn = new MySqlConnection(conString);

            string sCom = "";

            MySqlCommand comm = new MySqlCommand(sCom, cnn);
        }
    }
}
