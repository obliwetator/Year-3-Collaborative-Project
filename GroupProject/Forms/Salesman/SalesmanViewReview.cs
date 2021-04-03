using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GroupProject.Classes;
using GroupProject.Classes.Car;
using GroupProject.Classes.Salesman;

namespace GroupProject.Forms.Salesman
{
	// Car review will always lead to ViewInvoice
	// It's a way for the salesman to provide feedback to the user
	public partial class SalesmanViewReview : Form
	{
		private Dictionary<int, ClsModifications> _modificationsMap;
		public SalesmanViewReview()
		{
			InitializeComponent();
		}

		private void SalesmanViewReview_Load(object sender, EventArgs e)
		{
			this.InitDataGridView();
			this._modificationsMap = ClsDatabase.GetModificationsAvailable();
			var CarsForReview = ClsDatabase.GetUsersCarsForReview();

			foreach (var cars in CarsForReview)
			{
				dataGridView1.Rows.Add(
					cars.ConfigId,
					cars.UserId,
					cars.ConfigDescription,
					cars.Model,
					cars.Type
				);
			}

		}

		private void InitDataGridView()
		{
			this.dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
			this.dataGridView1.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;         
			this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;         
			this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}

		private void DataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			// TODO: DO something with the config (display editable info, message box for review)
			var dataGridView = (DataGridView) sender;
			// Rows will always be 0 since user can select only 1 row
			// 0 for ConfigID / 1 for UserID / 2 for Desc / 3 for Model / 4 for Type
			var configId = (int)dataGridView.SelectedRows[0].Cells[0].Value;
			var userId = (int)dataGridView.SelectedRows[0].Cells[1].Value;
			// TODO: Add caching
			var modifications = ClsDatabase.GetModificationsForConfigId(configId, userId);

			for (int i = 0; i < modifications.Count; i++)
			{
				this.Controls.Add(new Label()
				{
					Text = this._modificationsMap[modifications[i]].Modification,
					Location = new Point(550, 20 + (i * 30)),
					AutoSize = true,
				});	
				this.Controls.Add(new Label()
				{
					Text = this._modificationsMap[modifications[i]].Price.ToString(),
					Location = new Point(600, 20 + (i * 30)),
					AutoSize = true,
				});	
			}
		}
		
	}
}