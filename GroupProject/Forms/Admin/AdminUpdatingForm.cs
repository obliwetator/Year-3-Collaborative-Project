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

namespace GroupProject.Forms.Admin
{
    public partial class AdminUpdatingForm : Form
    {
        public AdminUpdatingForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MySqlConnection myCom = new MySqlConnection();
            String sCommand = "(UPDATE `t_Cars` SET `model`=@model,`type`=@type,`year`=@year,`price`=@price WHERE @ID)";
            MySqlCommand myCommand = new MySqlCommand(sCommand, myCom);

            try
            {
                myCom.Open();
                myCommand.Parameters.AddWithValue("@model", txtModelUpdate.Text);
                myCommand.Parameters.AddWithValue("@type", txtTypeUpdate.Text);
                myCommand.Parameters.AddWithValue("@year", txtYearUpdate.Text);
                myCommand.Parameters.AddWithValue("@price", txtPriceUpdate.Text);
                myCommand.Parameters.AddWithValue("@ID", txtIdUpdate.Text);
                myCommand.Prepare();
                myCommand.ExecuteNonQuery();

                myCom.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
