using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using GroupProject.Classes;
using GroupProject.Classes.Car;
using GroupProject.Classes.SerialzationClasses;
using GroupProject.Classes.User;

namespace GroupProject.Forms.User
{
	public partial class UserLoadConfiguration : Form
	{
		private readonly int _userId;
		private Tuple<List<ClsUserConfiguration>, List<ClsUserCarConfiguration>> _configs;
		private Dictionary<int, ClsCar> _cars;
		private Form _formRef;
		private UserSaveLoadConfig _config;
		// Temporary hardcoded value
		public UserLoadConfiguration(Form formRef, int userId = 1)
		{
			this._userId = userId;
			this._formRef = formRef;
			InitializeComponent();
		}

		private void UserLoadConfiguration_Load(object sender, EventArgs e)
		{
			_configs = ClsDatabase.GetUserCarConfigurations(_userId);
			// Get all unique cars IDs so that we can get the corresponding cars
			int[] uniqueCars = _configs.Item1.Select(x => x.CarId).Distinct().ToArray();
			// Get car objects
			_cars = ClsDatabase.GetCars(uniqueCars);
			// Insert the data into the data view
			foreach (var t in _configs.Item1)
			{
				dataGridViewUserConfigs.Rows.Add(	
					_cars[t.CarId].Model,
					_cars[t.CarId].Type,
					_cars[t.CarId].Year,
					t.Description
				);
			}
			// The description column will wrap (can be quite long) and fit to display everything
			dataGridViewUserConfigs.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			dataGridViewUserConfigs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			
			// We will display the current saves values and allowed the user to press "next" to finalize the edits
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			var tableIndex = dataGridViewUserConfigs.SelectedRows[0].Index;
			var configId = _configs.Item1[tableIndex].Id;
			
			// Always 0 only 1 row can be selected
		 	ClsDatabase.DeleteUserConfiguration(configId);
		    // Remove the row
		    dataGridViewUserConfigs.Rows.RemoveAt(tableIndex);

			MessageBox.Show("Configuration successully deleted", "Success");
		}
		

		private void btnNext_Click(object sender, EventArgs e)
		{
			var tableIndex = dataGridViewUserConfigs.SelectedRows[0].Index;
			var configId = _configs.Item1[tableIndex].Id;
			var car = _cars[_configs.Item1[tableIndex].CarId];
			string description = (string)dataGridViewUserConfigs.Rows[tableIndex].Cells[3].Value;
			
			AddModsToCar();
			this.Hide();
			Form userConfirmCarChoice = new UserConfirmCarChoice(car, _userId, description, this)
			{
				Location = this.Location,
				Size = this.Size,
				// Otherwise we can't put the form where we want
				StartPosition = FormStartPosition.Manual
			};
			
			userConfirmCarChoice.Show();

			void AddModsToCar()
			{
				// Adds mods to cars class
				foreach (var configuration in _configs.Item2)
				{
					if (configuration.ConfigurationId == configId)
					{
						car.CarConfigurationsChosen.Add(configuration.Modification.ToString(), true);
					}
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