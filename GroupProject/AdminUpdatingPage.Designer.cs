
namespace GroupProject
{
    partial class AdminUpdatingPage
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
            this.lblDashbord = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnSetApr = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDashbord
            // 
            this.lblDashbord.AutoSize = true;
            this.lblDashbord.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashbord.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDashbord.Location = new System.Drawing.Point(200, 0);
            this.lblDashbord.Name = "lblDashbord";
            this.lblDashbord.Size = new System.Drawing.Size(398, 57);
            this.lblDashbord.TabIndex = 0;
            this.lblDashbord.Text = "Admin Dashbord";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsername.Location = new System.Drawing.Point(40, 80);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(62, 23);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "label1";
            // 
            // btnSetApr
            // 
            this.btnSetApr.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetApr.Location = new System.Drawing.Point(30, 200);
            this.btnSetApr.Name = "btnSetApr";
            this.btnSetApr.Size = new System.Drawing.Size(170, 70);
            this.btnSetApr.TabIndex = 2;
            this.btnSetApr.Text = "Click here to set APR%";
            this.btnSetApr.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(210, 200);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(170, 70);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Click here to update database";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(390, 200);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(170, 70);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Click here to add a car to the system";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(570, 200);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 70);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Click here to delete a car";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // AdminUpdatingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSetApr);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblDashbord);
            this.Name = "AdminUpdatingPage";
            this.Text = "AdminUpdatingPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDashbord;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnSetApr;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
    }
}