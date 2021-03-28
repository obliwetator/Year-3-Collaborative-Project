using System.ComponentModel;

namespace GroupProject.Forms.Salesman
{
	partial class SalesmanViewReview
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblType = new System.Windows.Forms.Label();
			this.lblModel = new System.Windows.Forms.Label();
			this.lblDescription = new System.Windows.Forms.Label();
			this.lblId = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.AutoSize = true;
			this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel1.Controls.Add(this.lblType);
			this.panel1.Controls.Add(this.lblModel);
			this.panel1.Controls.Add(this.lblDescription);
			this.panel1.Controls.Add(this.lblId);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.MaximumSize = new System.Drawing.Size(400, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(400, 681);
			this.panel1.TabIndex = 0;
			// 
			// lblType
			// 
			this.lblType.AutoSize = true;
			this.lblType.Location = new System.Drawing.Point(240, 9);
			this.lblType.Margin = new System.Windows.Forms.Padding(0);
			this.lblType.Name = "lblType";
			this.lblType.Size = new System.Drawing.Size(50, 13);
			this.lblType.TabIndex = 3;
			this.lblType.Text = "Car Type";
			// 
			// lblModel
			// 
			this.lblModel.AutoSize = true;
			this.lblModel.Location = new System.Drawing.Point(157, 9);
			this.lblModel.Margin = new System.Windows.Forms.Padding(0);
			this.lblModel.Name = "lblModel";
			this.lblModel.Size = new System.Drawing.Size(55, 13);
			this.lblModel.TabIndex = 2;
			this.lblModel.Text = "Car Model";
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(39, 9);
			this.lblDescription.Margin = new System.Windows.Forms.Padding(0);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(60, 13);
			this.lblDescription.TabIndex = 1;
			this.lblDescription.Text = "Description";
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Location = new System.Drawing.Point(3, 9);
			this.lblId.Margin = new System.Windows.Forms.Padding(0);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(18, 13);
			this.lblId.TabIndex = 0;
			this.lblId.Text = "ID";
			// 
			// SalesmanViewReview
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1264, 681);
			this.Controls.Add(this.panel1);
			this.Name = "SalesmanViewReview";
			this.Text = "SalesmanViewReview";
			this.Load += new System.EventHandler(this.SalesmanViewReview_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.Label lblModel;
		private System.Windows.Forms.Label lblType;

		private System.Windows.Forms.Label lblDescription;

		private System.Windows.Forms.Label lblId;

		private System.Windows.Forms.Panel panel1;

		#endregion
	}
}