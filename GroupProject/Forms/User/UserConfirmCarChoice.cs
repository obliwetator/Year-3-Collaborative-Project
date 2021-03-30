using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using GroupProject.Classes.Car;
using System.Text.Json;
using GroupProject.Classes;

namespace GroupProject.Forms.User
{
	public partial class UserConfirmCarChoice : Form
	{
		private ulong _submittedFormId;
		private enum SubmittedFromStatus
		{
			None,
			Purchase,
			Review,
		}

		private SubmittedFromStatus _submittedFromStatus = SubmittedFromStatus.None;
		
		private readonly ClsCar _car;
		private readonly int _userId;
		private Dictionary<int, CarCustomizationAvailable> _carConfigurationsAvailable;

		public UserConfirmCarChoice(ClsCar car, int userId, Dictionary<int, CarCustomizationAvailable> carConfigurationsAvailable)
		{
			this._car = car;
			this._userId = userId;
			this._carConfigurationsAvailable = carConfigurationsAvailable;
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// Save config in DB
			// TODO: User might not be aware that saving locally also saves to the DB. Create a separate button for that
			_submittedFormId = ClsDatabase.AddUserCarConfiguration(_car, _userId, false, false);
			
			// Displays a SaveFileDialog so the user can save the Configuration
			// assigned to btnSave.
			SaveFileDialog sfd = new SaveFileDialog
			{
				Filter = "JSON File|*.json",
				Title = "Save your configuration"
			};

			// to JSON
			string carJson = JsonSerializer.Serialize(_car);
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
			lblCarModel.Text = _car.Model;
			lblCarPrice.Text = _car.Price.ToString();
			lblCarType.Text = _car.Type;
			lblCarYear.Text = _car.Year.ToString();
			
			DisplayCarModificationsLabels();
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
						Label tmp;

						tmp = new Label()
						{
							Location = new Point(400, 100 + height1 + ref1.Size.Height),
							Text = _carConfigurationsAvailable[int.Parse(pair.Key)].Modifications,
							AutoSize = true,
							MaximumSize = new Size(200, 200),
							Name = pair.Key + "1",
						};
						this.Controls.Add(tmp);
						
						// Price label
						this.Controls.Add(new Label()
						{
							Location = new Point(600, 100 + height1 + ref1.Size.Height),
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

					_submittedFormId = ClsDatabase.AddUserCarConfiguration(_car, _userId, true ,false);
					// Once user click the button a message will show up telling them they've completed their order
					// TODO: After merging return the user to the car selection menu
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
					_submittedFromStatus = SubmittedFromStatus.Purchase;

					_submittedFormId = ClsDatabase.AddUserCarConfiguration(_car, _userId, false, true);
					break;
				}
			}
		}
	}
}