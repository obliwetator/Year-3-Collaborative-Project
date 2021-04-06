﻿using GroupProject.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GroupProject.Classes.Car;
using GroupProject.Forms.User;

namespace GroupProject
{
  public partial class EntryForm : Form
  {

    private ClsCar _car;
    private Dictionary<int, CarCustomizationAvailable> _carConfigurationsAvailable;
    
    // we will receive the CarId from the previous form
    private void Form1_Load(object sender, EventArgs e)
    {
      // Temporary call
      _car = ClsDatabase.GetCar(_carId);

      lblCarId.Text = _car.Id.ToString();
      lblModel.Text = _car.Model;
      lblType.Text = _car.Type;
      lblYear.Text = _car.Year.ToString();
      lblPrice.Text = _car.Price.ToString() + "£";

      // clsDb.GetUserCarConfigurations();
      _carConfigurationsAvailable = ClsDatabase.GetCarConfigurationsAvailable(_carId);
      var carConfigurationCheckBoxes = new List<CheckBox>();
      int i = 0;
      foreach (var car in _carConfigurationsAvailable)
      {
        // Create the checkboxes and store them in an array if we need them in the future
        carConfigurationCheckBoxes.Add(new CheckBox()
        {
          Location = new Point(200, 50 + (20 * i)),
          Text = car.Value.Modifications + $"    {car.Value.Price}£",
          Name = car.Value.Id.ToString(),
          AutoSize = true
        });
        // Set the default configuration as NOT chosen
        _car.CarConfigurationsChosen.Add(car.Value.Id.ToString(), false);
        // Add an event listener
        carConfigurationCheckBoxes[i].CheckedChanged += DynamicCheckBoxCheckedChanged;
        // Add the checkboxes to the form
        this.Controls.Add(carConfigurationCheckBoxes[i]);
        i++;
      }
    }

    private void DynamicCheckBoxCheckedChanged(object sender, EventArgs e)
    {
      // Cast to correct type
      CheckBox cb = (CheckBox) sender;
      // Flip the bool
      _car.CarConfigurationsChosen[cb.Name] = !_car.CarConfigurationsChosen[cb.Name];
    }

    // Temporary value
    private readonly int _carId;
    private readonly int _userId;
    public EntryForm(int carId = 1, int userId = 1)
    {
      InitializeComponent();
      this._carId = carId;
      this._userId = userId;
    }

    private void btnContinue_Click(object sender, EventArgs e)
    {
      this.Hide();
      Form userConfirmCarChoice = new UserConfirmCarChoice(_car, _userId, _carConfigurationsAvailable)
      {
        Location = this.Location,
        Size = this.Size,
        // Otherwise we can't put the form where we want
        StartPosition = FormStartPosition.Manual
      };

      userConfirmCarChoice.Show();
    }
  }
}
