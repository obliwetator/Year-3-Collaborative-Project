using System;
using System.Drawing;
using System.Windows.Forms;
using GroupProject.Classes;
using GroupProject.Classes.Salesman;

namespace GroupProject.Forms.Salesman
{
	// Car review will always lead to ViewInvoice
	// It's a way for the salesman to provide feedback to the user
	public partial class SalesmanViewReview : Form
	{
		public SalesmanViewReview()
		{
			InitializeComponent();
		}

		private void SalesmanViewReview_Load(object sender, EventArgs e)
		{
			var CarsForReview = ClsDatabase.GetUsersConfigForReview();

			for (int i = 0; i < CarsForReview.Count; i++)
			{
				// ID label
				panel1.Controls.Add(new Label()
				{
					Text = CarsForReview[i].Id.ToString(),
					Location = new Point(lblId.Location.X, 30 + (i * 50)),
					AutoSize = true
				});
				// Description label
				panel1.Controls.Add(new Label()
				{
					Text = CarsForReview[i].Description + "d;glfkjfgdjlk;sdsfgjk;lgsdfjkl;sgdfjl;kgsdfjlk;sgfdjgskfl;dsgfdjd;ljd;jlkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkd;jlkgfdsk;ljg;lfdjdldjgf;lkjl;kgfdjlk;gfdkjd",
					Location = new Point(lblDescription.Location.X, 30 + (i * 50)),
					AutoSize = true,
					MaximumSize = new Size(110,100),
				});
				
				panel1.Controls.Add(new Label()
				{
					Text = CarsForReview[i].Description + "d;glfkjfgdjlk;sdsfgjk;lgsdfjkl;sgdfjl;kgsdfjlk;sgfdjgskfl;dsgfdjd;ljd;jlkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkd;jlkgfdsk;ljg;lfdjdldjgf;lkjl;kgfdjlk;gfdkjd",
					Location = new Point(lblModel.Location.X, 30 + (i * 50)),
					AutoSize = true,
					MaximumSize = new Size(130,100),
				});
				
			}
		}
	}
}