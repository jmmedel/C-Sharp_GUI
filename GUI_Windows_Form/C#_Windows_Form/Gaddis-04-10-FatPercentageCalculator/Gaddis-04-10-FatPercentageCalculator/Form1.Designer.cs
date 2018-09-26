namespace Gaddis_04_10_FatPercentageCalculator
{
  partial class frmFatPercentageCalculator
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
      this.txtNumberOfCalories = new System.Windows.Forms.TextBox();
      this.txtNumberOfFatGrams = new System.Windows.Forms.TextBox();
      this.chcLowFat = new System.Windows.Forms.CheckBox();
      this.btnCalculate = new System.Windows.Forms.Button();
      this.lstOutput = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(20, 20);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(101, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Number Of Calories:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 50);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(109, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Number Of Fat Grams";
      // 
      // txtNumberOfCalories
      // 
      this.txtNumberOfCalories.Location = new System.Drawing.Point(134, 17);
      this.txtNumberOfCalories.Name = "txtNumberOfCalories";
      this.txtNumberOfCalories.Size = new System.Drawing.Size(132, 20);
      this.txtNumberOfCalories.TabIndex = 0;
      // 
      // txtNumberOfFatGrams
      // 
      this.txtNumberOfFatGrams.Location = new System.Drawing.Point(134, 47);
      this.txtNumberOfFatGrams.Name = "txtNumberOfFatGrams";
      this.txtNumberOfFatGrams.Size = new System.Drawing.Size(132, 20);
      this.txtNumberOfFatGrams.TabIndex = 1;
      // 
      // chcLowFat
      // 
      this.chcLowFat.AutoSize = true;
      this.chcLowFat.Location = new System.Drawing.Point(134, 73);
      this.chcLowFat.Name = "chcLowFat";
      this.chcLowFat.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.chcLowFat.Size = new System.Drawing.Size(70, 17);
      this.chcLowFat.TabIndex = 2;
      this.chcLowFat.Text = "Low Fat?";
      this.chcLowFat.UseVisualStyleBackColor = true;
      // 
      // btnCalculate
      // 
      this.btnCalculate.Location = new System.Drawing.Point(166, 113);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(100, 23);
      this.btnCalculate.TabIndex = 3;
      this.btnCalculate.Text = "Calculate";
      this.btnCalculate.UseVisualStyleBackColor = true;
      this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
      // 
      // lstOutput
      // 
      this.lstOutput.FormattingEnabled = true;
      this.lstOutput.Location = new System.Drawing.Point(23, 154);
      this.lstOutput.Name = "lstOutput";
      this.lstOutput.Size = new System.Drawing.Size(243, 95);
      this.lstOutput.TabIndex = 4;
      // 
      // frmFatPercentageCalculator
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(278, 261);
      this.Controls.Add(this.lstOutput);
      this.Controls.Add(this.btnCalculate);
      this.Controls.Add(this.chcLowFat);
      this.Controls.Add(this.txtNumberOfFatGrams);
      this.Controls.Add(this.txtNumberOfCalories);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "frmFatPercentageCalculator";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Fat Percentage Calculator";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtNumberOfCalories;
    private System.Windows.Forms.TextBox txtNumberOfFatGrams;
    private System.Windows.Forms.CheckBox chcLowFat;
    private System.Windows.Forms.Button btnCalculate;
    private System.Windows.Forms.ListBox lstOutput;
  }
}

