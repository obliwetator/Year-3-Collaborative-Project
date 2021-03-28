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
    public partial class AddingCar : Form
    {
        public AddingCar()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection myCon = GetConnection();


        }
    }
}
