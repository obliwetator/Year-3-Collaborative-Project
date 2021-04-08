using System;
using System.Windows.Forms;

namespace GroupProject.Forms.Admin
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
            AdminUpdatingForm f3 = new AdminUpdatingForm();
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
            DeleteForm f5 = new DeleteForm();
            f5.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            AddingCar f6 = new AddingCar();
            f6.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f7 = new APRUpdate();
            f7.Show();
        }
    }
}
