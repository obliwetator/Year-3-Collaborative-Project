using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using GroupProject.Classes.Car;
using System.Text.Json;
using GroupProject.Classes;
using GroupProject.Classes.Admin;
using GroupProject.Classes.SerialzationClasses;

namespace GroupProject.Forms.User
{
	public partial class UserConfirmCarChoice : Form
	{
		private ulong? _submittedFormId;
		private enum SubmittedFromStatus
		{
			None,
			Purchase,
			Review,
		}

		private SubmittedFromStatus _submittedFromStatus = SubmittedFromStatus.None;
		
		private readonly ClsCar _car;
		private readonly int _userId;
		private readonly Dictionary<int, CarCustomizationAvailable> _carConfigurationsAvailable;
		private readonly string _comment;
		private List<ClsApr> _apr;
		private int _aprSelected;
		private float _totalPrice;
		private Form _formRef;

		// Default flow
		public  UserConfirmCarChoice(ClsCar car, int userId,
			Dictionary<int, CarCustomizationAvailable> carConfigurationsAvailable, string txtCommentText, Form formRef)
		{
			this._car = car;
			this._userId = userId;
			this._carConfigurationsAvailable = carConfigurationsAvailable;
			this._comment = txtCommentText;
			this._formRef = formRef;
			InitializeComponent();
		}
		
		// User tries to load a configuration
		public  UserConfirmCarChoice(ClsCar car, int userId, string txtCommentText, Form formRef)
		{
			this._car = car;
			this._userId = userId;
			this._comment = txtCommentText;
			this._carConfigurationsAvailable = ClsDatabase.GetCarConfigurationsAvailable(car.Id);
			this._formRef = formRef;
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// Displays a SaveFileDialog so the user can save the Configuration
			// assigned to btnSave.
			SaveFileDialog sfd = new SaveFileDialog
			{
				Filter = "JSON File|*.json",
				Title = "Save your configuration"
			};

			// to JSON
			string carJson = JsonSerializer.Serialize(new UserSaveLoadConfig()
			{
				car = _car,
				comment = _comment,
				userId = _userId,
			});
			
			// User most likely pressed cancel
			if (sfd.ShowDialog() != DialogResult.OK) return;
			// Don't proceed if user doesn't input file name in the prompt
			if (sfd.FileName != "")
			{
				File.WriteAllText(sfd.FileName, carJson);
			}
		}

		private void UserConfirmCarChoice_Load(object sender, EventArgs e)
		{
			this._apr = ClsDatabase.GetAPRs();
			lblCarModel.Text = _car.Model;
			lblCarPrice.Text = _car.Price.ToString();
			lblCarType.Text = _car.Type;
			lblCarYear.Text = _car.Year.ToString();
			lblComment.Text = _comment;
			DisplayTotalCarCost();
			DisplayApr();
			DisplayCarModificationsLabels();
		}

		private void DisplayApr()
		{
			// No APR
			cboAPR.Items.Add("No installments");
			
			foreach (var apr in _apr)
			{
				if (apr.Id == 0)
				{
					// ignore
				}
				else
				{
					cboAPR.Items.Add(apr.Apr + "% APR for: " + apr.Time + " Months");
				}
			}

			cboAPR.SelectedIndex = 0;
		}

		private void DisplayCarModificationsLabels()
		{
			// Dynamically create labels
			int i = 0;
			Label ref1 = new Label();
			int height1 = 0;
			foreach (var pair in _car.CarConfigurationsChosen)
			{
				// Configuration is selected, show it
				if (pair.Value == true)
				{
					// First loop
					if (i == 0)
					{
						// Name label
						ref1 = new Label()
						{
							Location = new Point(400, 100 + (200 * i)),
							Text = _carConfigurationsAvailable[int.Parse(pair.Key)].Modifications,
							AutoSize = true,
							MaximumSize = new Size(200, 200),
							BackColor = Color.Transparent,
							Name = pair.Key + "1",
						};
						height1 += ref1.Height;
						this.Controls.Add(ref1);
					
						// Price label
						this.Controls.Add(new Label()
						{
							Location = new Point(600, 100 + (ref1.Height * i)),
							Text = Text = _carConfigurationsAvailable[int.Parse(pair.Key)].Price + "£",
							AutoSize = true,
							BackColor = Color.Transparent,
							Name = pair.Key + "2"
						});
					}
					else
					{
						var tmp = new Label()
						{
							Location = new Point(400, 100 + height1),
							Text = _carConfigurationsAvailable[int.Parse(pair.Key)].Modifications,
							AutoSize = true,
							MaximumSize = new Size(200, 200),
							Name = pair.Key + "1",
						};
						this.Controls.Add(tmp);
						
						// Price label
						this.Controls.Add(new Label()
						{
							Location = new Point(600, 100 + height1),
							Text = _carConfigurationsAvailable[int.Parse(pair.Key)].Price + "£",
							AutoSize = true,
							BackColor = Color.Transparent,
							Name = pair.Key + "2"
						});	
						
						height1 += tmp.Height;
					}
				}
				i++;
				
			}
			
		}

