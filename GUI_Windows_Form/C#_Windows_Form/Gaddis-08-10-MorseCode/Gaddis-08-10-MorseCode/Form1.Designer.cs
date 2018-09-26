namespace Gaddis_08_10_MorseCode
{
  partial class frmMorseCode
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
      this.txtInput = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtMorseCode = new System.Windows.Forms.TextBox();
      this.btnTranslate = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 24);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(129, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Enter Words To Translate";
      // 
      // txtInput
      // 
      this.txtInput.Location = new System.Drawing.Point(147, 21);
      this.txtInput.Name = "txtInput";
      this.txtInput.Size = new System.Drawing.Size(337, 20);
      this.txtInput.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(77, 89);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(64, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Morse Code";
      // 
      // txtMorseCode
      // 
      this.txtMorseCode.Location = new System.Drawing.Point(147, 86);
      this.txtMorseCode.Name = "txtMorseCode";
      this.txtMorseCode.Size = new System.Drawing.Size(337, 20);
      this.txtMorseCode.TabIndex = 3;
      // 
      // btnTranslate
      // 
      this.btnTranslate.Location = new System.Drawing.Point(322, 47);
      this.btnTranslate.Name = "btnTranslate";
      this.btnTranslate.Size = new System.Drawing.Size(162, 23);
      this.btnTranslate.TabIndex = 4;
      this.btnTranslate.Text = "Translate to Morse code";
      this.btnTranslate.UseVisualStyleBackColor = true;
      this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
      // 
      // frmMorseCode
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(496, 123);
      this.Controls.Add(this.btnTranslate);
      this.Controls.Add(this.txtMorseCode);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtInput);
      this.Controls.Add(this.label1);
      this.Name = "frmMorseCode";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Morse Code";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtInput;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtMorseCode;
    private System.Windows.Forms.Button btnTranslate;
  }
}

