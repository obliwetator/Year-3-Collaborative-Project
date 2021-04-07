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
    public partial class CustomerDashboardform : Form
    {
        public CustomerDashboardform()
        {
            InitializeComponent();
        }

        private void CustomerDashboardform_Load(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void btnLoadConfig_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var UserBrowseVehicles = new UserBrowseVehicles();

            this.Hide();

            UserBrowseVehicles.Show();
        }
    }
}
