
namespace GroupProject.Forms.Admin
{
    partial class AdminUpdatingForm
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
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtIdUpdate = new System.Windows.Forms.TextBox();
            this.txtModelUpdate = new System.Windows.Forms.TextBox();
            this.txtTypeUpdate = new System.Windows.Forms.TextBox();
            this.txtYearUpdate = new System.Windows.Forms.TextBox();
            this.txtPriceUpdate = new System.Windows.Forms.TextBox();
            this.gvCar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvCar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Dashbord";
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.Location = new System.Drawing.Point(454, 77);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(253, 25);
            this.lblUpdate.TabIndex = 1;
            this.lblUpdate.Text = "ID of car you want to update";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(456, 151);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(198, 25);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Updated Model of car";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(456, 225);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(189, 25);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Updated Type of car";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(456, 288);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(185, 25);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Updated Year of car";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(456, 362);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(188, 25);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Updated Price of car";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(145, 348);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 70);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update Car";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtIdUpdate
            // 
            this.txtIdUpdate.Location = new System.Drawing.Point(461, 105);
            this.txtIdUpdate.Name = "txtIdUpdate";
            this.txtIdUpdate.Size = new System.Drawing.Size(168, 26);
            this.txtIdUpdate.TabIndex = 7;
            // 
            // txtModelUpdate
            // 
            this.txtModelUpdate.Location = new System.Drawing.Point(461, 179);
            this.txtModelUpdate.Name = "txtModelUpdate";
            this.txtModelUpdate.Size = new System.Drawing.Size(222, 26);
            this.txtModelUpdate.TabIndex = 8;
            // 
            // txtTypeUpdate
            // 
            this.txtTypeUpdate.Location = new System.Drawing.Point(461, 255);
            this.txtTypeUpdate.Name = "txtTypeUpdate";
            this.txtTypeUpdate.Size = new System.Drawing.Size(222, 26);
            this.txtTypeUpdate.TabIndex = 9;
            // 
            // txtYearUpdate
            // 
            this.txtYearUpdate.Location = new System.Drawing.Point(461, 316);
            this.txtYearUpdate.Name = "txtYearUpdate";
            this.txtYearUpdate.Size = new System.Drawing.Size(222, 26);
            this.txtYearUpdate.TabIndex = 10;
            // 
            // txtPriceUpdate
            // 
            this.txtPriceUpdate.Location = new System.Drawing.Point(461, 392);
            this.txtPriceUpdate.Name = "txtPriceUpdate";
            this.txtPriceUpdate.Size = new System.Drawing.Size(222, 26);
            this.txtPriceUpdate.TabIndex = 11;
            // 
            // gvCar
            // 
            this.gvCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCar.Location = new System.Drawing.Point(23, 77);
            this.gvCar.Name = "gvCar";
            this.gvCar.RowHeadersWidth = 62;
            this.gvCar.RowTemplate.Height = 28;
            this.gvCar.Size = new System.Drawing.Size(379, 236);
            this.gvCar.TabIndex = 12;
            this.gvCar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCar_CellContentClick);
            // 
            // AdminUpdatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gvCar);
            this.Controls.Add(this.txtPriceUpdate);
            this.Controls.Add(this.txtYearUpdate);
            this.Controls.Add(this.txtTypeUpdate);
            this.Controls.Add(this.txtModelUpdate);
            this.Controls.Add(this.txtIdUpdate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.label1);
            this.Name = "AdminUpdatingForm";
            this.Text = "AdminUpdatingForm";
            ((System.ComponentModel.ISupportInitialize)(this.gvCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtIdUpdate;
        private System.Windows.Forms.TextBox txtModelUpdate;
        private System.Windows.Forms.TextBox txtTypeUpdate;
        private System.Windows.Forms.TextBox txtYearUpdate;
        private System.Windows.Forms.TextBox txtPriceUpdate;
        private System.Windows.Forms.DataGridView gvCar;
    }
}