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

namespace GroupProject
{
    public partial class AdminDashbord : Form
    {
        public AdminDashbord()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminUpdatingPage f3 = new AdminUpdatingPage();
            f3.Show();

        }

        private void btnSetApr_Click(object sender, EventArgs e)
        {
            this.Hide();
            APR f4 = new APR();
            f4.Show();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete f5 = new Delete();
            f5.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddingCar f6 = new AddingCar();
            f6.Show();
        }
    }
}
