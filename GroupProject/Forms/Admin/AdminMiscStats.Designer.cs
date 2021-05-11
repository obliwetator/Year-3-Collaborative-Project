using System.ComponentModel;

namespace GroupProject.Forms.Admin
{
	partial class AdminMiscStats
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
            this.btnHowMuchMoneyMade = new System.Windows.Forms.Button();
            this.btnPotentialMoney = new System.Windows.Forms.Button();
            this.HowManyInvoicesCompleted = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHowMuchMoneyMade
            // 
            this.btnHowMuchMoneyMade.Location = new System.Drawing.Point(12, 163);
            this.btnHowMuchMoneyMade.Name = "btnHowMuchMoneyMade";
            this.btnHowMuchMoneyMade.Size = new System.Drawing.Size(102, 48);
            this.btnHowMuchMoneyMade.TabIndex = 0;
            this.btnHowMuchMoneyMade.Text = "Money from completed invoices";
            this.btnHowMuchMoneyMade.UseVisualStyleBackColor = true;
            // 
            // btnPotentialMoney
            // 
            this.btnPotentialMoney.Location = new System.Drawing.Point(189, 163);
            this.btnPotentialMoney.Name = "btnPotentialMoney";
            this.btnPotentialMoney.Size = new System.Drawing.Size(102, 48);
            this.btnPotentialMoney.TabIndex = 1;
            this.btnPotentialMoney.Text = "Potential money from incomplete invoices";
            this.btnPotentialMoney.UseVisualStyleBackColor = true;
            // 
            // HowManyInvoicesCompleted
            // 
            this.HowManyInvoicesCompleted.Location = new System.Drawing.Point(370, 163);
            this.HowManyInvoicesCompleted.Name = "HowManyInvoicesCompleted";
            this.HowManyInvoicesCompleted.Size = new System.Drawing.Size(102, 48);
            this.HowManyInvoicesCompleted.TabIndex = 2;
            this.HowManyInvoicesCompleted.Text = "How many invoices have been completed";
            this.HowManyInvoicesCompleted.UseVisualStyleBackColor = true;
            this.HowManyInvoicesCompleted.Click += new System.EventHandler(this.HowManyInvoicesCompleted_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 301);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 48);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AdminMiscStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.HowManyInvoicesCompleted);
            this.Controls.Add(this.btnPotentialMoney);
            this.Controls.Add(this.btnHowMuchMoneyMade);
            this.Name = "AdminMiscStats";
            this.Text = "AdminMiscStats";
            this.Load += new System.EventHandler(this.AdminMiscStats_Load);
            this.ResumeLayout(false);

		}

		private System.Windows.Forms.Button btnBack;

		private System.Windows.Forms.Button btnHowMuchMoneyMade;
		private System.Windows.Forms.Button btnPotentialMoney;
		private System.Windows.Forms.Button HowManyInvoicesCompleted;

		#endregion
	}
}