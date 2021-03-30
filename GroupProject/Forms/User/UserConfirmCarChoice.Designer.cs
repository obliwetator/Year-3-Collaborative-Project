using System.ComponentModel;

namespace GroupProject.Forms.User
{
	partial class UserConfirmCarChoice
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

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
			this.btnSave = new System.Windows.Forms.Button();
			this.btnSubmitReview = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblCarModel = new System.Windows.Forms.Label();
			this.lblCarType = new System.Windows.Forms.Label();
			this.lblCarYear = new System.Windows.Forms.Label();
			this.lblCarPrice = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnPurchaseCar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSave.Location = new System.Drawing.Point(13, 421);
			this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(166, 79);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Save Configuration";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnSubmitReview
			// 
			this.btnSubmitReview.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSubmitReview.Location = new System.Drawing.Point(726, 421);
			this.btnSubmitReview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnSubmitReview.Name = "btnSubmitReview";
			this.btnSubmitReview.Size = new System.Drawing.Size(166, 79);
			this.btnSubmitReview.TabIndex = 1;
			this.btnSubmitReview.Text = "Submit for a review";
			this.btnSubmitReview.UseVisualStyleBackColor = true;
			this.btnSubmitReview.Click += new System.EventHandler(this.btnSubmitReview_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(120, 58);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "You\'ve chosen";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(120, 100);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "Car Model";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(120, 124);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 24);
			this.label3.TabIndex = 4;
			this.label3.Text = "Car Type";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(120, 148);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 24);
			this.label4.TabIndex = 5;
			this.label4.Text = "Car Year";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(120, 172);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 24);
			this.label5.TabIndex = 6;
			this.label5.Text = "Car Price";
			// 
			// lblCarModel
			// 
			this.lblCarModel.Location = new System.Drawing.Point(204, 100);
			this.lblCarModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCarModel.Name = "lblCarModel";
			this.lblCarModel.Size = new System.Drawing.Size(76, 24);
			this.lblCarModel.TabIndex = 7;
			this.lblCarModel.Text = "Car Model";
			// 
			// lblCarType
			// 
			this.lblCarType.Location = new System.Drawing.Point(204, 124);
			this.lblCarType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCarType.Name = "lblCarType";
			this.lblCarType.Size = new System.Drawing.Size(76, 24);
			this.lblCarType.TabIndex = 8;
			this.lblCarType.Text = "Car Model";
			// 
			// lblCarYear
			// 
			this.lblCarYear.Location = new System.Drawing.Point(204, 148);
			this.lblCarYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCarYear.Name = "lblCarYear";
			this.lblCarYear.Size = new System.Drawing.Size(76, 24);
			this.lblCarYear.TabIndex = 9;
			this.lblCarYear.Text = "Car Model";
			// 
			// lblCarPrice
			// 
			this.lblCarPrice.Location = new System.Drawing.Point(204, 172);
			this.lblCarPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCarPrice.Name = "lblCarPrice";
			this.lblCarPrice.Size = new System.Drawing.Size(76, 24);
			this.lblCarPrice.TabIndex = 10;
			this.lblCarPrice.Text = "Car Model";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(400, 58);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(160, 24);
			this.label6.TabIndex = 11;
			this.label6.Text = "Modifications chosen";
			// 
			// btnPurchaseCar
			// 
			this.btnPurchaseCar.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPurchaseCar.Location = new System.Drawing.Point(526, 421);
			this.btnPurchaseCar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnPurchaseCar.Name = "btnPurchaseCar";
			this.btnPurchaseCar.Size = new System.Drawing.Size(166, 79);
			this.btnPurchaseCar.TabIndex = 12;
			this.btnPurchaseCar.Text = "Purchase car";
			this.btnPurchaseCar.UseVisualStyleBackColor = true;
			this.btnPurchaseCar.Click += new System.EventHandler(this.btnPurchaseCar_Click);
			// 
			// UserConfirmCarChoice
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(905, 524);
			this.Controls.Add(this.btnPurchaseCar);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lblCarPrice);
			this.Controls.Add(this.lblCarYear);
			this.Controls.Add(this.lblCarType);
			this.Controls.Add(this.lblCarModel);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSubmitReview);
			this.Controls.Add(this.btnSave);
			this.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "UserConfirmCarChoice";
			this.Text = "UserConfirmCarChoice";
			this.Load += new System.EventHandler(this.UserConfirmCarChoice_Load);
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Button btnPurchaseCar;

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblCarModel;
		private System.Windows.Forms.Label lblCarType;
		private System.Windows.Forms.Label lblCarYear;
		private System.Windows.Forms.Label lblCarPrice;
		
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnSubmitReview;

		#endregion
	}
}