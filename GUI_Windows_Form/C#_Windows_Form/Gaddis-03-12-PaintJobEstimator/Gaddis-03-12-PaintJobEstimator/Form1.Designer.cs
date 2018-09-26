namespace Gaddis_03_12_PaintJobEstimator
{
  partial class frmPaintJobEstimator
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
      this.label2 = new System.Windows.Forms.Label();
      this.txtSquareFeet = new System.Windows.Forms.TextBox();
      this.txtCostOfPaint = new System.Windows.Forms.TextBox();
      this.lstOutput = new System.Windows.Forms.ListBox();
      this.btnCalculate = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(56, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(68, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Square Feet:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(0, 55);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(124, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Cost Of Paint (per gallon)";
      // 
      // txtSquareFeet
      // 
      this.txtSquareFeet.Location = new System.Drawing.Point(130, 15);
      this.txtSquareFeet.Name = "txtSquareFeet";
      this.txtSquareFeet.Size = new System.Drawing.Size(100, 20);
      this.txtSquareFeet.TabIndex = 2;
      // 
      // txtCostOfPaint
      // 
      this.txtCostOfPaint.Location = new System.Drawing.Point(130, 52);
      this.txtCostOfPaint.Name = "txtCostOfPaint";
      this.txtCostOfPaint.Size = new System.Drawing.Size(100, 20);
      this.txtCostOfPaint.TabIndex = 3;
      // 
      // lstOutput
      // 
      this.lstOutput.FormattingEnabled = true;
      this.lstOutput.Location = new System.Drawing.Point(4, 126);
      this.lstOutput.Name = "lstOutput";
      this.lstOutput.Size = new System.Drawing.Size(235, 121);
      this.lstOutput.TabIndex = 4;
      // 
      // btnCalculate
      // 
      this.btnCalculate.Location = new System.Drawing.Point(155, 88);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(75, 23);
      this.btnCalculate.TabIndex = 5;
      this.btnCalculate.Text = "Calculate";
      this.btnCalculate.UseVisualStyleBackColor = true;
      this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
      // 
      // frmPaintJobEstimator
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(245, 261);
      this.Controls.Add(this.btnCalculate);
      this.Controls.Add(this.lstOutput);
      this.Controls.Add(this.txtCostOfPaint);
      this.Controls.Add(this.txtSquareFeet);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "frmPaintJobEstimator";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Paint Job Estimator";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtSquareFeet;
    private System.Windows.Forms.TextBox txtCostOfPaint;
    private System.Windows.Forms.ListBox lstOutput;
    private System.Windows.Forms.Button btnCalculate;
  }
}

