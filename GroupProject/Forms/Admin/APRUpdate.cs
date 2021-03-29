using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using GroupProject.Classes;

namespace GroupProject.Forms.Admin
{
	public partial class APRUpdate : Form
	{
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
			MySqlConnection myCom  = new MySqlConnection(GetConnection);
        }
    }
}