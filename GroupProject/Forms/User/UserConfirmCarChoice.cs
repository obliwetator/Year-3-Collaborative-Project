using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using GroupProject.Classes.Car;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GroupProject.Forms.User
{
	public partial class UserConfirmCarChoice : Form
	{
		private ClsCar _car;

		public UserConfirmCarChoice(ClsCar car)
		{
			this._car = car;
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
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

		private void btnPurchase_Click(object sender, EventArgs e)
		{
			throw new System.NotImplementedException();
		}
	}
}