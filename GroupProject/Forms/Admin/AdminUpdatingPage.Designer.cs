
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
            this.gvUpdate = new System.Windows.Forms.DataGridView();
            this.btnSaveUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdUpdate = new System.Windows.Forms.TextBox();
            this.txtModelUpdate = new System.Windows.Forms.TextBox();
            this.txtTypeUpdate = new System.Windows.Forms.TextBox();
            this.txtYearUpdate = new System.Windows.Forms.TextBox();
            this.txtPriceUpdate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvUpdate)).BeginInit();
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
            // gvUpdate
            // 
            this.gvUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUpdate.Location = new System.Drawing.Point(12, 73);
            this.gvUpdate.Name = "gvUpdate";
            this.gvUpdate.RowHeadersWidth = 62;
            this.gvUpdate.RowTemplate.Height = 28;
            this.gvUpdate.Size = new System.Drawing.Size(347, 204);
            this.gvUpdate.TabIndex = 8;
            // 
            // btnSaveUpdate
            // 
            this.btnSaveUpdate.Location = new System.Drawing.Point(95, 328);
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.Size = new System.Drawing.Size(146, 72);
            this.btnSaveUpdate.TabIndex = 9;
            this.btnSaveUpdate.Text = "Save Update";
            this.btnSaveUpdate.UseVisualStyleBackColor = true;
            this.btnSaveUpdate.Click += new System.EventHandler(this.btnSaveUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID of the car you want to update";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Model of the car you want to update";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(410, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Type of the car you want to update";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(410, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Year of the car you want to update";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(410, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Price of the car you want to update";
            // 
            // txtIdUpdate
            // 
            this.txtIdUpdate.Location = new System.Drawing.Point(415, 101);
            this.txtIdUpdate.Name = "txtIdUpdate";
            this.txtIdUpdate.Size = new System.Drawing.Size(280, 26);
            this.txtIdUpdate.TabIndex = 15;
            // 
            // txtModelUpdate
            // 
            this.txtModelUpdate.Location = new System.Drawing.Point(415, 174);
            this.txtModelUpdate.Name = "txtModelUpdate";
            this.txtModelUpdate.Size = new System.Drawing.Size(280, 26);
            this.txtModelUpdate.TabIndex = 16;
            // 
            // txtTypeUpdate
            // 
            this.txtTypeUpdate.Location = new System.Drawing.Point(415, 254);
            this.txtTypeUpdate.Name = "txtTypeUpdate";
            this.txtTypeUpdate.Size = new System.Drawing.Size(280, 26);
            this.txtTypeUpdate.TabIndex = 17;
            // 
            // txtYearUpdate
            // 
            this.txtYearUpdate.Location = new System.Drawing.Point(415, 328);
            this.txtYearUpdate.Name = "txtYearUpdate";
            this.txtYearUpdate.Size = new System.Drawing.Size(280, 26);
            this.txtYearUpdate.TabIndex = 18;
            // 
            // txtPriceUpdate
            // 
            this.txtPriceUpdate.Location = new System.Drawing.Point(415, 400);
            this.txtPriceUpdate.Name = "txtPriceUpdate";
            this.txtPriceUpdate.Size = new System.Drawing.Size(280, 26);
            this.txtPriceUpdate.TabIndex = 19;
            // 
            // AdminUpdatingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPriceUpdate);
            this.Controls.Add(this.txtYearUpdate);
            this.Controls.Add(this.txtTypeUpdate);
            this.Controls.Add(this.txtModelUpdate);
            this.Controls.Add(this.txtIdUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveUpdate);
            this.Controls.Add(this.gvUpdate);
            this.Controls.Add(this.lblDashbord);
            this.Name = "AdminUpdatingPage";
            this.Text = "AdminUpdatingPage";
            this.Load += new System.EventHandler(this.AdminUpdatingPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDashbord;
        private System.Windows.Forms.DataGridView gvUpdate;
        private System.Windows.Forms.Button btnSaveUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdUpdate;
        private System.Windows.Forms.TextBox txtModelUpdate;
        private System.Windows.Forms.TextBox txtTypeUpdate;
        private System.Windows.Forms.TextBox txtYearUpdate;
        private System.Windows.Forms.TextBox txtPriceUpdate;
    }
}