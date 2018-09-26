namespace Gaddis_05_05_PenniesForPay
{
  partial class frmPenniesForPay
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
      this.lstOutput = new System.Windows.Forms.ListBox();
      this.btnCalculate = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtNumOfDays = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // lstOutput
      // 
      this.lstOutput.FormattingEnabled = true;
      this.lstOutput.Location = new System.Drawing.Point(12, 103);
      this.lstOutput.Name = "lstOutput";
      this.lstOutput.Size = new System.Drawing.Size(260, 147);
      this.lstOutput.TabIndex = 0;
      // 
      // btnCalculate
      // 
      this.btnCalculate.Location = new System.Drawing.Point(187, 58);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(75, 23);
      this.btnCalculate.TabIndex = 1;
      this.btnCalculate.Text = "Calculate";
      this.btnCalculate.UseVisualStyleBackColor = true;
      this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(31, 20);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(113, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Enter Number Of Days";
      // 
      // txtNumOfDays
      // 
      this.txtNumOfDays.Location = new System.Drawing.Point(162, 17);
      this.txtNumOfDays.Name = "txtNumOfDays";
      this.txtNumOfDays.Size = new System.Drawing.Size(100, 20);
      this.txtNumOfDays.TabIndex = 3;
      // 
      // frmPenniesForPay
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.txtNumOfDays);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnCalculate);
      this.Controls.Add(this.lstOutput);
      this.Name = "frmPenniesForPay";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Pennies For Pay";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox lstOutput;
    private System.Windows.Forms.Button btnCalculate;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtNumOfDays;
  }
}

