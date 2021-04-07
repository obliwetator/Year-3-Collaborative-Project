using System.ComponentModel;

namespace GroupProject.Forms.User
{
	partial class UserConfirmPayment
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
			this.txtCardNumber = new System.Windows.Forms.TextBox();
			this.txtSortCode = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtCardNumber
			// 
			this.txtCardNumber.Location = new System.Drawing.Point(59, 75);
			this.txtCardNumber.Name = "txtCardNumber";
			this.txtCardNumber.Size = new System.Drawing.Size(176, 20);
			this.txtCardNumber.TabIndex = 0;
			// 
			// txtSortCode
			// 
			this.txtSortCode.Location = new System.Drawing.Point(59, 123);
			this.txtSortCode.Name = "txtSortCode";
			this.txtSortCode.Size = new System.Drawing.Size(100, 20);
			this.txtSortCode.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(59, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Card Number";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(59, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Sort code";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(379, 209);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(93, 40);
			this.button1.TabIndex = 4;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// UserConfirmPayment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 261);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtSortCode);
			this.Controls.Add(this.txtCardNumber);
			this.Name = "UserConfirmPayment";
			this.Text = "UserConfirmPayment";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCardNumber;
		private System.Windows.Forms.TextBox txtSortCode;

		#endregion
	}
}