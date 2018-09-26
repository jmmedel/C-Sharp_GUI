namespace Gaddis_05_14_RandomNumberFileReader
{
  partial class frmRandomNumberFileReader
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
      this.btnReadFile = new System.Windows.Forms.Button();
      this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
      this.SuspendLayout();
      // 
      // lstOutput
      // 
      this.lstOutput.FormattingEnabled = true;
      this.lstOutput.Location = new System.Drawing.Point(74, 46);
      this.lstOutput.Name = "lstOutput";
      this.lstOutput.Size = new System.Drawing.Size(177, 82);
      this.lstOutput.TabIndex = 0;
      // 
      // btnReadFile
      // 
      this.btnReadFile.Location = new System.Drawing.Point(123, 17);
      this.btnReadFile.Name = "btnReadFile";
      this.btnReadFile.Size = new System.Drawing.Size(75, 23);
      this.btnReadFile.TabIndex = 1;
      this.btnReadFile.Text = "Read File";
      this.btnReadFile.UseVisualStyleBackColor = true;
      this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
      // 
      // frmRandomNumberFileReader
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(334, 140);
      this.Controls.Add(this.btnReadFile);
      this.Controls.Add(this.lstOutput);
      this.Name = "frmRandomNumberFileReader";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Random Number File Reader";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListBox lstOutput;
    private System.Windows.Forms.Button btnReadFile;
    private System.Windows.Forms.OpenFileDialog ofdOpenFile;
  }
}

