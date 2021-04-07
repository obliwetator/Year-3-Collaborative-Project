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
		// User checkboxes
		private readonly Dictionary<int, CheckBox> _checkBoxMap = new Dictionary<int, CheckBox>();
		// All checkboxes
		private readonly Dictionary<int, CheckBox> _checkBoxMapAll = new Dictionary<int, CheckBox>();
		// Any item ID will correspond to the modification ID that will be selected
		private readonly HashSet<int> _selectedMods = new HashSet<int>();
		// All modifications
		private Dictionary<int, ClsModifications> _modificationsMap;
		private List<ClsSalesmanUserCarConfiguration> _carsForReview;
		// By default there is no discount
		private ClsDiscount _discount = new ClsDiscount()
		{
			Id = 0,
			Type = "flat",
			DiscountAmmount = 0,
		};

		//TODO: Add caching
		private List<int> _modifications;
		private readonly int _salesmanId;

		public SalesmanViewReview(int salesmanId = 4)
		{
			this._salesmanId = salesmanId;
			InitializeComponent();
		}

		private void SalesmanViewReview_Load(object sender, EventArgs e)
		{
			this.InitDataGridView();
			
			this._modificationsMap = ClsDatabase.GetModificationsAvailable();
			this._carsForReview = ClsDatabase.GetUsersCarsForReview();
			
			foreach (var cars in _carsForReview)
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
			var dataGridView = (DataGridView) sender;
			// Rows will always be 0 since user can select only 1 row
			// 0 for ConfigID / 1 for UserID / 2 for Desc / 3 for Model / 4 for Type
			var configId = (int)dataGridView.SelectedRows[0].Cells[0].Value;
			var userId = (int)dataGridView.SelectedRows[0].Cells[1].Value;
			// TODO: Add caching
			_modifications = ClsDatabase.GetModificationsForConfigId(configId, userId);
			// Comment text
			lblUserComment.Text = _carsForReview[dataGridView.SelectedRows[0].Index].CommentForReview;

			this.ResetAllModificationCheckBoxes();
			// Show User's selected modifications as checkboxes
			// Those can be edited by the salesman and sent back in the review process
			this.ShowAvailableModifications(_carsForReview[dataGridView.SelectedRows[0].Index].CarId);
			this.ShowUserModification();
			this.DisplayTotalCarCost();
		}

		private void ResetAllModificationCheckBoxes()
		{
			foreach (var checkBox in _checkBoxMapAll)
			{
				checkBox.Value.Checked = false;
			}
		}

		// Runs once on load
		private void ShowAvailableModifications(int carId)
		{
			// Clear any previous checkboxes
			foreach (var checkBox in this._checkBoxMapAll)
			{
				this.Controls.Remove(checkBox.Value);
			}
			this._checkBoxMapAll.Clear();
			
			var modsForThatCar = ClsDatabase.GetCarConfigurationsAvailable(carId);
			int j = 0;
			int k = 0;
			int i = 0;
			foreach (var modification in modsForThatCar)
			{
				// 3 checkboxes per row
				if (i % 3 == 0)
				{
					j++;
					k = 0;
				}
				var temp = new CheckBox()
				{
					Location = new Point(500 + (180 * k), 190 + (j * 60)),
					Text = modification.Value.Modifications + "   £" + modification.Value.Price.ToString(),
					Name = "0" + modification.Value.Id,
					Height = 100,
					Width = 180,
					AutoSize = false,
					Checked = false,
				};
				
				temp.CheckedChanged += chck_CheckedChanged;

				i++;
				k++;
				_checkBoxMapAll.Add(modification.Key, temp);
				
				this.Controls.Add(temp);
			}
		}

		// Runs every time user changes selection
		private void ShowUserModification()
		{
			// Clear any previous checkboxes
			foreach (var checkBox in this._checkBoxMap)
			{
				this.Controls.Remove(checkBox.Value);
				// Add current selection to final selection
				_selectedMods.Add(checkBox.Key);
			}
			this._checkBoxMap.Clear();
			
			int j = 0;
			int k = 0;
			for (int i = 0; i < _modifications.Count; i++)
			{
				// 3 checkboxes per row
				if (i % 3 == 0)
				{
					j++;
					k = 0;
				}
				var temp = new CheckBox()
				{
					Location = new Point(500 + (180 * k), -30 + (j * 30)),
					Text = this._modificationsMap[_modifications[i]].Modification + "   £" + this._modificationsMap[_modifications[i]].Price.ToString(),
					Name = "1" + this._modificationsMap[_modifications[i]].Id.ToString(),
					Height = 100,
					Width = 180,
					AutoSize = false,
					Checked = true,
				};

				// Tick the all modification checkbox
				if (_checkBoxMapAll.ContainsKey(this._modificationsMap[_modifications[i]].Id))
				{
					_checkBoxMapAll[this._modificationsMap[_modifications[i]].Id].Checked = true;
				}

				temp.CheckedChanged += chck_CheckedChanged;

				k++;
				
				_checkBoxMap.Add(_modifications[i], temp);
				
				this.Controls.Add(temp);
			}
		}

		private void btnApprove_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Are you sure you want to approve this configuration with the selected changes?", "Confirmation", MessageBoxButtons.YesNo);
			if(dialogResult == DialogResult.Yes)
			{
				var configId = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
				ClsDatabase.AddSalesmanConfigurationReview(txtReview.Text, _selectedMods, configId, _salesmanId);
			}
			else if (dialogResult == DialogResult.No)
			{
				// Salesman did not proceed do nothing
			}
		}
		
		private void DisplayTotalCarCost()
		{
			float totalPrice = 0;
			for (int i = 0; i < _modifications.Count; i++)
			{
				totalPrice += _modificationsMap[_modifications[i]].Price;
			}

			totalPrice += _carsForReview[dataGridView1.SelectedRows[0].Index].Price;
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

		private void chck_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = (sender as CheckBox);
			// Remove prfix and get the mod ID
			var parsedId = int.Parse(checkBox.Name.Substring(1, checkBox.Name.Length - 1));
			// Decide whether to remove, add or do nothing with the current selection
			if (checkBox.Checked)
			{
				if (_selectedMods.Contains(parsedId))
				{
					// Already inside. Do nothing
				}
				else
				{
					_selectedMods.Add(parsedId);
				}
			}
			else
			{
				if (_selectedMods.Contains(parsedId))
				{
					// Element is in but value is unchecked. Remove it
					_selectedMods.Remove(parsedId);
				}
			}
			// Name starts with 0 is the salesman checkbox 
			// Name starts with 1 is the user checkbox
			
			// salesman
			if (checkBox.Name[0] == '0')
			{
				// Check if user has that checkbox
				if (_checkBoxMap.ContainsKey(parsedId))
				{
					// check the state
					if (checkBox.Checked == true)
					{
						_checkBoxMap[int.Parse(checkBox.Name.Substring(1, checkBox.Name.Length - 1))].Checked = true;
					}
					else if (checkBox.Checked == false)
					{
						// Try to un-check check all mod
						_checkBoxMap[int.Parse(checkBox.Name.Substring(1, checkBox.Name.Length - 1))].Checked = false;
					}
				}
				// no checkbox for user do nothing
			} 
			// user
			else if (checkBox.Name[0] == '1')
			{
				// No need to check if checkbox exists since the user checkboxes are a subset of all the checkboxes
				// check the state
				if (checkBox.Checked == true)
				{
					_checkBoxMapAll[parsedId].Checked = true;
				}
				else if (checkBox.Checked == false)
				{
					// Try to un-check check all mod
					_checkBoxMapAll[parsedId].Checked = false;
				}
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