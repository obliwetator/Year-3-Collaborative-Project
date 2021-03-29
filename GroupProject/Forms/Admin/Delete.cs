using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GroupProject.Forms.Admin
{
    public partial class Delete : Form
    {
        private const string conString = "server=plesk.remote.ac;user=ws330584_dealership;database=ws330584_dealership;password=Password123;CharSet=UTF8;";
        public Delete()
        {
            InitializeComponent();
        }

        private void cboDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection(conString); //conection 

            string comString = "SELECT `ID` FROM `tbl_Car` WHERE `ID` = " + cboDelete.SelectedItem.ToString(); //command string 
            MySqlCommand sqlCom = new MySqlCommand(comString, cnn); //command 

            try
            {
                cnn.Open();    // open connection 

                using (MySqlDataReader reader = sqlCom.ExecuteReader()) //reciving information from database 
                {
                    while (reader.Read())
                    {
                        lblCarID.Text = reader.GetValue(0).ToString();
                        // lblScore.Text = reader.GetValue(1).ToString();
                    }
                }
                cnn.Close(); // close connection 
            }

            catch (Exception ex)
            {

            }

        }

        private void Delete_Load(object sender, EventArgs e)
        {
            MySqlConnection myCom = new MySqlConnection(conString);

            // string sCommand = "SELECT `question` FROM `t_Question` WHERE `EID` = 1";
            MySqlCommand myCommand = new MySqlCommand("SelectAllCarId");
            myCommand.CommandType = System.Data.CommandType.StoredProcedure;
            //myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Connection = myCom;

            try
            {
                myCom.Open();

                MySqlDataReader reader = myCommand.ExecuteReader();


                while (reader.Read())
                {
                    cboDelete.Items.Add(reader.GetValue(0));


                }

            }
            catch(Exception ex){

            }


    }
    }
}



                
            

