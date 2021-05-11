using System;
using System.Drawing;
using System.Windows.Forms;
using GroupProject.Classes;

namespace GroupProject.Forms.Salesman
{
  public partial class SalesmanDashboard : Form
  {
    private readonly int _salesmanId;
    Form _formRef;
    public SalesmanDashboard(Form formRef, int salesmanId = 4)
    {
      this._salesmanId = clsUser.ID1;
      this._formRef = formRef;
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

    private void btnBack_Click(object sender, EventArgs e)
    {
      _formRef.Show();

      this.Close();


    }
  }
}
