
namespace GroupProject.Forms.Admin
{
    partial class APR
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAPR = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnAPR = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.lblDashbord.TabIndex = 8;
            this.lblDashbord.Text = "Admin Dashbord";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(33, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Set the APR%  here:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(333, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Set Time Frame for APR:";
            // 
            // txtAPR
            // 
            this.txtAPR.Location = new System.Drawing.Point(37, 116);
            this.txtAPR.Margin = new System.Windows.Forms.Padding(2);
            this.txtAPR.Name = "txtAPR";
            this.txtAPR.Size = new System.Drawing.Size(126, 20);
            this.txtAPR.TabIndex = 11;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(347, 116);
            this.txtTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(126, 20);
            this.txtTime.TabIndex = 12;
            // 
            // btnAPR
            // 
            this.btnAPR.Location = new System.Drawing.Point(217, 188);
            this.btnAPR.Margin = new System.Windows.Forms.Padding(2);
            this.btnAPR.Name = "btnAPR";
            this.btnAPR.Size = new System.Drawing.Size(89, 42);
            this.btnAPR.TabIndex = 13;
            this.btnAPR.Text = "APR%";
            this.btnAPR.UseVisualStyleBackColor = true;
            this.btnAPR.Click += new System.EventHandler(this.btnAPR_Click);
            // 
            // APR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnAPR);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtAPR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDashbord);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "APR";
            this.Text = "APR";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblDashbord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAPR;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnAPR;
    }
}