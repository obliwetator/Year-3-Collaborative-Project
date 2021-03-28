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

namespace GroupProject
{
    
    public partial class APR : Form
    {
       private const string conString = "server=plesk.remote.ac;user=ws330584_dealership;database=ws330584_dealership;password=Password123;CharSet=UTF8;";
        public APR()
        {
            InitializeComponent();
        }

        private void btnAPR_Click(object sender, EventArgs e)
        {


            MySqlConnection cnn = new MySqlConnection(conString); 
            string comString = "INSERT INTO `t_APR`( `APR`, `Time`) VALUES ('" + txtAPR + "', '" + txtTime + "')";
            MySqlCommand sqlCom = new MySqlCommand(comString, cnn); 
        }
    }
}
