namespace Gaddis_08_02_AverageNumberOfLetters
{
  partial class frmWordCounter
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
      this.txtString = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnCountWords = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // txtString
      // 
      this.txtString.Location = new System.Drawing.Point(91, 26);
      this.txtString.Name = "txtString";
      this.txtString.Size = new System.Drawing.Size(315, 20);
      this.txtString.TabIndex = 5;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(23, 29);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(62, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Enter String";
      // 
      // btnCountWords
      // 
      this.btnCountWords.Location = new System.Drawing.Point(316, 62);
      this.btnCountWords.Name = "btnCountWords";
      this.btnCountWords.Size = new System.Drawing.Size(90, 23);
      this.btnCountWords.TabIndex = 3;
      this.btnCountWords.Text = "Count Words";
      this.btnCountWords.UseVisualStyleBackColor = true;
      this.btnCountWords.Click += new System.EventHandler(this.btnCountWords_Click);
      // 
      // frmWordCounter
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(440, 114);
      this.Controls.Add(this.txtString);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnCountWords);
      this.Name = "frmWordCounter";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Word Counter";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtString;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnCountWords;
  }
}

