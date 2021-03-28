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
            // TODO: Create adding car form
            //AddingCar f6 = new AddingCar();
            //f6.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f7 = new APRUpdate();
            f7.Show();
        }
    }
}
