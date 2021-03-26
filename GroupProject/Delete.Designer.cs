
namespace GroupProject
{
    partial class Delete
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDashbord = new System.Windows.Forms.Label();
            this.cboDelete = new System.Windows.Forms.ComboBox();
            this.lblCarID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the car ID of the one you want to delete";
            // 
            // lblDashbord
            // 
            this.lblDashbord.AutoSize = true;
            this.lblDashbord.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashbord.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDashbord.Location = new System.Drawing.Point(200, 0);
            this.lblDashbord.Name = "lblDashbord";
            this.lblDashbord.Size = new System.Drawing.Size(398, 57);
            this.lblDashbord.TabIndex = 9;
            this.lblDashbord.Text = "Admin Dashbord";
            // 
            // cboDelete
            // 
            this.cboDelete.FormattingEnabled = true;
            this.cboDelete.Location = new System.Drawing.Point(118, 166);
            this.cboDelete.Name = "cboDelete";
            this.cboDelete.Size = new System.Drawing.Size(211, 28);
            this.cboDelete.TabIndex = 10;
            this.cboDelete.SelectedIndexChanged += new System.EventHandler(this.cboDelete_SelectedIndexChanged);
            // 
            // lblCarID
            // 
            this.lblCarID.AutoSize = true;
            this.lblCarID.Location = new System.Drawing.Point(147, 235);
            this.lblCarID.Name = "lblCarID";
            this.lblCarID.Size = new System.Drawing.Size(51, 20);
            this.lblCarID.TabIndex = 11;
            this.lblCarID.Text = "label2";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(549, 284);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 52);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblCarID);
            this.Controls.Add(this.cboDelete);
            this.Controls.Add(this.lblDashbord);
            this.Controls.Add(this.label1);
            this.Name = "Delete";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDashbord;
        private System.Windows.Forms.ComboBox cboDelete;
        private System.Windows.Forms.Label lblCarID;
        private System.Windows.Forms.Button btnDelete;
    }
}