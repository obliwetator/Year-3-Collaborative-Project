
namespace GroupProject.Forms.Admin
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
            this.label1.Location = new System.Drawing.Point(8, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the car ID of the one you want to delete";
            // 
            // lblDashbord
            // 
            this.lblDashbord.AutoSize = true;
            this.lblDashbord.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashbord.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDashbord.Location = new System.Drawing.Point(133, 0);
            this.lblDashbord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDashbord.Name = "lblDashbord";
            this.lblDashbord.Size = new System.Drawing.Size(264, 39);
            this.lblDashbord.TabIndex = 9;
            this.lblDashbord.Text = "Admin Dashbord";
            // 
            // cboDelete
            // 
            this.cboDelete.FormattingEnabled = true;
            this.cboDelete.Location = new System.Drawing.Point(79, 108);
            this.cboDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboDelete.Name = "cboDelete";
            this.cboDelete.Size = new System.Drawing.Size(142, 21);
            this.cboDelete.TabIndex = 10;
            this.cboDelete.SelectedIndexChanged += new System.EventHandler(this.cboDelete_SelectedIndexChanged);
            // 
            // lblCarID
            // 
            this.lblCarID.AutoSize = true;
            this.lblCarID.Location = new System.Drawing.Point(98, 153);
            this.lblCarID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarID.Name = "lblCarID";
            this.lblCarID.Size = new System.Drawing.Size(35, 13);
            this.lblCarID.TabIndex = 11;
            this.lblCarID.Text = "label2";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(366, 185);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 34);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblCarID);
            this.Controls.Add(this.cboDelete);
            this.Controls.Add(this.lblDashbord);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Delete";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Delete_Load);
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