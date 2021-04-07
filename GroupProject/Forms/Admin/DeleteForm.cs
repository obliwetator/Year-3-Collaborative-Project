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

namespace GroupProject.Forms.Admin
{
    public partial class DeleteForm : Form
    {
        private const string conString = "server=plesk.remote.ac;user=ws330584_dealership;database=ws330584_dealership;password=Password123;CharSet=UTF8;";
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashbord f1 = new AdminDashbord();
            f1.Show();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MySqlConnection myCon = new MySqlConnection(conString);
            //String sCommand = "(DELETE FROM `t_Cars` WHERE `ID` = $"{txtDelete.Text }")";
           // MySqlCommand myCom = new MySqlCommand(sCommand, myCon); 
        }
    }
}
