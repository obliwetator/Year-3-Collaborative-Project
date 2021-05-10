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

namespace GroupProject.Forms.Admin
{
    public partial class AddingCar : Form
    {
        private const string conString = "server=plesk.remote.ac;user=ws330584_dealership;database=ws330584_dealership;password=Password123;CharSet=UTF8;";
        public AddingCar()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection myCom = new MySqlConnection(conString);
            string sql = $"INSERT INTO `t_Cars`(`model`, `type`, `year`, `price`) VALUES ({txtModel.Text},{txtType.Text},{txtYear.Text},{txtPrice.Text})";
            // MySqlCommand sqlCom = new MySqlCommand(sql, conString);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminDashboard f3 = new AdminDashboard();
            f3.Show();

        }
    }
}
