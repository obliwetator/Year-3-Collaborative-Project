using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using GroupProject.Classes;

namespace GroupProject.Forms.Admin
{
	public partial class APRUpdate : Form
	{
		private const string conString = "server=plesk.remote.ac;user=ws330584_dealership;database=ws330584_dealership;password=Password123;CharSet=UTF8;";  //conect to plesk databse 

		public APRUpdate()
		{
			InitializeComponent();
		}

		private void APRUpdate_Load(object sender, EventArgs e)
		{
			dataGridAPR.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			Database database = new Database();

			var APR = database.GetAPRs();
			
			// TODO: Format them in a nicer way?

			for (int i = 0; i < APR.Count; i++)
			{
				dataGridAPR.Rows.Add(	
					APR[i].Id,
					APR[i].Apr,
					APR[i].Time
				);	
			}
		}

		private void dataGridAPR_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			throw new System.NotImplementedException();
		}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
			MySqlConnection myCom  = new MySqlConnection(conString);

			//string sCommand = "UPDATE `t_APR` SET `APR`= '"+txtAPRUpdate.Text+'",`Time`= '"+ txtTimeUpdate.text+"' WHERE `ID` = ;
			//MySqlCommand myCommand = new MySqlCommand(sCommand, myCom);

			MySqlCommand myCommand = new MySqlCommand("UpdateAPR");
			myCommand.CommandType = CommandType.StoredProcedure;
			myCommand.Connection = myCom;

			try
			{
				myCom.Open();

				myCommand.Parameters.AddWithValue("@id", txtUpdateID.Text);
				myCommand.Parameters.AddWithValue("@apr", txtAPRUpdate.Text);
				myCommand.Parameters.AddWithValue("@time", txtTimeUpdate.Text);
				myCommand.Prepare();

				myCommand.ExecuteNonQuery();

				myCom.Close();
			}
			catch (Exception ex)
			{

			}


		}
    }
}