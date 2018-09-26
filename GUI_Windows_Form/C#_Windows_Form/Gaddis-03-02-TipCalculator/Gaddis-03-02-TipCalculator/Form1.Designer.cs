namespace Gaddis_03_02_TipCalculator
{
  partial class frmTipCalculator
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
      this.txtMealCost = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lstOutput
      // 
      this.lstOutput.FormattingEnabled = true;
      this.lstOutput.Location = new System.Drawing.Point(17, 102);
      this.lstOutput.Name = "lstOutput";
      this.lstOutput.Size = new System.Drawing.Size(182, 95);
      this.lstOutput.TabIndex = 0;
      // 
      // btnCalculate
      // 
      this.btnCalculate.Location = new System.Drawing.Point(124, 38);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(75, 23);
      this.btnCalculate.TabIndex = 1;
      this.btnCalculate.Text = "Calculate";
      this.btnCalculate.UseVisualStyleBackColor = true;
      this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
      // 
      // txtMealCost
      // 
      this.txtMealCost.Location = new System.Drawing.Point(99, 12);
      this.txtMealCost.Name = "txtMealCost";
      this.txtMealCost.Size = new System.Drawing.Size(100, 20);
      this.txtMealCost.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(14, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(68, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Cost Of Meal";
      // 
      // frmTipCalculator
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(220, 212);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtMealCost);
      this.Controls.Add(this.btnCalculate);
      this.Controls.Add(this.lstOutput);
      this.Name = "frmTipCalculator";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Tip Calculator";
      this.Load += new System.EventHandler(this.frmTipCalculator_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox lstOutput;
    private System.Windows.Forms.Button btnCalculate;
    private System.Windows.Forms.TextBox txtMealCost;
    private System.Windows.Forms.Label label1;
  }
}

