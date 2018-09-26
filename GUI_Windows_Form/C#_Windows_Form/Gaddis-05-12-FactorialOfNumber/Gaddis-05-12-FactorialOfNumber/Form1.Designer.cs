namespace Gaddis_05_12_FactorialOfNumber
{
  partial class frmFactorial
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
      this.label1 = new System.Windows.Forms.Label();
      this.txtNumber = new System.Windows.Forms.TextBox();
      this.btnCalculate = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(36, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(93, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Enter your number";
      // 
      // txtNumber
      // 
      this.txtNumber.Location = new System.Drawing.Point(135, 19);
      this.txtNumber.Name = "txtNumber";
      this.txtNumber.Size = new System.Drawing.Size(100, 20);
      this.txtNumber.TabIndex = 1;
      // 
      // btnCalculate
      // 
      this.btnCalculate.Location = new System.Drawing.Point(135, 59);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(100, 35);
      this.btnCalculate.TabIndex = 2;
      this.btnCalculate.Text = "Calculate Factorial";
      this.btnCalculate.UseVisualStyleBackColor = true;
      this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
      // 
      // frmFactorial
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(295, 123);
      this.Controls.Add(this.btnCalculate);
      this.Controls.Add(this.txtNumber);
      this.Controls.Add(this.label1);
      this.Name = "frmFactorial";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Factorial Calculator";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtNumber;
    private System.Windows.Forms.Button btnCalculate;
  }
}

