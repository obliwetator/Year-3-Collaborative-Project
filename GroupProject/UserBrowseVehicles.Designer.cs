
namespace GroupProject
{
    partial class UserBrowseVehicles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.cboVehicles = new System.Windows.Forms.ComboBox();
            this.lblBrowseVehicles = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboVehicles
            // 
            this.cboVehicles.FormattingEnabled = true;
            this.cboVehicles.Location = new System.Drawing.Point(147, 58);
            this.cboVehicles.Name = "cboVehicles";
            this.cboVehicles.Size = new System.Drawing.Size(365, 21);
            this.cboVehicles.TabIndex = 0;
            this.cboVehicles.SelectedIndexChanged += new System.EventHandler(this.cboVehicles_SelectedIndexChanged);
            // 
            // lblBrowseVehicles
            // 
            this.lblBrowseVehicles.AutoSize = true;
            this.lblBrowseVehicles.Location = new System.Drawing.Point(261, 42);
            this.lblBrowseVehicles.Name = "lblBrowseVehicles";
            this.lblBrowseVehicles.Size = new System.Drawing.Size(119, 13);
            this.lblBrowseVehicles.TabIndex = 1;
            this.lblBrowseVehicles.Text = "AVAILABLE VEHICLES\r\n";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(629, 380);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(120, 43);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select Car";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(29, 400);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "<Go Back";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // UserBrowseVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblBrowseVehicles);
            this.Controls.Add(this.cboVehicles);
            this.Name = "UserBrowseVehicles";
            this.Text = "UserBrowseVehicles";
            this.Load += new System.EventHandler(this.UserBrowseVehicles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboVehicles;
        private System.Windows.Forms.Label lblBrowseVehicles;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnReturn;
    }
}