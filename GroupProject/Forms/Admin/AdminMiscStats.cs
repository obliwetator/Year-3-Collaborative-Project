using System;
using System.Windows.Forms;
using GroupProject.Classes;

namespace GroupProject.Forms.Admin
{
	public partial class AdminMiscStats : Form
	{
		private Form _previousForm;
		public AdminMiscStats(Form previousForm)
		{
			_previousForm = previousForm;
			InitializeComponent();
		}

		private void HowManyInvoicesCompleted_Click(object sender, EventArgs e)
		{
			long count = ClsDatabase.GetHowManyInvoicesHaveBeenCompleted();

			MessageBox.Show($"{count} Invoices have been completed", "Success", MessageBoxButtons.OK);
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			_previousForm.Show();
		}

        private void AdminMiscStats_Load(object sender, EventArgs e)
        {

        }
    }
}