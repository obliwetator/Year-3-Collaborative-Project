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
using GroupProject.Forms; 

namespace GroupProject.Forms.Admin
{
    public partial class AdminUpdatingForm : Form
    {
        const string conString = "server=plesk.remote.ac;user=ws330584_dealership;database=ws330584_dealership;password=Password123;CharSet=UTF8;";  //conect to plesk databse
       
        public AdminUpdatingForm()
        {
            InitializeComponent();
            
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MySqlConnection myCom = new MySqlConnection(conString);
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

        private void gvCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection myCon = new MySqlConnection(conString);
            MySqlCommand myCom = new MySqlCommand("Select * from  `t_Car`");
            MySqlDataAdapter dt = new MySqlDataAdapter();
            try
            {
                myCom.Connection = myCon;
                myCon.Open();
                dt.SelectCommand = myCom;

                DataTable dTable = new DataTable();
                dt.Fill(dTable);

                myCon.Close();
 
                gvCar.DataSource = dTable;
                

                
            }
            catch(Exception ex)
            {

            }

        }
    }
}
