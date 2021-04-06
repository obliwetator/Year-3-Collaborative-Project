using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GroupProject.Classes;
using GroupProject.Classes.Salesman;

namespace GroupProject.Forms.Salesman
{
	public partial class SalesmanDiscount : Form
	{
		private readonly ComboBox CbDiscount = new ComboBox()
		{
			Location = new Point(100, 90)
		};
		// The selected discount will be read by the main form
		public ClsDiscount Discount { get; private set; } = new ClsDiscount();
		
		private List<ClsDiscount> _discounts;
		public SalesmanDiscount()
		{
			InitializeComponent();
			CbDiscount.SelectedIndexChanged += OnSelectionChanged;
			this.Controls.Add(CbDiscount);
		}

		private void SalesmanDiscount_Load(object sender, EventArgs e)
		{
			_discounts = ClsDatabase.GetAllDiscounts();
			
			for (int i = 0; i < _discounts.Count; i++)
			{
				if (i == 0)
				{
					CbDiscount.Items.Add(_discounts[i].DiscountAmmount.ToString() + " (No discount)");
				}
				else
				{
					CbDiscount.Items.Add(_discounts[i].DiscountAmmount.ToString() + (_discounts[i].Type == "flat" ? "£" : "%"));
				}
			}

			CbDiscount.SelectedIndex = 0;
		}
		
		private void OnSelectionChanged(object sender, EventArgs e)
		{
			ComboBox cb = (ComboBox) sender;
			if (CbDiscount.SelectedItem != null)
			{
				var index = CbDiscount.SelectedIndex;
				// we skip the first index offset by +1
				var result = _discounts[index];
				Discount = result;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}