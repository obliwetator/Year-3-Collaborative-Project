using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using GroupProject.Classes;

namespace GroupProject.Forms.Admin
{
    public partial class AdminUpdatingPage : Form
    {
        private const string conString = "server=plesk.remote.ac;user=ws330584_dealership;database=ws330584_dealership;password=Password123;CharSet=UTF8;";  //conect to plesk databse 
        public AdminUpdatingPage()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSaveUpdate_Click(object sender, System.EventArgs e)
        {
           MySqlConnection myCom = new MySqlConnection();
            String sCommand = "(UPDATE `t_Cars` SET `ID`=[value-1],`model`=@model,`type`=@type,`year`=@year,`price`=@price WHERE @ID)";
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
            catch(Exception)
            {

            }


        }

        private void AdminUpdatingPage_Load(object sender, EventArgs e)
        {
           
        }
    }
}
