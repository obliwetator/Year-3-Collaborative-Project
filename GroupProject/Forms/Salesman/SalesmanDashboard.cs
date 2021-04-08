using System;
using System.Drawing;
using System.Windows.Forms;

namespace GroupProject.Forms.Salesman
{
  public partial class SalesmanDashboard : Form
  {
    // TODO: Pass salesman id
    private int _salesmanId;
    public SalesmanDashboard(int salesmanId = 4)
    {
      this._salesmanId = salesmanId;
      InitializeComponent();
    }
    
    private void btnInvoice_Click(object sender, EventArgs e)
    {
      this.Hide();
      SalesmanViewInvoice userConfirmCarChoice = new SalesmanViewInvoice(_salesmanId, this)
      {
        Location = this.Location,
        Size = new Size(1280, 720),
        // Otherwise we can't put the form where we want
        StartPosition = FormStartPosition.Manual
      };

      userConfirmCarChoice.Show();
    }

    private void btnReview_Click(object sender, EventArgs e)
    {
      this.Hide();
      SalesmanViewReview userConfirmCarChoice = new SalesmanViewReview(_salesmanId, this)
      {
        Location = this.Location,
        Size = new Size(1280, 720),
        // Otherwise we can't put the form where we want
        StartPosition = FormStartPosition.Manual
      };

      userConfirmCarChoice.Show();
    }
  }
}
