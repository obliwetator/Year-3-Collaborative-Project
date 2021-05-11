using System;
using System.Drawing;
using System.Windows.Forms;

namespace GroupProject.Forms.Admin
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
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
            AddingCar f6 = new AddingCar();
            f6.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f7 = new APRUpdate();
            f7.Show();
        }

        private void btnMiscStats_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMiscStats userConfirmCarChoice = new AdminMiscStats(this)
            {
                Location = this.Location,
                Size = new Size(500, 400),
                // Otherwise we can't put the form where we want
                StartPosition = FormStartPosition.Manual
            };

            userConfirmCarChoice.Show();
        }

       /* private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AdminDashboard
            // 
            this.ClientSize = new System.Drawing.Size(1240, 517);
            this.Name = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.ResumeLayout(false);

        }*/

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Login f1 = new Login();
            f1.Show();
        }

        /* private void InitializeComponent()
         {
             this.SuspendLayout();
             // 
             // AdminDashboard
             // 
             this.ClientSize = new System.Drawing.Size(721, 388);
             this.Name = "AdminDashboard";
             this.ResumeLayout(false);

         }*/
    }
}
