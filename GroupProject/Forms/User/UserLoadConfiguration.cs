using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GroupProject.Classes;
using GroupProject.Classes.User;

namespace GroupProject.Forms.User
{
	// TODO: Load this form from the User dashboard
	public partial class UserLoadConfiguration : Form
	{
		private readonly int _userId;
		// Temporary hardcoded value
		public UserLoadConfiguration(int userId = 1)
		{
			this._userId = userId;
			InitializeComponent();
		}

		private void UserLoadConfiguration_Load(object sender, EventArgs e)
		{
			ClsDatabase database = new ClsDatabase();
			var configs = database.GetUserCarConfigurations(_userId);
			// Get all unique cars IDs so that we can get the corresponding cars
			int[] uniqueCars = configs.Item1.Select(x => x.CarId).Distinct().ToArray();
			// Get car objects
			var cars = database.GetCars(uniqueCars);
			// Insert the data into the data view
			foreach (var t in configs.Item1)
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
			
			// TODO: Do something with the selection. Definitely load. Maybe edit?
		}
	}
}