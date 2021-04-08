using System;
using System.Windows.Forms;

namespace GroupProject.Forms.User
{
	public partial class UserConfirmPayment : Form
	{
		public UserConfirmPayment()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// Here we would process the card details. However this is currently outside the scope of this project
			MessageBox.Show("Payment accepted", "Success");
		}
	}
}