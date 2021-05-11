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
            this.lblUpdate = new System.Windows.Forms.Label();
            this.txtUpdateID = new System.Windows.Forms.TextBox();
            this.lblAPRUpdate = new System.Windows.Forms.Label();
            this.txtAPRUpdate = new System.Windows.Forms.TextBox();
            this.lblTimeUpdate = new System.Windows.Forms.Label();
            this.txtTimeUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAPR)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAPR
            // 
            this.dataGridAPR.AllowUserToAddRows = false;
            this.dataGridAPR.AllowUserToDeleteRows = false;
            this.dataGridAPR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAPR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.APR,
            this.Time});
            this.dataGridAPR.Location = new System.Drawing.Point(37, 29);
            this.dataGridAPR.Name = "dataGridAPR";
            this.dataGridAPR.RowHeadersWidth = 62;
            this.dataGridAPR.ShowCellToolTips = false;
            this.dataGridAPR.Size = new System.Drawing.Size(343, 307);
            this.dataGridAPR.TabIndex = 0;
            this.dataGridAPR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAPR_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 150;
            // 
            // APR
            // 
            this.APR.HeaderText = "APR";
            this.APR.MinimumWidth = 8;
            this.APR.Name = "APR";
            this.APR.Width = 150;
            // 
            // Time
            // 
            this.Time.HeaderText = "TIME";
            this.Time.MinimumWidth = 8;
            this.Time.Name = "Time";
            this.Time.Width = 150;
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(465, 67);
            this.lblUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(149, 13);
            this.lblUpdate.TabIndex = 1;
            this.lblUpdate.Text = "ID of APR you want to update";
            // 
            // txtUpdateID
            // 
            this.txtUpdateID.Location = new System.Drawing.Point(468, 90);
            this.txtUpdateID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUpdateID.Name = "txtUpdateID";
            this.txtUpdateID.Size = new System.Drawing.Size(68, 20);
            this.txtUpdateID.TabIndex = 2;
            // 
            // lblAPRUpdate
            // 
            this.lblAPRUpdate.AutoSize = true;
            this.lblAPRUpdate.Location = new System.Drawing.Point(465, 139);
            this.lblAPRUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAPRUpdate.Name = "lblAPRUpdate";
            this.lblAPRUpdate.Size = new System.Drawing.Size(185, 13);
            this.lblAPRUpdate.TabIndex = 3;
            this.lblAPRUpdate.Text = "What do you want to update APR to?";
            // 
            // txtAPRUpdate
            // 
            this.txtAPRUpdate.Location = new System.Drawing.Point(468, 167);
            this.txtAPRUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAPRUpdate.Name = "txtAPRUpdate";
            this.txtAPRUpdate.Size = new System.Drawing.Size(68, 20);
            this.txtAPRUpdate.TabIndex = 4;
            // 
            // lblTimeUpdate
            // 
            this.lblTimeUpdate.AutoSize = true;
            this.lblTimeUpdate.Location = new System.Drawing.Point(465, 214);
            this.lblTimeUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeUpdate.Name = "lblTimeUpdate";
            this.lblTimeUpdate.Size = new System.Drawing.Size(229, 13);
            this.lblTimeUpdate.TabIndex = 5;
            this.lblTimeUpdate.Text = "What do you want to update the time frame to?";
            // 
            // txtTimeUpdate
            // 
            this.txtTimeUpdate.Location = new System.Drawing.Point(468, 241);
            this.txtTimeUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimeUpdate.Name = "txtTimeUpdate";
            this.txtTimeUpdate.Size = new System.Drawing.Size(68, 20);
            this.txtTimeUpdate.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(461, 292);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(67, 36);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(690, 390);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 37);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // APRUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtTimeUpdate);
            this.Controls.Add(this.lblTimeUpdate);
            this.Controls.Add(this.txtAPRUpdate);
            this.Controls.Add(this.lblAPRUpdate);
            this.Controls.Add(this.txtUpdateID);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.dataGridAPR);
            this.Name = "APRUpdate";
            this.Text = "APRUpdate";
            this.Load += new System.EventHandler(this.APRUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAPR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private System.Windows.Forms.DataGridViewTextBoxColumn APR;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Time;

		private System.Windows.Forms.DataGridView dataGridAPR;

        #endregion

        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.TextBox txtUpdateID;
        private System.Windows.Forms.Label lblAPRUpdate;
        private System.Windows.Forms.TextBox txtAPRUpdate;
        private System.Windows.Forms.Label lblTimeUpdate;
        private System.Windows.Forms.TextBox txtTimeUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
    }
}