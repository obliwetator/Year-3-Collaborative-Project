using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GroupProject.Classes;
using GroupProject.Classes.Car;
using GroupProject.Classes.Salesman;

namespace GroupProject.Forms.Salesman
{
	// Here the sale will be finalized. After an optional review
	public partial class SalesmanViewInvoice : Form
	{
		// User checkboxes
		private readonly Dictionary<int, Label> _labelMap = new Dictionary<int, Label>();
		
		private Dictionary<int, ClsModifications> _modificationsMap;
		private List<ClsSalesmanUserCarConfiguration> _carsForAproval;

		// By default there is no discount
		private ClsDiscount _discount = new ClsDiscount()
		{
			Id = 1,
			Type = "flat",
			DiscountAmmount = 0,
		};
		//TODO: Caching
		private List<int> _modifications;
		private int _salesmanId;
		// Hardcoded id
		public SalesmanViewInvoice(int salesmanId = 4)
		{
			this._salesmanId = salesmanId;
			InitializeComponent();
		}

		private void SalesmanViewInvoice_Load(object sender, EventArgs e)
		{
			this.InitDataGridView();
			
			this._modificationsMap = ClsDatabase.GetModificationsAvailable();
			this._carsForAproval = ClsDatabase.GetUsersCarsForApproval();
			
			foreach (var cars in _carsForAproval)
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
		
		// Runs everytime the selections is changed
		private void DataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			// We have at least 1 row to work with
			if (dataGridView1.Rows.Count > 0)
			{
				lblNothing.Visible = false;
				var dataGridView = (DataGridView) sender;
				// Rows will always be 0 since user can select only 1 row
				// 0 for ConfigID / 1 for UserID / 2 for Desc / 3 for Model / 4 for Type
				var configId = (int) dataGridView.SelectedRows[0].Cells[0].Value;
				var userId = (int) dataGridView.SelectedRows[0].Cells[1].Value;
				// TODO: Add caching
				_modifications = ClsDatabase.GetModificationsForConfigId(configId, userId);
				// Comment text
				lblUserComment.Text = _carsForAproval[dataGridView.SelectedRows[0].Index].CommentForReview;

				this.ShowUserModification(_modifications);
				this.DisplayTotalCarCost();
			}
			else
			{
				// no rows. Salesman has nothing to approve. Clear anything remaining
				lblTotalCost.Text = "";
				lblUserComment.Text = "";
				lblNothing.Visible = true;
			}
		}

		private void DisplayTotalCarCost()
		{
			float totalPrice = 0;
			for (int i = 0; i < _modifications.Count; i++)
			{
				totalPrice += _modificationsMap[_modifications[i]].Price;
			}

			totalPrice += _carsForAproval[dataGridView1.SelectedRows[0].Index].Price;
			if (_discount.Type == "flat")
			{
				totalPrice -= _discount.DiscountAmmount;
			}
			else if (_discount.Type == "percent")
			{
				totalPrice -= (totalPrice * (_discount.DiscountAmmount / 100));
			}

			lblTotalCost.Text ="£" + totalPrice.ToString();
		}

		private void ShowUserModification(List<int> modifications)
		{
			// Clear any previous checkboxes
			foreach (var label in this._labelMap)
			{
				this.Controls.Remove(label.Value);
			}
			this._labelMap.Clear();
			
			int j = 0;
			int k = 0;
			for (int i = 0; i < modifications.Count; i++)
			{
				// 3 checkboxes per row
				if (i % 3 == 0)
				{
					j++;
					k = 0;
				}
				var temp = new Label()
				{
					Location = new Point(500 + (180 * k), 20 + (j * 30)),
					Text = this._modificationsMap[modifications[i]].Modification + "   £" + this._modificationsMap[modifications[i]].Price.ToString(),
					Name = "1" + this._modificationsMap[modifications[i]].Id.ToString(),
					Height = 100,
					Width = 180,
					AutoSize = false,
				};
				
				k++;

				this.Controls.Add(temp);
				this._labelMap.Add(modifications[i], temp);
			}
		}

		private void btnApprove_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Are you sure you want to approve this configuration?", "Confirmation", MessageBoxButtons.YesNo);
			if(dialogResult == DialogResult.Yes)
			{
				var configId = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
				var userId = (int)dataGridView1.SelectedRows[0].Cells[1].Value;
				//TODO: send the finished config to db
				ClsDatabase.FinalizeConfiguration(configId, _discount, userId, _salesmanId);
				// Remove that entry for the data table
				dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
			}
			else if (dialogResult == DialogResult.No)
			{
				// Salesman did not proceed do nothing
			}
		}

		private void btnDiscount_Click(object sender, EventArgs e)
		{
			SalesmanDiscount userConfirmCarChoice = new SalesmanDiscount()
			{
				Location = this.Location,
				Size = new Size(500, 300),
				// Otherwise we can't put the form where we want
				StartPosition = FormStartPosition.Manual
			};

			var result = userConfirmCarChoice.ShowDialog();
			if (result == DialogResult.OK)
			{
				_discount = userConfirmCarChoice.Discount;            //values preserved after close
				this.DisplayTotalCarCost();
			}
		}
	}
}