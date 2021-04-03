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
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ModelType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CarType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.ID, this.UserId, this.Description, this.ModelType, this.CarType});
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(454, 453);
			this.dataGridView1.TabIndex = 0;
			// 
			// ID
			// 
			this.ID.HeaderText = "Config ID";
			this.ID.MaxInputLength = 200;
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Width = 60;
			// 
			// UserId
			// 
			this.UserId.HeaderText = "User ID";
			this.UserId.Name = "UserId";
			this.UserId.ReadOnly = true;
			this.UserId.Width = 50;
			// 
			// Description
			// 
			this.Description.HeaderText = "Description";
			this.Description.MaxInputLength = 60000;
			this.Description.Name = "Description";
			this.Description.ReadOnly = true;
			this.Description.Width = 180;
			// 
			// ModelType
			// 
			this.ModelType.HeaderText = "Car Model";
			this.ModelType.Name = "ModelType";
			this.ModelType.ReadOnly = true;
			this.ModelType.Width = 80;
			// 
			// CarType
			// 
			this.CarType.HeaderText = "Car Type";
			this.CarType.Name = "CarType";
			this.CarType.ReadOnly = true;
			this.CarType.Width = 80;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(543, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// SalesmanViewReview
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1264, 681);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "SalesmanViewReview";
			this.Text = "SalesmanViewReview";
			this.Load += new System.EventHandler(this.SalesmanViewReview_Load);
			((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Label label1;

		private System.Windows.Forms.DataGridViewTextBoxColumn CarType;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ModelType;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserId;

		private System.Windows.Forms.DataGridView dataGridView1;

		#endregion
	}
}