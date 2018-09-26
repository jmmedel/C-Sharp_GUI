namespace Gaddis_04_04_ColorPicker
{
  partial class frmColorMixer
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.radFirstRed = new System.Windows.Forms.RadioButton();
      this.radFirstBlue = new System.Windows.Forms.RadioButton();
      this.radFirstYellow = new System.Windows.Forms.RadioButton();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.radSecondYellow = new System.Windows.Forms.RadioButton();
      this.radSecondBlue = new System.Windows.Forms.RadioButton();
      this.radSecondRed = new System.Windows.Forms.RadioButton();
      this.btnMix = new System.Windows.Forms.Button();
      this.btnExit = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.radFirstYellow);
      this.groupBox1.Controls.Add(this.radFirstBlue);
      this.groupBox1.Controls.Add(this.radFirstRed);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(120, 141);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Select First Color";
      // 
      // radFirstRed
      // 
      this.radFirstRed.AutoSize = true;
      this.radFirstRed.Location = new System.Drawing.Point(7, 29);
      this.radFirstRed.Name = "radFirstRed";
      this.radFirstRed.Size = new System.Drawing.Size(45, 17);
      this.radFirstRed.TabIndex = 0;
      this.radFirstRed.TabStop = true;
      this.radFirstRed.Text = "Red";
      this.radFirstRed.UseVisualStyleBackColor = true;
      // 
      // radFirstBlue
      // 
      this.radFirstBlue.AutoSize = true;
      this.radFirstBlue.Location = new System.Drawing.Point(7, 69);
      this.radFirstBlue.Name = "radFirstBlue";
      this.radFirstBlue.Size = new System.Drawing.Size(46, 17);
      this.radFirstBlue.TabIndex = 1;
      this.radFirstBlue.TabStop = true;
      this.radFirstBlue.Text = "Blue";
      this.radFirstBlue.UseVisualStyleBackColor = true;
      // 
      // radFirstYellow
      // 
      this.radFirstYellow.AutoSize = true;
      this.radFirstYellow.Location = new System.Drawing.Point(7, 111);
      this.radFirstYellow.Name = "radFirstYellow";
      this.radFirstYellow.Size = new System.Drawing.Size(56, 17);
      this.radFirstYellow.TabIndex = 2;
      this.radFirstYellow.TabStop = true;
      this.radFirstYellow.Text = "Yellow";
      this.radFirstYellow.UseVisualStyleBackColor = true;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.radSecondYellow);
      this.groupBox2.Controls.Add(this.radSecondBlue);
      this.groupBox2.Controls.Add(this.radSecondRed);
      this.groupBox2.Location = new System.Drawing.Point(152, 12);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(120, 141);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Select Second Color";
      // 
      // radSecondYellow
      // 
      this.radSecondYellow.AutoSize = true;
      this.radSecondYellow.Location = new System.Drawing.Point(7, 111);
      this.radSecondYellow.Name = "radSecondYellow";
      this.radSecondYellow.Size = new System.Drawing.Size(56, 17);
      this.radSecondYellow.TabIndex = 2;
      this.radSecondYellow.TabStop = true;
      this.radSecondYellow.Text = "Yellow";
      this.radSecondYellow.UseVisualStyleBackColor = true;
      // 
      // radSecondBlue
      // 
      this.radSecondBlue.AutoSize = true;
      this.radSecondBlue.Location = new System.Drawing.Point(7, 69);
      this.radSecondBlue.Name = "radSecondBlue";
      this.radSecondBlue.Size = new System.Drawing.Size(46, 17);
      this.radSecondBlue.TabIndex = 1;
      this.radSecondBlue.TabStop = true;
      this.radSecondBlue.Text = "Blue";
      this.radSecondBlue.UseVisualStyleBackColor = true;
      // 
      // radSecondRed
      // 
      this.radSecondRed.AutoSize = true;
      this.radSecondRed.Location = new System.Drawing.Point(7, 29);
      this.radSecondRed.Name = "radSecondRed";
      this.radSecondRed.Size = new System.Drawing.Size(45, 17);
      this.radSecondRed.TabIndex = 0;
      this.radSecondRed.TabStop = true;
      this.radSecondRed.Text = "Red";
      this.radSecondRed.UseVisualStyleBackColor = true;
      // 
      // btnMix
      // 
      this.btnMix.Location = new System.Drawing.Point(32, 187);
      this.btnMix.Name = "btnMix";
      this.btnMix.Size = new System.Drawing.Size(75, 23);
      this.btnMix.TabIndex = 2;
      this.btnMix.Text = "Mix";
      this.btnMix.UseVisualStyleBackColor = true;
      this.btnMix.Click += new System.EventHandler(this.btnMix_Click);
      // 
      // btnExit
      // 
      this.btnExit.Location = new System.Drawing.Point(175, 187);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(75, 23);
      this.btnExit.TabIndex = 3;
      this.btnExit.Text = "Exit";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // frmColorMixer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 226);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.btnMix);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "frmColorMixer";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Color Mixer";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton radFirstYellow;
    private System.Windows.Forms.RadioButton radFirstBlue;
    private System.Windows.Forms.RadioButton radFirstRed;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.RadioButton radSecondYellow;
    private System.Windows.Forms.RadioButton radSecondBlue;
    private System.Windows.Forms.RadioButton radSecondRed;
    private System.Windows.Forms.Button btnMix;
    private System.Windows.Forms.Button btnExit;
  }
}

