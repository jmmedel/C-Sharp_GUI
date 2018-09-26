namespace Gaddis_05_13_RandomNumberFileWriter
{
  partial class frmRandomNumberFileWriter
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
      this.txtHowManyNumbers = new System.Windows.Forms.TextBox();
      this.btnWriteFile = new System.Windows.Forms.Button();
      this.sfdSaveFile = new System.Windows.Forms.SaveFileDialog();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 30);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(143, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "How many numbers to write?";
      // 
      // txtHowManyNumbers
      // 
      this.txtHowManyNumbers.Location = new System.Drawing.Point(161, 27);
      this.txtHowManyNumbers.Name = "txtHowManyNumbers";
      this.txtHowManyNumbers.Size = new System.Drawing.Size(100, 20);
      this.txtHowManyNumbers.TabIndex = 1;
      // 
      // btnWriteFile
      // 
      this.btnWriteFile.Location = new System.Drawing.Point(186, 66);
      this.btnWriteFile.Name = "btnWriteFile";
      this.btnWriteFile.Size = new System.Drawing.Size(75, 23);
      this.btnWriteFile.TabIndex = 2;
      this.btnWriteFile.Text = "Write File";
      this.btnWriteFile.UseVisualStyleBackColor = true;
      this.btnWriteFile.Click += new System.EventHandler(this.btnWriteFile_Click);
      // 
      // sfdSaveFile
      // 
      
      // 
      // frmRandomNumberFileWriter
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 112);
      this.Controls.Add(this.btnWriteFile);
      this.Controls.Add(this.txtHowManyNumbers);
      this.Controls.Add(this.label1);
      this.Name = "frmRandomNumberFileWriter";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Random Number File Writer";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtHowManyNumbers;
    private System.Windows.Forms.Button btnWriteFile;
    private System.Windows.Forms.SaveFileDialog sfdSaveFile;
  }
}

