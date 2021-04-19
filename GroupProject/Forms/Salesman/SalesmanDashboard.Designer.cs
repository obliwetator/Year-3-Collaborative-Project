
namespace GroupProject.Forms.Salesman
{
  partial class SalesmanDashboard
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
      this.btnReview = new System.Windows.Forms.Button();
      this.btnInvoice = new System.Windows.Forms.Button();
      this.btnBack = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnReview
      // 
      this.btnReview.Location = new System.Drawing.Point(503, 146);
      this.btnReview.Name = "btnReview";
      this.btnReview.Size = new System.Drawing.Size(140, 87);
      this.btnReview.TabIndex = 0;
      this.btnReview.Text = "View Reviews";
      this.btnReview.UseVisualStyleBackColor = true;
      this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
      // 
      // btnInvoice
      // 
      this.btnInvoice.Location = new System.Drawing.Point(93, 146);
      this.btnInvoice.Name = "btnInvoice";
      this.btnInvoice.Size = new System.Drawing.Size(140, 87);
      this.btnInvoice.TabIndex = 1;
      this.btnInvoice.Text = "View Invoices";
      this.btnInvoice.UseVisualStyleBackColor = true;
      this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
      // 
      // btnBack
      // 
      this.btnBack.Location = new System.Drawing.Point(12, 386);
      this.btnBack.Name = "btnBack";
      this.btnBack.Size = new System.Drawing.Size(114, 52);
      this.btnBack.TabIndex = 2;
      this.btnBack.Text = "Back";
      this.btnBack.UseVisualStyleBackColor = true;
      this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
      // 
      // SalesmanDashboard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnBack);
      this.Controls.Add(this.btnInvoice);
      this.Controls.Add(this.btnReview);
      this.Name = "SalesmanDashboard";
      this.Text = "SalesemanDashboard";
      this.ResumeLayout(false);

    }

    private System.Windows.Forms.Button btnInvoice;
    private System.Windows.Forms.Button btnReview;

    #endregion

    private System.Windows.Forms.Button btnBack;
  }
}