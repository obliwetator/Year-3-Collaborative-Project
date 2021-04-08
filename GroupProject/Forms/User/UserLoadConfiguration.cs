using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using GroupProject.Classes;
using GroupProject.Classes.SerialzationClasses;
using GroupProject.Classes.User;

namespace GroupProject.Forms.User
{
	// TODO: Load this form from the User dashboard
	// TODO: 
	public partial class UserLoadConfiguration : Form
	{
		private readonly int _userId;
		private Tuple<List<ClsUserConfiguration>, List<ClsUserCarConfiguration>> _configs;

		private UserSaveLoadConfig _config;
		// Temporary hardcoded value
		public UserLoadConfiguration(int userId = 1)
		{
			this._userId = userId;
			InitializeComponent();
		}

		private void UserLoadConfiguration_Load(object sender, EventArgs e)
		{
			_configs = ClsDatabase.GetUserCarConfigurations(_userId);
			// Get all unique cars IDs so that we can get the corresponding cars
			int[] uniqueCars = _configs.Item1.Select(x => x.CarId).Distinct().ToArray();
			// Get car objects
			var cars = ClsDatabase.GetCars(uniqueCars);
			// Insert the data into the data view
			foreach (var t in _configs.Item1)
			{
				dataGridViewUserConfigs.Rows.Add(	
					cars[t.CarId].Model,
					cars[t.CarId].Type,
					cars[t.CarId].Year,
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

		private void btnLoadLocal_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog()
			{
				Filter = "JSON File (*.json)|*.json",
				Title = "Load your configuration",
			};

			if (ofd.ShowDialog() != DialogResult.OK) return;
			if (ofd.FileName != "")
			{
				// Open the text file using a stream reader.
				using (var sr = new StreamReader(ofd.FileName))
				{
					// Read the stream as a string, then decode that string as our object
					var a = sr.ReadToEnd();
					_config = JsonSerializer.Deserialize<UserSaveLoadConfig>(a);
				}
				
				// TODO: Add the config to datagridview
			}
		}
	}
}