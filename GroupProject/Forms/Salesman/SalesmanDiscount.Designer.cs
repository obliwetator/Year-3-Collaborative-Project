using System.ComponentModel;

namespace GroupProject.Forms.Salesman
{
	partial class SalesmanDiscount
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(228, 82);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(114, 49);
			this.button1.TabIndex = 1;
			this.button1.Text = "Select Discount";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// SalesmanDiscount
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 261);
			this.Controls.Add(this.button1);
			this.Name = "SalesmanDiscount";
			this.Text = "SalesmanDiscount";
			this.Load += new System.EventHandler(this.SalesmanDiscount_Load);
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Button button1;

		#endregion
	}
}