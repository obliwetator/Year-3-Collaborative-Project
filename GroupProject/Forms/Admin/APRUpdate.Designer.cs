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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAPRDelete = new System.Windows.Forms.TextBox();
            this.BtnAprDelete = new System.Windows.Forms.Button();
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
            this.dataGridAPR.Location = new System.Drawing.Point(56, 45);
            this.dataGridAPR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridAPR.Name = "dataGridAPR";
            this.dataGridAPR.RowHeadersWidth = 62;
            this.dataGridAPR.ShowCellToolTips = false;
            this.dataGridAPR.Size = new System.Drawing.Size(514, 472);
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
            this.lblUpdate.Location = new System.Drawing.Point(697, 34);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(220, 20);
            this.lblUpdate.TabIndex = 1;
            this.lblUpdate.Text = "ID of APR you want to update";
            // 
            // txtUpdateID
            // 
            this.txtUpdateID.Location = new System.Drawing.Point(701, 69);
            this.txtUpdateID.Name = "txtUpdateID";
            this.txtUpdateID.Size = new System.Drawing.Size(100, 26);
            this.txtUpdateID.TabIndex = 2;
            // 
            // lblAPRUpdate
            // 
            this.lblAPRUpdate.AutoSize = true;
            this.lblAPRUpdate.Location = new System.Drawing.Point(697, 145);
            this.lblAPRUpdate.Name = "lblAPRUpdate";
            this.lblAPRUpdate.Size = new System.Drawing.Size(272, 20);
            this.lblAPRUpdate.TabIndex = 3;
            this.lblAPRUpdate.Text = "What do you want to update APR to?";
            // 
            // txtAPRUpdate
            // 
            this.txtAPRUpdate.Location = new System.Drawing.Point(701, 188);
            this.txtAPRUpdate.Name = "txtAPRUpdate";
            this.txtAPRUpdate.Size = new System.Drawing.Size(100, 26);
            this.txtAPRUpdate.TabIndex = 4;
            // 
            // lblTimeUpdate
            // 
            this.lblTimeUpdate.AutoSize = true;
            this.lblTimeUpdate.Location = new System.Drawing.Point(697, 260);
            this.lblTimeUpdate.Name = "lblTimeUpdate";
            this.lblTimeUpdate.Size = new System.Drawing.Size(341, 20);
            this.lblTimeUpdate.TabIndex = 5;
            this.lblTimeUpdate.Text = "What do you want to update the time frame to?";
            // 
            // txtTimeUpdate
            // 
            this.txtTimeUpdate.Location = new System.Drawing.Point(701, 302);
            this.txtTimeUpdate.Name = "txtTimeUpdate";
            this.txtTimeUpdate.Size = new System.Drawing.Size(100, 26);
            this.txtTimeUpdate.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(691, 380);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 55);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 555);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter ID of APR ypu want to delete";
            // 
            // txtAPRDelete
            // 
            this.txtAPRDelete.Location = new System.Drawing.Point(56, 598);
            this.txtAPRDelete.Name = "txtAPRDelete";
            this.txtAPRDelete.Size = new System.Drawing.Size(173, 26);
            this.txtAPRDelete.TabIndex = 9;
            // 
            // BtnAprDelete
            // 
            this.BtnAprDelete.Location = new System.Drawing.Point(346, 567);
            this.BtnAprDelete.Name = "BtnAprDelete";
            this.BtnAprDelete.Size = new System.Drawing.Size(110, 57);
            this.BtnAprDelete.TabIndex = 10;
            this.BtnAprDelete.Text = "Delete";
            this.BtnAprDelete.UseVisualStyleBackColor = true;
            this.BtnAprDelete.Click += new System.EventHandler(this.BtnAprDelete_Click);
            // 
            // APRUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.BtnAprDelete);
            this.Controls.Add(this.txtAPRDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtTimeUpdate);
            this.Controls.Add(this.lblTimeUpdate);
            this.Controls.Add(this.txtAPRUpdate);
            this.Controls.Add(this.lblAPRUpdate);
            this.Controls.Add(this.txtUpdateID);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.dataGridAPR);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAPRDelete;
        private System.Windows.Forms.Button BtnAprDelete;
    }
}