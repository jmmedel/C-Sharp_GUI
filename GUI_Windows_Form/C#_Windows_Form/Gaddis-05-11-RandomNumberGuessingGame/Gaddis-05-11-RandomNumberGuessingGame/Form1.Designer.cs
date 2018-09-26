namespace Gaddis_05_11_RandomNumberGuessingGame
{
  partial class frmRandomNumberGuessingGame
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
      this.txtGuess = new System.Windows.Forms.TextBox();
      this.btnGuessNumber = new System.Windows.Forms.Button();
      this.txtMessage = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(31, 71);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(160, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "What number are you guessing?";
      // 
      // txtGuess
      // 
      this.txtGuess.Location = new System.Drawing.Point(197, 68);
      this.txtGuess.Name = "txtGuess";
      this.txtGuess.Size = new System.Drawing.Size(100, 20);
      this.txtGuess.TabIndex = 1;
      // 
      // btnGuessNumber
      // 
      this.btnGuessNumber.Location = new System.Drawing.Point(197, 107);
      this.btnGuessNumber.Name = "btnGuessNumber";
      this.btnGuessNumber.Size = new System.Drawing.Size(100, 35);
      this.btnGuessNumber.TabIndex = 2;
      this.btnGuessNumber.Text = "Submit Your Guess";
      this.btnGuessNumber.UseVisualStyleBackColor = true;
      this.btnGuessNumber.Click += new System.EventHandler(this.btnGuessNumber_Click);
      // 
      // txtMessage
      // 
      this.txtMessage.Location = new System.Drawing.Point(34, 24);
      this.txtMessage.Name = "txtMessage";
      this.txtMessage.ReadOnly = true;
      this.txtMessage.Size = new System.Drawing.Size(263, 20);
      this.txtMessage.TabIndex = 3;
      this.txtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // frmRandomNumberGuessingGame
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(335, 158);
      this.Controls.Add(this.txtMessage);
      this.Controls.Add(this.btnGuessNumber);
      this.Controls.Add(this.txtGuess);
      this.Controls.Add(this.label1);
      this.Name = "frmRandomNumberGuessingGame";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Random Number Guessing Game";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtGuess;
    private System.Windows.Forms.Button btnGuessNumber;
    private System.Windows.Forms.TextBox txtMessage;
  }
}

