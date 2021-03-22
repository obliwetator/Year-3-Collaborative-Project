
namespace GroupProject
{
    partial class AddingCar
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
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
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
            this.lblDashbord.TabIndex = 9;
            this.lblDashbord.Text = "Admin Dashbord";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter the details of a car you want to add to the system.";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(52, 152);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(96, 20);
            this.lblModel.TabIndex = 11;
            this.lblModel.Text = "Model of car";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(56, 175);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(204, 26);
            this.txtModel.TabIndex = 12;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(52, 227);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(90, 20);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "Type of Car";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(56, 250);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(204, 26);
            this.txtType.TabIndex = 14;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(52, 297);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(87, 20);
            this.lblYear.TabIndex = 15;
            this.lblYear.Text = "Year of car";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(56, 320);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(204, 26);
            this.txtYear.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(463, 358);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 53);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add Car";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // AddingCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDashbord);
            this.Name = "AddingCar";
            this.Text = "AddingCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDashbord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnAdd;
    }
}