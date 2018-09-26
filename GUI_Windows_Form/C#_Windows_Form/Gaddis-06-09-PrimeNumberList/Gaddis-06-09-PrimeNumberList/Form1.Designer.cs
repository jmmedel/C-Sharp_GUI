namespace Gaddis_06_09_PrimeNumberList
{
  partial class frmPrimeNumberList
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
      this.btnDisplayList = new System.Windows.Forms.Button();
      this.lstOutput = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // btnDisplayList
      // 
      this.btnDisplayList.Location = new System.Drawing.Point(93, 12);
      this.btnDisplayList.Name = "btnDisplayList";
      this.btnDisplayList.Size = new System.Drawing.Size(75, 23);
      this.btnDisplayList.TabIndex = 0;
      this.btnDisplayList.Text = "Display List";
      this.btnDisplayList.UseVisualStyleBackColor = true;
      this.btnDisplayList.Click += new System.EventHandler(this.btnDisplayList_Click);
      // 
      // lstOutput
      // 
      this.lstOutput.FormattingEnabled = true;
      this.lstOutput.Location = new System.Drawing.Point(12, 41);
      this.lstOutput.Name = "lstOutput";
      this.lstOutput.Size = new System.Drawing.Size(260, 199);
      this.lstOutput.TabIndex = 1;
      // 
      // frmPrimeNumberList
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.lstOutput);
      this.Controls.Add(this.btnDisplayList);
      this.Name = "frmPrimeNumberList";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Prime Number List";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnDisplayList;
    private System.Windows.Forms.ListBox lstOutput;
  }
}

