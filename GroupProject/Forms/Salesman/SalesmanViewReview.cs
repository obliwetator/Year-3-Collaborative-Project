using System;
using System.Windows.Forms;
using GroupProject.Classes;
using GroupProject.Classes.Salesman;

namespace GroupProject.Forms.Salesman
{
	// Car review will always lead to ViewInvoice
	// It's a way for the salesman to provide feedback to the user
	public partial class SalesmanViewReview : Form
	{
		public SalesmanViewReview()
		{
			InitializeComponent();
		}

		private void SalesmanViewReview_Load(object sender, EventArgs e)
		{
			dataGridView1.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			ClsDatabase database = new ClsDatabase();

			var CarsForReview = database.GetUsersConfigForReview();
			
			// TODO: Replace id with something else
			foreach (var t in CarsForReview)
			{
				dataGridView1.Rows.Add(
					t.Id,
					t.Description,
					t.UserId,
					t.CarId
				);
			}
		}
	}
}