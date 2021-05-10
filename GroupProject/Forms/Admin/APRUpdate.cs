using System;
using System.Windows.Forms;
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

			var APR = ClsDatabase.GetAPRs();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
			this.Close();
			AdminDashboard f3 = new AdminDashboard();
			f3.Show();

		}
	}
}