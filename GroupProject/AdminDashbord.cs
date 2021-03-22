using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
