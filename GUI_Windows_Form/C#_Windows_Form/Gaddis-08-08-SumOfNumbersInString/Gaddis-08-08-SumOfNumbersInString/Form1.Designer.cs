namespace Gaddis_08_08_SumOfNumbersInString
{
  partial class frmSumOfNumbers
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
      this.btnCalculate = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtNumbers = new System.Windows.Forms.TextBox();
      this.txtSum = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnCalculate
      // 
      this.btnCalculate.Location = new System.Drawing.Point(86, 60);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(90, 23);
      this.btnCalculate.TabIndex = 0;
      this.btnCalculate.Text = "Calculate Sum";
      this.btnCalculate.UseVisualStyleBackColor = true;
      this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(52, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(182, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Enter Numbers Separated By Comma";
      // 
      // txtNumbers
      // 
      this.txtNumbers.Location = new System.Drawing.Point(12, 25);
      this.txtNumbers.Name = "txtNumbers";
      this.txtNumbers.Size = new System.Drawing.Size(260, 20);
      this.txtNumbers.TabIndex = 2;
      // 
      // txtSum
      // 
      this.txtSum.Location = new System.Drawing.Point(86, 101);
      this.txtSum.Name = "txtSum";
      this.txtSum.Size = new System.Drawing.Size(90, 20);
      this.txtSum.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(45, 104);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(28, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Sum";
      // 
      // frmSumOfNumbers
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 139);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtSum);
      this.Controls.Add(this.txtNumbers);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnCalculate);
      this.Name = "frmSumOfNumbers";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Sum Of Numbers In String";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnCalculate;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtNumbers;
    private System.Windows.Forms.TextBox txtSum;
    private System.Windows.Forms.Label label2;
  }
}

