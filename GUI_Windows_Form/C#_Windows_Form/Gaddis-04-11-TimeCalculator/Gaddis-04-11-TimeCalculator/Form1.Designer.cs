namespace Gaddis_04_11_TimeCalculator
{
  partial class frmTimeCalculator
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
      this.txtTimeInput = new System.Windows.Forms.TextBox();
      this.txtOutput = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // btnCalculate
      // 
      this.btnCalculate.Location = new System.Drawing.Point(197, 44);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(75, 23);
      this.btnCalculate.TabIndex = 0;
      this.btnCalculate.Text = "Calculate";
      this.btnCalculate.UseVisualStyleBackColor = true;
      this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 21);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(117, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Enter Time in Seconds:";
      // 
      // txtTimeInput
      // 
      this.txtTimeInput.Location = new System.Drawing.Point(172, 18);
      this.txtTimeInput.Name = "txtTimeInput";
      this.txtTimeInput.Size = new System.Drawing.Size(100, 20);
      this.txtTimeInput.TabIndex = 2;
      // 
      // txtOutput
      // 
      this.txtOutput.Location = new System.Drawing.Point(12, 86);
      this.txtOutput.Name = "txtOutput";
      this.txtOutput.ReadOnly = true;
      this.txtOutput.Size = new System.Drawing.Size(260, 20);
      this.txtOutput.TabIndex = 3;
      this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // frmTimeCalculator
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 132);
      this.Controls.Add(this.txtOutput);
      this.Controls.Add(this.txtTimeInput);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnCalculate);
      this.Name = "frmTimeCalculator";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Time Calculator";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnCalculate;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtTimeInput;
    private System.Windows.Forms.TextBox txtOutput;
  }
}

