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
      this.label7 = new System.Windows.Forms.Label();
      this.lblComment = new System.Windows.Forms.Label();
      this.lblTotalCost = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.cboAPR = new System.Windows.Forms.ComboBox();
      this.label9 = new System.Windows.Forms.Label();
      this.lblPerMonth = new System.Windows.Forms.Label();
      this.lblCostPerMonth = new System.Windows.Forms.Label();
      this.btnBack = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnSave
      // 
      this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnSave.Location = new System.Drawing.Point(249, 578);
      this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(166, 79);
      this.btnSave.TabIndex = 0;
      this.btnSave.Text = "Save Configuration locally";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnSubmitReview
      // 
      this.btnSubmitReview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSubmitReview.Location = new System.Drawing.Point(1085, 578);
      this.btnSubmitReview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.btnSubmitReview.Name = "btnSubmitReview";
      this.btnSubmitReview.Size = new System.Drawing.Size(166, 79);
      this.btnSubmitReview.TabIndex = 1;
      this.btnSubmitReview.Text = "Purchase";
      this.btnSubmitReview.UseVisualStyleBackColor = true;
      this.btnSubmitReview.Click += new System.EventHandler(this.btnPurchaseCar_Click);
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
      this.btnPurchaseCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnPurchaseCar.Location = new System.Drawing.Point(885, 578);
      this.btnPurchaseCar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.btnPurchaseCar.Name = "btnPurchaseCar";
      this.btnPurchaseCar.Size = new System.Drawing.Size(166, 79);
      this.btnPurchaseCar.TabIndex = 12;
      this.btnPurchaseCar.Text = "Submit For a Review";
      this.btnPurchaseCar.UseVisualStyleBackColor = true;
      this.btnPurchaseCar.Click += new System.EventHandler(this.btnSubmitReview_Click);
      // 
      // label7
      // 
      this.label7.Location = new System.Drawing.Point(120, 271);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(96, 21);
      this.label7.TabIndex = 13;
      this.label7.Text = "Comment";
      // 
      // lblComment
      // 
      this.lblComment.Location = new System.Drawing.Point(120, 292);
      this.lblComment.Name = "lblComment";
      this.lblComment.Size = new System.Drawing.Size(245, 114);
      this.lblComment.TabIndex = 14;
      // 
      // lblTotalCost
      // 
      this.lblTotalCost.Location = new System.Drawing.Point(808, 79);
      this.lblTotalCost.Name = "lblTotalCost";
      this.lblTotalCost.Size = new System.Drawing.Size(77, 23);
      this.lblTotalCost.TabIndex = 18;
      this.lblTotalCost.Text = "Total Cost";
      // 
      // label8
      // 
      this.label8.Location = new System.Drawing.Point(808, 58);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(64, 21);
      this.label8.TabIndex = 17;
      this.label8.Text = "Total Cost";
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.button1.Location = new System.Drawing.Point(429, 578);
      this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(166, 79);
      this.button1.TabIndex = 19;
      this.button1.Text = "Save Configuration to the cloud";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // cboAPR
      // 
      this.cboAPR.FormattingEnabled = true;
      this.cboAPR.Location = new System.Drawing.Point(808, 151);
      this.cboAPR.Name = "cboAPR";
      this.cboAPR.Size = new System.Drawing.Size(217, 21);
      this.cboAPR.TabIndex = 20;
      this.cboAPR.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
      // 
      // label9
      // 
      this.label9.Location = new System.Drawing.Point(808, 127);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(169, 21);
      this.label9.TabIndex = 21;
      this.label9.Text = "Installement options";
      // 
      // lblPerMonth
      // 
      this.lblPerMonth.Location = new System.Drawing.Point(808, 185);
      this.lblPerMonth.Name = "lblPerMonth";
      this.lblPerMonth.Size = new System.Drawing.Size(145, 23);
      this.lblPerMonth.TabIndex = 22;
      this.lblPerMonth.Text = "Cost Per month";
      this.lblPerMonth.Visible = false;
      // 
      // lblCostPerMonth
      // 
      this.lblCostPerMonth.Location = new System.Drawing.Point(808, 208);
      this.lblCostPerMonth.Name = "lblCostPerMonth";
      this.lblCostPerMonth.Size = new System.Drawing.Size(118, 14);
      this.lblCostPerMonth.TabIndex = 23;
      this.lblCostPerMonth.Text = "label10";
      this.lblCostPerMonth.Visible = false;
      // 
      // btnBack
      // 
      this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnBack.Location = new System.Drawing.Point(13, 578);
      this.btnBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.btnBack.Name = "btnBack";
      this.btnBack.Size = new System.Drawing.Size(166, 79);
      this.btnBack.TabIndex = 24;
      this.btnBack.Text = "Back";
      this.btnBack.UseVisualStyleBackColor = true;
      this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
      // 
      // UserConfirmCarChoice
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1264, 681);
      this.Controls.Add(this.btnBack);
      this.Controls.Add(this.lblCostPerMonth);
      this.Controls.Add(this.lblPerMonth);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.cboAPR);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.lblTotalCost);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.lblComment);
      this.Controls.Add(this.label7);
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
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.Name = "UserConfirmCarChoice";
      this.Text = "UserConfirmCarChoice";
      this.Load += new System.EventHandler(this.UserConfirmCarChoice_Load);
      this.ResumeLayout(false);

		}

		private System.Windows.Forms.Label lblCostPerMonth;
		private System.Windows.Forms.Label lblPerMonth;

		private System.Windows.Forms.Label label9;

		private System.Windows.Forms.ComboBox cboAPR;

		private System.Windows.Forms.Button button1;

		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblTotalCost;

		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblComment;

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

    private System.Windows.Forms.Button btnBack;
  }
}