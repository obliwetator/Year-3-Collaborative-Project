
namespace GroupProject.Forms.Admin
{
    partial class AdminDashbord
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSetApr = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblDashbord = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnDelete.Location = new System.Drawing.Point(390, 130);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 46);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Click here to delete a car";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnInsert.Location = new System.Drawing.Point(270, 130);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(113, 46);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Click here to add a car to the system";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnUpdate.Location = new System.Drawing.Point(150, 130);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 46);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Click here to update database";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSetApr
            // 
            this.btnSetApr.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSetApr.Location = new System.Drawing.Point(30, 130);
            this.btnSetApr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSetApr.Name = "btnSetApr";
            this.btnSetApr.Size = new System.Drawing.Size(113, 46);
            this.btnSetApr.TabIndex = 8;
            this.btnSetApr.Text = "Click here to create a new APR%";
            this.btnSetApr.UseVisualStyleBackColor = true;
            this.btnSetApr.Click += new System.EventHandler(this.btnSetApr_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsername.Location = new System.Drawing.Point(27, 52);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(45, 16);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "label1";
            // 
            // lblDashbord
            // 
            this.lblDashbord.AutoSize = true;
            this.lblDashbord.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDashbord.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDashbord.Location = new System.Drawing.Point(133, 0);
            this.lblDashbord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDashbord.Name = "lblDashbord";
            this.lblDashbord.Size = new System.Drawing.Size(264, 39);
            this.lblDashbord.TabIndex = 6;
            this.lblDashbord.Text = "Admin Dashbord";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.Location = new System.Drawing.Point(30, 199);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "Click here to update an exisiting APR%";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminDashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSetApr);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblDashbord);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminDashbord";
            this.Text = "AdminDashbord";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSetApr;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblDashbord;
    }
}