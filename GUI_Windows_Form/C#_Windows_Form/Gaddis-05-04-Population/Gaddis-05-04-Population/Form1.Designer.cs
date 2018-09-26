namespace Gaddis_05_04_Population
{
  partial class frmPopulation
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
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtStartingNumber = new System.Windows.Forms.TextBox();
      this.txtDailyIncrease = new System.Windows.Forms.TextBox();
      this.txtNumOfDays = new System.Windows.Forms.TextBox();
      this.lstOutput = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // btnCalculate
      // 
      this.btnCalculate.Location = new System.Drawing.Point(182, 166);
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
      this.label1.Location = new System.Drawing.Point(50, 44);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(149, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Starting Number Of Organisms";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(82, 86);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(117, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Average Daily Increase";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(64, 126);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(135, 13);
      this.label3.TabIndex = 3;
      this.label3.Text = "Number Of Days to Multiply";
      // 
      // txtStartingNumber
      // 
      this.txtStartingNumber.Location = new System.Drawing.Point(205, 41);
      this.txtStartingNumber.Name = "txtStartingNumber";
      this.txtStartingNumber.Size = new System.Drawing.Size(100, 20);
      this.txtStartingNumber.TabIndex = 4;
      // 
      // txtDailyIncrease
      // 
      this.txtDailyIncrease.Location = new System.Drawing.Point(205, 83);
      this.txtDailyIncrease.Name = "txtDailyIncrease";
      this.txtDailyIncrease.Size = new System.Drawing.Size(100, 20);
      this.txtDailyIncrease.TabIndex = 5;
      // 
      // txtNumOfDays
      // 
      this.txtNumOfDays.Location = new System.Drawing.Point(205, 123);
      this.txtNumOfDays.Name = "txtNumOfDays";
      this.txtNumOfDays.Size = new System.Drawing.Size(100, 20);
      this.txtNumOfDays.TabIndex = 6;
      // 
      // lstOutput
      // 
      this.lstOutput.FormattingEnabled = true;
      this.lstOutput.Location = new System.Drawing.Point(12, 204);
      this.lstOutput.Name = "lstOutput";
      this.lstOutput.Size = new System.Drawing.Size(422, 199);
      this.lstOutput.TabIndex = 7;
      // 
      // frmPopulation
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(446, 411);
      this.Controls.Add(this.lstOutput);
      this.Controls.Add(this.txtNumOfDays);
      this.Controls.Add(this.txtDailyIncrease);
      this.Controls.Add(this.txtStartingNumber);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnCalculate);
      this.Name = "frmPopulation";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Population";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnCalculate;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtStartingNumber;
    private System.Windows.Forms.TextBox txtDailyIncrease;
    private System.Windows.Forms.TextBox txtNumOfDays;
    private System.Windows.Forms.ListBox lstOutput;
  }
}

