namespace GroupProject
{
    partial class BrowseVehicles
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
            this.cboVehicles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMods = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboVehicles
            // 
            this.cboVehicles.FormattingEnabled = true;
            this.cboVehicles.Location = new System.Drawing.Point(31, 40);
            this.cboVehicles.Name = "cboVehicles";
            this.cboVehicles.Size = new System.Drawing.Size(246, 21);
            this.cboVehicles.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Browse Vehicles";
            // 
            // cboMods
            // 
            this.cboMods.FormattingEnabled = true;
            this.cboMods.Location = new System.Drawing.Point(307, 39);
            this.cboMods.Name = "cboMods";
            this.cboMods.Size = new System.Drawing.Size(254, 21);
            this.cboMods.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Browse Modifications";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(596, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 51);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(596, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 48);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(596, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 51);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // BrowseVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboMods);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboVehicles);
            this.Name = "BrowseVehicles";
            this.Text = "BrowseVehicles";
            this.Load += new System.EventHandler(this.BrowseVehicles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboVehicles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMods;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}