		private void btnSubmitReview_Click(object sender, EventArgs e)
		{
			switch (_submittedFromStatus)
			{
				case SubmittedFromStatus.Review:
				{
					const string message = "You've already submitted this form for review";  
					const string title = "Error";  
					MessageBox.Show(message, title);
					break;
				}
				case SubmittedFromStatus.Purchase:
				{
					const string message = "You've already submitted this form for purchase. Do you want to submit it for review instead?";  
					const string title = "Error";  
					MessageBoxButtons buttons = MessageBoxButtons.YesNo;  
					DialogResult result = MessageBox.Show(message, title, buttons);  
					if (result == DialogResult.Yes) {  
						_submittedFromStatus = SubmittedFromStatus.Review;
						ClsDatabase.UpdateUserCarConfiguration(_car, _userId, (int)_submittedFormId, true, false);
					} else {  
						// Do nothing 
					}

					break;
				}
				default:
				{
					_submittedFromStatus = SubmittedFromStatus.Review;
					// Store in db

					_submittedFormId = ClsDatabase.AddUserCarConfiguration(_car, _userId, _comment, _aprSelected, true ,false);
					// TODO: After merging return the user to the car selection menu

					MessageBox.Show("Configuration sent for a review", "Success", MessageBoxButtons.OK);
					break;
				}
			}
		}

		private void btnPurchaseCar_Click(object sender, EventArgs e)
		{
			switch (_submittedFromStatus)
			{
				case SubmittedFromStatus.Purchase:
				{
					const string message = "You've already submitted this form for purchase";  
					const string title = "Error";  
					MessageBox.Show(message, title);
					break;
				}
				case SubmittedFromStatus.Review:
				{
					const string message = "You've already submitted this form for review. Do you want to submit it for purchase instead?";  
					const string title = "Error";  
					MessageBoxButtons buttons = MessageBoxButtons.YesNo;  
					DialogResult result = MessageBox.Show(message, title, buttons);  
					if (result == DialogResult.Yes) {
						_submittedFromStatus = SubmittedFromStatus.Purchase;
						ClsDatabase.UpdateUserCarConfiguration(_car, _userId, (int)_submittedFormId, false, true);
					} else {  
						// Do nothing 
					}

					break;
				}
				default:
				{
					// NOTE: Payments will not be implemented in this iteration
					UserConfirmPayment userConfirmCarChoice = new UserConfirmPayment()
					{
						Location = this.Location,
						Size = new Size(500, 300),
						// Otherwise we can't put the form where we want
						StartPosition = FormStartPosition.Manual
					};

					userConfirmCarChoice.Show();
					_submittedFromStatus = SubmittedFromStatus.Purchase;

					_submittedFormId = ClsDatabase.AddUserCarConfiguration(_car, _userId, _comment, _aprSelected, false, true);
					// TODO: After merging return the user to the car selection menu
					break;
				}
			}
		}
		
		private void DisplayTotalCarCost()
		{
			_totalPrice = 0;
			foreach (var car in _car.CarConfigurationsChosen)
			{
				if (car.Value == true)
				{
					_totalPrice += _carConfigurationsAvailable[int.Parse(car.Key)].Price;
				}
			}

			_totalPrice += _car.Price;

			lblTotalCost.Text ="£" + _totalPrice.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// if it's set we have already submitted the form
			if (_submittedFormId == null)
			{
				// Save config in DB
				_submittedFormId = ClsDatabase.AddUserCarConfiguration(_car, _userId, _comment, _aprSelected, false, false);
				MessageBox.Show("Configuration saves to the cloud", "Success", MessageBoxButtons.OK);
			}
			else
			{
				MessageBox.Show("Form already submitted", "Fail", MessageBoxButtons.OK);
			}
		}

		private void SelectedIndexChanged(object sender, EventArgs e)
		{
			ComboBox cb = (ComboBox) sender;
			if (cb.SelectedItem != null)
			{
				// offset
				_aprSelected = cb.SelectedIndex;
				var a = _apr[_aprSelected];
				// No apr hide labels
				if (cb.SelectedIndex == 0)
				{
					lblPerMonth.Visible = false;
					lblCostPerMonth.Visible = false;
				}
				else
				{
					lblPerMonth.Visible = true;
					lblCostPerMonth.Visible = true;

					float totalCost = _totalPrice;
					int time = int.Parse(_apr[_aprSelected].Time);
					var ccc = totalCost * (float) _apr[_aprSelected].Apr / 100;
					totalCost = (totalCost + ccc) / time;

					lblCostPerMonth.Text = totalCost.ToString();
				}
			}
		}

    private void btnBack_Click(object sender, EventArgs e)
    {
			this.Hide();

			_formRef.Show();
    }
  }
}