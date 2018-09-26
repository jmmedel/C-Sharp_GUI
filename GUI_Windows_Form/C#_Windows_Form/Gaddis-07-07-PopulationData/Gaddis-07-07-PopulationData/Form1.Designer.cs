namespace Gaddis_07_07_PopulationData
{
  partial class frmPopulationData
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
      this.btnStatistics = new System.Windows.Forms.Button();
      this.lstOutput = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // btnStatistics
      // 
      this.btnStatistics.Location = new System.Drawing.Point(164, 12);
      this.btnStatistics.Name = "btnStatistics";
      this.btnStatistics.Size = new System.Drawing.Size(107, 23);
      this.btnStatistics.TabIndex = 0;
      this.btnStatistics.Text = "Display Statistics";
      this.btnStatistics.UseVisualStyleBackColor = true;
      this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
      // 
      // lstOutput
      // 
      this.lstOutput.FormattingEnabled = true;
      this.lstOutput.Location = new System.Drawing.Point(12, 41);
      this.lstOutput.Name = "lstOutput";
      this.lstOutput.Size = new System.Drawing.Size(395, 147);
      this.lstOutput.TabIndex = 1;
      // 
      // frmPopulationData
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(429, 203);
      this.Controls.Add(this.lstOutput);
      this.Controls.Add(this.btnStatistics);
      this.Name = "frmPopulationData";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Population Data";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnStatistics;
    private System.Windows.Forms.ListBox lstOutput;
  }
}

