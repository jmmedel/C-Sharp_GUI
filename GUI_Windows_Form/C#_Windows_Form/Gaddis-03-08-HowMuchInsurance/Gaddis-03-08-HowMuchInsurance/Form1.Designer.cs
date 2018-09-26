namespace Gaddis_03_08_HowMuchInsurance
{
  partial class frmInsurance
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
      this.txtReplacementCost = new System.Windows.Forms.TextBox();
      this.txtInsurance = new System.Windows.Forms.TextBox();
      this.btnCalculate = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(25, 29);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(94, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Replacement Cost";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 115);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(107, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Amount Of Insurance";
      // 
      // txtReplacementCost
      // 
      this.txtReplacementCost.Location = new System.Drawing.Point(138, 26);
      this.txtReplacementCost.Name = "txtReplacementCost";
      this.txtReplacementCost.Size = new System.Drawing.Size(100, 20);
      this.txtReplacementCost.TabIndex = 2;
      // 
      // txtInsurance
      // 
      this.txtInsurance.Location = new System.Drawing.Point(138, 112);
      this.txtInsurance.Name = "txtInsurance";
      this.txtInsurance.Size = new System.Drawing.Size(100, 20);
      this.txtInsurance.TabIndex = 3;
      // 
      // btnCalculate
      // 
      this.btnCalculate.Location = new System.Drawing.Point(157, 52);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(81, 35);
      this.btnCalculate.TabIndex = 4;
      this.btnCalculate.Text = "Calculate Insurance";
      this.btnCalculate.UseVisualStyleBackColor = true;
      this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
      // 
      // frmInsurance
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 150);
      this.Controls.Add(this.btnCalculate);
      this.Controls.Add(this.txtInsurance);
      this.Controls.Add(this.txtReplacementCost);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "frmInsurance";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Recommended Insurance";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtReplacementCost;
    private System.Windows.Forms.TextBox txtInsurance;
    private System.Windows.Forms.Button btnCalculate;
  }
}

