using System.ComponentModel;

namespace GroupProject.Forms.User
{
	partial class UserLoadConfiguration
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
			this.dataGridViewUserConfigs = new System.Windows.Forms.DataGridView();
			this.CarModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CarType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CarYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize) (this.dataGridViewUserConfigs)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewUserConfigs
			// 
			this.dataGridViewUserConfigs.AllowUserToAddRows = false;
			this.dataGridViewUserConfigs.AllowUserToDeleteRows = false;
			this.dataGridViewUserConfigs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewUserConfigs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.CarModel, this.CarType, this.CarYear, this.Description});
			this.dataGridViewUserConfigs.Location = new System.Drawing.Point(12, 12);
			this.dataGridViewUserConfigs.Name = "dataGridViewUserConfigs";
			this.dataGridViewUserConfigs.ReadOnly = true;
			this.dataGridViewUserConfigs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewUserConfigs.Size = new System.Drawing.Size(400, 400);
			this.dataGridViewUserConfigs.TabIndex = 0;
			// 
			// CarModel
			// 
			this.CarModel.HeaderText = "Car Model";
			this.CarModel.Name = "CarModel";
			this.CarModel.ReadOnly = true;
			this.CarModel.Width = 60;
			// 
			// CarType
			// 
			this.CarType.HeaderText = "Car Type";
			this.CarType.Name = "CarType";
			this.CarType.ReadOnly = true;
			this.CarType.Width = 60;
			// 
			// CarYear
			// 
			this.CarYear.HeaderText = "Car Year";
			this.CarYear.Name = "CarYear";
			this.CarYear.ReadOnly = true;
			this.CarYear.Width = 50;
			// 
			// Description
			// 
			this.Description.HeaderText = "Description";
			this.Description.Name = "Description";
			this.Description.ReadOnly = true;
			this.Description.Width = 185;
			// 
			// UserLoadConfiguration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridViewUserConfigs);
			this.Name = "UserLoadConfiguration";
			this.Text = "UserLoadConfiguration";
			this.Load += new System.EventHandler(this.UserLoadConfiguration_Load);
			((System.ComponentModel.ISupportInitialize) (this.dataGridViewUserConfigs)).EndInit();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.DataGridViewTextBoxColumn CarModel;
		private System.Windows.Forms.DataGridViewTextBoxColumn CarType;
		private System.Windows.Forms.DataGridViewTextBoxColumn CarYear;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;

		private System.Windows.Forms.DataGridView dataGridViewUserConfigs;

		#endregion
	}
}