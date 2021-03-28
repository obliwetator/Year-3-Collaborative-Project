using System;
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
		// To avoid duplicate/multiple form submission
		private bool _submittedForm;
		private enum SubmittedFromStatus
		{
			None,
			Purchase,
			Review,
		}

		private SubmittedFromStatus _submittedFromStatus = SubmittedFromStatus.None;
		
		private readonly ClsCar _car;
		private readonly int _userId;

		public UserConfirmCarChoice(ClsCar car, int userId)
		{
			this._car = car;
			this._userId = userId;
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// Save config in DB
			ClsDatabase.AddUserCarConfiguration(_car, _userId, false, false);
			
			// Displays a SaveFileDialog so the user can save the Configuration
			// assigned to btnSave.
			SaveFileDialog sfd = new SaveFileDialog
			{
				Filter = "JSON File|*.json",
				Title = "Save an Image File"
			};

			// to JSON
			string carJson = JsonSerializer.Serialize(_car);

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
			foreach (var pair in _car.CarConfigurationsChosen)
			{
				// Configuration is selected, show it
				if (pair.Value == true)
				{
					// Name label
					this.Controls.Add(new Label()
					{
						Location = new Point(400, 100 + (20 * i)),
						// TODO: Display name instead of the ID
						Text = pair.Key,
						AutoSize = true,
					});
					
					// Price label
					this.Controls.Add(new Label()
					{
						Location = new Point(440, 100 + (20 * i)),
						// TODO: Display price instead of the ID
						Text = pair.Key + "£",
						AutoSize = true,
					});
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
					const string message = "You've already submitted this form for purchase. Do you want to submit it for purchase instead?";  
					const string title = "Error";  
					MessageBoxButtons buttons = MessageBoxButtons.YesNo;  
					DialogResult result = MessageBox.Show(message, title, buttons);  
					if (result == DialogResult.Yes) {  
						// TODO: Update config 
					} else {  
						// Do nothing 
					}

					break;
				}
				default:
				{
					_submittedFromStatus = SubmittedFromStatus.Review;
					// Store in db

					ClsDatabase.AddUserCarConfiguration(_car, _userId, true ,false);
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
					const string message = "You've already submitted this form for review. Do you want to submit it for review instead?";  
					const string title = "Error";  
					MessageBoxButtons buttons = MessageBoxButtons.YesNo;  
					DialogResult result = MessageBox.Show(message, title, buttons);  
					if (result == DialogResult.Yes) {  
						// TODO: Update config 
					} else {  
						// Do nothing 
					}

					break;
				}
				default:
				{
					_submittedFromStatus = SubmittedFromStatus.Purchase;

					ClsDatabase.AddUserCarConfiguration(_car, _userId, false, true);
					break;
				}
			}
		}
	}
}