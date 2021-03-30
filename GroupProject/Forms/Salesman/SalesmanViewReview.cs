using System;
using System.Drawing;
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
			this.dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
			this.dataGridView1.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;         
			this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;         
			this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			var CarsForReview = ClsDatabase.GetUsersCarsForReview();

			foreach (var cars in CarsForReview)
			{
				dataGridView1.Rows.Add(
					cars.UserId,
					cars.ConfigDescription,
					cars.Model,
					cars.Type
				);
			}

		}
		
		private void DataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			// TODO: DO something with the config (display editable info, message box for review)
			var dataGridView = (DataGridView) sender;
			// Rows will always be 0 since user can select only 1 row
			// 0 for ConfigID / 1 for Desc / 2 for Model / 3 for Type
			var configId = (int)dataGridView.SelectedRows[0].Cells[0].Value;
		}
	}
}