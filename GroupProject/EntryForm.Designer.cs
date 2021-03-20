
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
      this.SuspendLayout();
      // 
      // lblCarId
      // 
      this.lblCarId.Location = new System.Drawing.Point(60, 54);
      this.lblCarId.Name = "lblCarId";
      this.lblCarId.Size = new System.Drawing.Size(100, 23);
      this.lblCarId.TabIndex = 0;
      this.lblCarId.Text = "Car ID";
      // 
      // lblModel
      // 
      this.lblModel.Location = new System.Drawing.Point(60, 77);
      this.lblModel.Name = "lblModel";
      this.lblModel.Size = new System.Drawing.Size(100, 23);
      this.lblModel.TabIndex = 1;
      this.lblModel.Text = "Model";
      // 
      // lblType
      // 
      this.lblType.Location = new System.Drawing.Point(60, 100);
      this.lblType.Name = "lblType";
      this.lblType.Size = new System.Drawing.Size(100, 23);
      this.lblType.TabIndex = 2;
      this.lblType.Text = "Type";
      // 
      // lblYear
      // 
      this.lblYear.Location = new System.Drawing.Point(60, 123);
      this.lblYear.Name = "lblYear";
      this.lblYear.Size = new System.Drawing.Size(100, 23);
      this.lblYear.TabIndex = 3;
      this.lblYear.Text = "Year";
      // 
      // btnContinue
      // 
      this.btnContinue.Location = new System.Drawing.Point(576, 358);
      this.btnContinue.Name = "btnContinue";
      this.btnContinue.Size = new System.Drawing.Size(94, 46);
      this.btnContinue.TabIndex = 4;
      this.btnContinue.Text = "Continue";
      this.btnContinue.UseVisualStyleBackColor = true;
      this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
      // 
      // EntryForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnContinue);
      this.Controls.Add(this.lblYear);
      this.Controls.Add(this.lblType);
      this.Controls.Add(this.lblModel);
      this.Controls.Add(this.lblCarId);
      this.Name = "EntryForm";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnContinue;

    private System.Windows.Forms.Label lblType;
    private System.Windows.Forms.Label lblYear;

    private System.Windows.Forms.Label lblModel;
    private System.Windows.Forms.Label lblCarId;

    #endregion
  }
}

