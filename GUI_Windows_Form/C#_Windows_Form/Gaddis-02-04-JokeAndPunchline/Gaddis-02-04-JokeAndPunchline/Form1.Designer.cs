namespace Gaddis_02_04_JokeAndPunchline
{
  partial class frmJoke
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
      this.lblJoke = new System.Windows.Forms.Label();
      this.btnSetup = new System.Windows.Forms.Button();
      this.btnPunchLine = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblJoke
      // 
      this.lblJoke.AutoSize = true;
      this.lblJoke.Location = new System.Drawing.Point(37, 35);
      this.lblJoke.Name = "lblJoke";
      this.lblJoke.Size = new System.Drawing.Size(0, 13);
      this.lblJoke.TabIndex = 0;
      // 
      // btnSetup
      // 
      this.btnSetup.Location = new System.Drawing.Point(24, 103);
      this.btnSetup.Name = "btnSetup";
      this.btnSetup.Size = new System.Drawing.Size(75, 23);
      this.btnSetup.TabIndex = 1;
      this.btnSetup.Text = "Setup";
      this.btnSetup.UseVisualStyleBackColor = true;
      this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
      // 
      // btnPunchLine
      // 
      this.btnPunchLine.Location = new System.Drawing.Point(197, 103);
      this.btnPunchLine.Name = "btnPunchLine";
      this.btnPunchLine.Size = new System.Drawing.Size(75, 23);
      this.btnPunchLine.TabIndex = 2;
      this.btnPunchLine.Text = "Punch Line";
      this.btnPunchLine.UseVisualStyleBackColor = true;
      this.btnPunchLine.Click += new System.EventHandler(this.btnPunchLine_Click);
      // 
      // frmJoke
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 142);
      this.Controls.Add(this.btnPunchLine);
      this.Controls.Add(this.btnSetup);
      this.Controls.Add(this.lblJoke);
      this.Name = "frmJoke";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Joke";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblJoke;
    private System.Windows.Forms.Button btnSetup;
    private System.Windows.Forms.Button btnPunchLine;
  }
}

