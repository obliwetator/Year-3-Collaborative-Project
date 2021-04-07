using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GroupProject.Forms.Admin;

namespace GroupProject
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard f2 = new AdminDashboard();
            f2.Show();

        }
    }
}
