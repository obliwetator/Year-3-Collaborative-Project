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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ConfigId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.carId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.ConfigId, this.Description, this.carId});
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(344, 411);
			this.dataGridView1.TabIndex = 0;
			// 
			// ConfigId
			// 
			this.ConfigId.HeaderText = "Config ID";
			this.ConfigId.Name = "ConfigId";
			// 
			// Description
			// 
			this.Description.HeaderText = "Description";
			this.Description.Name = "Description";
			// 
			// carId
			// 
			this.carId.HeaderText = "Car Id";
			this.carId.Name = "carId";
			// 
			// SalesmanViewReview
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Name = "SalesmanViewReview";
			this.Text = "SalesmanViewReview";
			this.Load += new System.EventHandler(this.SalesmanViewReview_Load);
			((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.DataGridViewTextBoxColumn carId;
		private System.Windows.Forms.DataGridViewTextBoxColumn ConfigId;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;

		private System.Windows.Forms.DataGridView dataGridView1;

		#endregion
	}
}