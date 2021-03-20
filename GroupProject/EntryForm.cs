using GroupProject.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GroupProject
{
  public partial class EntryForm : Form
  {
    
    
    // we will receive the CarId from the previous form
    private void Form1_Load(object sender, EventArgs e)
    {
      ClsDatabase clsDb = new ClsDatabase();
      // Temporary call
      var car = clsDb.GetCar(_carId);

      lblCarId.Text = car.Id.ToString();
      lblModel.Text = car.Model;
      lblType.Text = car.Type;
      lblYear.Text = car.Year.ToString();

      // clsDb.GetUserCarConfigurations();
      var carConfigurationsAvailable = clsDb.CarConfigurationsAvailable(_carId);
      var carConfigurationCheckBoxes = new List<CheckBox>();
      for (int i = 0; i < carConfigurationsAvailable.Count; i++)
      {
        carConfigurationCheckBoxes.Add(new CheckBox()
        {
          Location = new Point(200, 50 + (20 * i)),
          Text = carConfigurationsAvailable[i].Modifications,
        });

        this.Controls.Add(carConfigurationCheckBoxes[i]);
      }
      
    }

    // Temporary value
    private readonly int _carId;

    public EntryForm(int carId = 1)
    {
      InitializeComponent();
      this._carId = carId;
    }
  }
}
