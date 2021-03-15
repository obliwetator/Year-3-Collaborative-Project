using GroupProject.Classes;
using System;
using System.Windows.Forms;

namespace GroupProject
{
  public partial class EntryForm : Form
  {
    // we will receive the CarId from the previous form
    // Temporary value
    private readonly int _carId;
    public EntryForm(int carId = 1)
    {
      InitializeComponent();
      this._carId = carId;
    }


    private void Form1_Load(object sender, EventArgs e)
    {
      clsDatabase clsDb = new clsDatabase();
      // Temporary call
      var car = clsDb.GetCar(_carId);

      lblCarId.Text = car.Id.ToString();
      lblModel.Text = car.Model;
      lblType.Text = car.Type;
      lblYear.Text = car.Year.ToString();
      
      // clsDb.GetUserCarConfigurations();
    }
  }
}
