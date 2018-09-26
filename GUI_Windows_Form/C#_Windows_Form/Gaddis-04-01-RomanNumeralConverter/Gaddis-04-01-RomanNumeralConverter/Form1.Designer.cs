namespace Gaddis_04_01_RomanNumeralConverter
{
  partial class frmRomanNumeralConverter
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
      this.btnConvertToRomanNumeral = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtNumber = new System.Windows.Forms.TextBox();
      this.lblRomanNumeral = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnConvertToRomanNumeral
      // 
      this.btnConvertToRomanNumeral.Location = new System.Drawing.Point(122, 66);
      this.btnConvertToRomanNumeral.Name = "btnConvertToRomanNumeral";
      this.btnConvertToRomanNumeral.Size = new System.Drawing.Size(100, 37);
      this.btnConvertToRomanNumeral.TabIndex = 1;
      this.btnConvertToRomanNumeral.Text = "Convert To Roman Numeral";
      this.btnConvertToRomanNumeral.UseVisualStyleBackColor = true;
      this.btnConvertToRomanNumeral.Click += new System.EventHandler(this.btnConvertToRomanNumeral_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(43, 32);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(72, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Enter Number";
      // 
      // txtNumber
      // 
      this.txtNumber.Location = new System.Drawing.Point(122, 29);
      this.txtNumber.Name = "txtNumber";
      this.txtNumber.Size = new System.Drawing.Size(100, 20);
      this.txtNumber.TabIndex = 0;
      // 
      // lblRomanNumeral
      // 
      this.lblRomanNumeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblRomanNumeral.Location = new System.Drawing.Point(46, 123);
      this.lblRomanNumeral.Name = "lblRomanNumeral";
      this.lblRomanNumeral.Size = new System.Drawing.Size(176, 61);
      this.lblRomanNumeral.TabIndex = 3;
      this.lblRomanNumeral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // frmRomanNumeralConverter
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(282, 193);
      this.Controls.Add(this.lblRomanNumeral);
      this.Controls.Add(this.txtNumber);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnConvertToRomanNumeral);
      this.Name = "frmRomanNumeralConverter";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Roman Numeral Converter";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnConvertToRomanNumeral;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtNumber;
    private System.Windows.Forms.Label lblRomanNumeral;
  }
}

