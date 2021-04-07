using System.ComponentModel;

namespace GroupProject.Forms.Salesman
{
	partial class SalesmanViewInvoice
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ModelType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CarType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label3 = new System.Windows.Forms.Label();
			this.btnApprove = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.lblUserComment = new System.Windows.Forms.Label();
			this.btnDiscount = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblTotalCost = new System.Windows.Forms.Label();
			this.lblNothing = new System.Windows.Forms.Label();
			this.btnBack = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.ID, this.UserId, this.Description, this.ModelType, this.CarType});
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(454, 453);
			this.dataGridView1.TabIndex = 1;
			// 
			// ID
			// 
			this.ID.HeaderText = "Config ID";
			this.ID.MaxInputLength = 200;
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Width = 60;
			// 
			// UserId
			// 
			this.UserId.HeaderText = "User ID";
			this.UserId.Name = "UserId";
			this.UserId.ReadOnly = true;
			this.UserId.Width = 50;
			// 
			// Description
			// 
			this.Description.HeaderText = "Description";
			this.Description.MaxInputLength = 60000;
			this.Description.Name = "Description";
			this.Description.ReadOnly = true;
			this.Description.Width = 180;
			// 
			// ModelType
			// 
			this.ModelType.HeaderText = "Car Model";
			this.ModelType.Name = "ModelType";
			this.ModelType.ReadOnly = true;
			this.ModelType.Width = 80;
			// 
			// CarType
			// 
			this.CarType.HeaderText = "Car Type";
			this.CarType.Name = "CarType";
			this.CarType.ReadOnly = true;
			this.CarType.Width = 80;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(502, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(152, 21);
			this.label3.TabIndex = 8;
			this.label3.Text = "User selected modifications";
			// 
			// btnApprove
			// 
			this.btnApprove.Location = new System.Drawing.Point(1095, 614);
			this.btnApprove.Name = "btnApprove";
			this.btnApprove.Size = new System.Drawing.Size(157, 55);
			this.btnApprove.TabIndex = 9;
			this.btnApprove.Text = "Approve Purchase\r\n";
			this.btnApprove.UseVisualStyleBackColor = true;
			this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 468);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 22);
			this.label2.TabIndex = 10;
			this.label2.Text = "User Comment";
			// 
			// lblUserComment
			// 
			this.lblUserComment.Location = new System.Drawing.Point(12, 490);
			this.lblUserComment.Name = "lblUserComment";
			this.lblUserComment.Size = new System.Drawing.Size(454, 118);
			this.lblUserComment.TabIndex = 11;
			// 
			// btnDiscount
			// 
			this.btnDiscount.Location = new System.Drawing.Point(913, 614);
			this.btnDiscount.Name = "btnDiscount";
			this.btnDiscount.Size = new System.Drawing.Size(157, 55);
			this.btnDiscount.TabIndex = 12;
			this.btnDiscount.Text = "Apply Discount";
			this.btnDiscount.UseVisualStyleBackColor = true;
			this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(1111, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 21);
			this.label1.TabIndex = 13;
			this.label1.Text = "Total Cost";
			// 
			// lblTotalCost
			// 
			this.lblTotalCost.Location = new System.Drawing.Point(1111, 33);
			this.lblTotalCost.Name = "lblTotalCost";
			this.lblTotalCost.Size = new System.Drawing.Size(77, 23);
			this.lblTotalCost.TabIndex = 14;
			// 
			// lblNothing
			// 
			this.lblNothing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.lblNothing.Location = new System.Drawing.Point(543, 266);
			this.lblNothing.Name = "lblNothing";
			this.lblNothing.Size = new System.Drawing.Size(245, 44);
			this.lblNothing.TabIndex = 15;
			this.lblNothing.Text = "No cars left to approve";
			this.lblNothing.Visible = false;
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(12, 614);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(157, 55);
			this.btnBack.TabIndex = 19;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// SalesmanViewInvoice
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 681);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.lblNothing);
			this.Controls.Add(this.lblTotalCost);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnDiscount);
			this.Controls.Add(this.lblUserComment);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnApprove);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dataGridView1);
			this.Name = "SalesmanViewInvoice";
			this.Text = "SalesmanViewInvoice";
			this.Load += new System.EventHandler(this.SalesmanViewInvoice_Load);
			((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Button btnBack;

		private System.Windows.Forms.Label lblNothing;

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblTotalCost;

		private System.Windows.Forms.Button btnDiscount;

		private System.Windows.Forms.Label lblUserComment;

		private System.Windows.Forms.Label label2;

		private System.Windows.Forms.Button btnApprove;

		private System.Windows.Forms.Label label3;

		private System.Windows.Forms.DataGridViewTextBoxColumn CarType;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ModelType;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserId;

		#endregion
	}
}