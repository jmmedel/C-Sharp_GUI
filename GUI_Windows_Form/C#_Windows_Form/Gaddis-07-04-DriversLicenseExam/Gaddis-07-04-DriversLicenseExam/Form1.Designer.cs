namespace Gaddis_07_04_DriversLicenseExam
{
  partial class frmDriversLicenseExam
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
      this.btnEvaluate = new System.Windows.Forms.Button();
      this.lstOutput = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // btnEvaluate
      // 
      this.btnEvaluate.Location = new System.Drawing.Point(88, 30);
      this.btnEvaluate.Name = "btnEvaluate";
      this.btnEvaluate.Size = new System.Drawing.Size(75, 23);
      this.btnEvaluate.TabIndex = 0;
      this.btnEvaluate.Text = "Evaluate";
      this.btnEvaluate.UseVisualStyleBackColor = true;
      this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
      // 
      // lstOutput
      // 
      this.lstOutput.FormattingEnabled = true;
      this.lstOutput.Location = new System.Drawing.Point(12, 73);
      this.lstOutput.Name = "lstOutput";
      this.lstOutput.Size = new System.Drawing.Size(260, 173);
      this.lstOutput.TabIndex = 1;
      // 
      // frmDriversLicenseExam
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.lstOutput);
      this.Controls.Add(this.btnEvaluate);
      this.Name = "frmDriversLicenseExam";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Driver\'s License Exam";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnEvaluate;
    private System.Windows.Forms.ListBox lstOutput;
  }
}

