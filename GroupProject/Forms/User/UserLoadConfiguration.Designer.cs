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
			this.btnBack = new System.Windows.Forms.Button();
			this.btnLoadLocal = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
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
			this.dataGridViewUserConfigs.MultiSelect = false;
			this.dataGridViewUserConfigs.Name = "dataGridViewUserConfigs";
			this.dataGridViewUserConfigs.ReadOnly = true;
			this.dataGridViewUserConfigs.RowHeadersVisible = false;
			this.dataGridViewUserConfigs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewUserConfigs.Size = new System.Drawing.Size(430, 443);
			this.dataGridViewUserConfigs.TabIndex = 0;
			// 
			// CarModel
			// 
			this.CarModel.HeaderText = "Car Model";
			this.CarModel.Name = "CarModel";
			this.CarModel.ReadOnly = true;
			this.CarModel.Width = 80;
			// 
			// CarType
			// 
			this.CarType.HeaderText = "Car Type";
			this.CarType.Name = "CarType";
			this.CarType.ReadOnly = true;
			this.CarType.Width = 80;
			// 
			// CarYear
			// 
			this.CarYear.HeaderText = "Car Year";
			this.CarYear.Name = "CarYear";
			this.CarYear.ReadOnly = true;
			this.CarYear.Width = 80;
			// 
			// Description
			// 
			this.Description.HeaderText = "Description";
			this.Description.Name = "Description";
			this.Description.ReadOnly = true;
			this.Description.Width = 185;
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(12, 707);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(122, 62);
			this.btnBack.TabIndex = 1;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			// 
			// btnLoadLocal
			// 
			this.btnLoadLocal.Location = new System.Drawing.Point(174, 707);
			this.btnLoadLocal.Name = "btnLoadLocal";
			this.btnLoadLocal.Size = new System.Drawing.Size(122, 62);
			this.btnLoadLocal.TabIndex = 2;
			this.btnLoadLocal.Text = "Load Local Configuration";
			this.btnLoadLocal.UseVisualStyleBackColor = true;
			this.btnLoadLocal.Click += new System.EventHandler(this.btnLoadLocal_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(341, 707);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(122, 62);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "Delete Selected Configuration";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(1130, 707);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(122, 62);
			this.btnNext.TabIndex = 4;
			this.btnNext.Text = "Next";
			this.btnNext.UseVisualStyleBackColor = true;
			// 
			// UserLoadConfiguration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 781);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnLoadLocal);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.dataGridViewUserConfigs);
			this.Name = "UserLoadConfiguration";
			this.Text = "UserLoadConfiguration";
			this.Load += new System.EventHandler(this.UserLoadConfiguration_Load);
			((System.ComponentModel.ISupportInitialize) (this.dataGridViewUserConfigs)).EndInit();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnNext;

		private System.Windows.Forms.DataGridViewTextBoxColumn CarModel;
		private System.Windows.Forms.DataGridViewTextBoxColumn CarType;
		private System.Windows.Forms.DataGridViewTextBoxColumn CarYear;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;

		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnLoadLocal;

		private System.Windows.Forms.DataGridView dataGridViewUserConfigs;

		#endregion
	}
}