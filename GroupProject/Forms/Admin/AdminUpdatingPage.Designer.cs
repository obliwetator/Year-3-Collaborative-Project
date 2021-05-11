
namespace GroupProject.Forms.Admin
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gvCar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvCar)).BeginInit();
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
            this.lblDashbord.TabIndex = 7;
            this.lblDashbord.Text = "Admin Dashbord";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 387);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 51);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(114, 296);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 52);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update Car";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // gvCar
            // 
            this.gvCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCar.Location = new System.Drawing.Point(33, 75);
            this.gvCar.Name = "gvCar";
            this.gvCar.RowHeadersWidth = 62;
            this.gvCar.RowTemplate.Height = 28;
            this.gvCar.Size = new System.Drawing.Size(288, 200);
            this.gvCar.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID of car you want to update ";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(369, 109);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(200, 26);
            this.txtID.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Model you want to update the car to";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(369, 175);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(200, 26);
            this.txtModel.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Type you want to update the car to";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(369, 249);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(200, 26);
            this.txtType.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Year you want to update the car to";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(369, 322);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(200, 26);
            this.txtYear.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Price you want to update the car to";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(369, 399);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 26);
            this.txtPrice.TabIndex = 20;
            // 
            // AdminUpdatingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvCar);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblDashbord);
            this.Name = "AdminUpdatingPage";
            this.Text = "AdminUpdatingPage";
            ((System.ComponentModel.ISupportInitialize)(this.gvCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDashbord;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView gvCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice;
    }
}