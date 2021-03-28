using System.ComponentModel;

namespace GroupProject.Forms.Admin
{
	partial class APRUpdate
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
			this.dataGridAPR = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.APR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize) (this.dataGridAPR)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridAPR
			// 
			this.dataGridAPR.AllowUserToAddRows = false;
			this.dataGridAPR.AllowUserToDeleteRows = false;
			this.dataGridAPR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridAPR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.ID, this.APR, this.Time});
			this.dataGridAPR.Location = new System.Drawing.Point(37, 29);
			this.dataGridAPR.Name = "dataGridAPR";
			this.dataGridAPR.ShowCellToolTips = false;
			this.dataGridAPR.Size = new System.Drawing.Size(343, 307);
			this.dataGridAPR.TabIndex = 0;
			this.dataGridAPR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAPR_CellContentClick);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			// 
			// APR
			// 
			this.APR.HeaderText = "APR";
			this.APR.Name = "APR";
			// 
			// Time
			// 
			this.Time.HeaderText = "TIME";
			this.Time.Name = "Time";
			// 
			// APRUpdate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridAPR);
			this.Name = "APRUpdate";
			this.Text = "APRUpdate";
			this.Load += new System.EventHandler(this.APRUpdate_Load);
			((System.ComponentModel.ISupportInitialize) (this.dataGridAPR)).EndInit();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.DataGridViewTextBoxColumn APR;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Time;

		private System.Windows.Forms.DataGridView dataGridAPR;

		#endregion
	}
}