
namespace GroupProject
{
  partial class EntryForm
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
      this.lblCarId = new System.Windows.Forms.Label();
      this.lblModel = new System.Windows.Forms.Label();
      this.lblType = new System.Windows.Forms.Label();
      this.lblYear = new System.Windows.Forms.Label();
      this.btnContinue = new System.Windows.Forms.Button();
      this.lblPrice = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblCarId
      // 
      this.lblCarId.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.lblCarId.Location = new System.Drawing.Point(70, 58);
      this.lblCarId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblCarId.Name = "lblCarId";
      this.lblCarId.Size = new System.Drawing.Size(117, 25);
      this.lblCarId.TabIndex = 0;
      this.lblCarId.Text = "Car ID";
      // 
      // lblModel
      // 
      this.lblModel.Location = new System.Drawing.Point(70, 83);
      this.lblModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblModel.Name = "lblModel";
      this.lblModel.Size = new System.Drawing.Size(117, 25);
      this.lblModel.TabIndex = 1;
      this.lblModel.Text = "Model";
      // 
      // lblType
      // 
      this.lblType.Location = new System.Drawing.Point(70, 108);
      this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblType.Name = "lblType";
      this.lblType.Size = new System.Drawing.Size(117, 25);
      this.lblType.TabIndex = 2;
      this.lblType.Text = "Type";
      // 
      // lblYear
      // 
      this.lblYear.Location = new System.Drawing.Point(70, 132);
      this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblYear.Name = "lblYear";
      this.lblYear.Size = new System.Drawing.Size(117, 25);
      this.lblYear.TabIndex = 3;
      this.lblYear.Text = "Year";
      // 
      // btnContinue
      // 
      this.btnContinue.Location = new System.Drawing.Point(672, 386);
      this.btnContinue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.btnContinue.Name = "btnContinue";
      this.btnContinue.Size = new System.Drawing.Size(110, 50);
      this.btnContinue.TabIndex = 4;
      this.btnContinue.Text = "Continue";
      this.btnContinue.UseVisualStyleBackColor = true;
      this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
      // 
      // lblPrice
      // 
      this.lblPrice.Location = new System.Drawing.Point(70, 157);
      this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblPrice.Name = "lblPrice";
      this.lblPrice.Size = new System.Drawing.Size(117, 25);
      this.lblPrice.TabIndex = 5;
      this.lblPrice.Text = "Price";
      // 
      // EntryForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(933, 485);
      this.Controls.Add(this.lblPrice);
      this.Controls.Add(this.btnContinue);
      this.Controls.Add(this.lblYear);
      this.Controls.Add(this.lblType);
      this.Controls.Add(this.lblModel);
      this.Controls.Add(this.lblCarId);
      this.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.Name = "EntryForm";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Label lblPrice;

    private System.Windows.Forms.Button btnContinue;

    private System.Windows.Forms.Label lblType;
    private System.Windows.Forms.Label lblYear;

    private System.Windows.Forms.Label lblModel;
    private System.Windows.Forms.Label lblCarId;

    #endregion
  }
}

