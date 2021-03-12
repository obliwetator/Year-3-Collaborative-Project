using GroupProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
  public partial class EntryForm : Form
  {
    public EntryForm()
    {
      InitializeComponent();
    }


    private void Form1_Load(object sender, EventArgs e)
    {
      clsDatabase clsDB = new clsDatabase();

      clsDB.GetUserCarConfigurations();
    }
  }
}
