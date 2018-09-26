namespace Gaddis_06_10_RockPaperScissors
{
  partial class frmRockPaperScissors
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
      this.picRock = new System.Windows.Forms.PictureBox();
      this.picPaper = new System.Windows.Forms.PictureBox();
      this.picScissors = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtMessage = new System.Windows.Forms.TextBox();
      this.txtPlayerScore = new System.Windows.Forms.TextBox();
      this.txtComputerScore = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.picRock)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picPaper)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picScissors)).BeginInit();
      this.SuspendLayout();
      // 
      // picRock
      // 
      this.picRock.Image = global::Gaddis_06_10_RockPaperScissors.Properties.Resources.Rock;
      this.picRock.Location = new System.Drawing.Point(60, 79);
      this.picRock.Name = "picRock";
      this.picRock.Size = new System.Drawing.Size(64, 64);
      this.picRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.picRock.TabIndex = 0;
      this.picRock.TabStop = false;
      this.picRock.Click += new System.EventHandler(this.picRock_Click);
      // 
      // picPaper
      // 
      this.picPaper.Image = global::Gaddis_06_10_RockPaperScissors.Properties.Resources.Paper;
      this.picPaper.Location = new System.Drawing.Point(148, 79);
      this.picPaper.Name = "picPaper";
      this.picPaper.Size = new System.Drawing.Size(64, 64);
      this.picPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.picPaper.TabIndex = 1;
      this.picPaper.TabStop = false;
      this.picPaper.Click += new System.EventHandler(this.picPaper_Click);
      // 
      // picScissors
      // 
      this.picScissors.Image = global::Gaddis_06_10_RockPaperScissors.Properties.Resources.Scissors;
      this.picScissors.Location = new System.Drawing.Point(239, 79);
      this.picScissors.Name = "picScissors";
      this.picScissors.Size = new System.Drawing.Size(64, 64);
      this.picScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.picScissors.TabIndex = 2;
      this.picScissors.TabStop = false;
      this.picScissors.Click += new System.EventHandler(this.picScissors_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(72, 165);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(52, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Computer";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(239, 165);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(36, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Player";
      // 
      // txtMessage
      // 
      this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtMessage.Location = new System.Drawing.Point(12, 12);
      this.txtMessage.Multiline = true;
      this.txtMessage.Name = "txtMessage";
      this.txtMessage.ReadOnly = true;
      this.txtMessage.Size = new System.Drawing.Size(325, 45);
      this.txtMessage.TabIndex = 5;
      this.txtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // txtPlayerScore
      // 
      this.txtPlayerScore.Location = new System.Drawing.Point(211, 181);
      this.txtPlayerScore.Name = "txtPlayerScore";
      this.txtPlayerScore.ReadOnly = true;
      this.txtPlayerScore.Size = new System.Drawing.Size(64, 20);
      this.txtPlayerScore.TabIndex = 7;
      // 
      // txtComputerScore
      // 
      this.txtComputerScore.Location = new System.Drawing.Point(75, 181);
      this.txtComputerScore.Name = "txtComputerScore";
      this.txtComputerScore.ReadOnly = true;
      this.txtComputerScore.Size = new System.Drawing.Size(64, 20);
      this.txtComputerScore.TabIndex = 8;
      // 
      // frmRockPaperScissors
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(349, 232);
      this.Controls.Add(this.txtComputerScore);
      this.Controls.Add(this.txtPlayerScore);
      this.Controls.Add(this.txtMessage);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.picScissors);
      this.Controls.Add(this.picPaper);
      this.Controls.Add(this.picRock);
      this.Name = "frmRockPaperScissors";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Rock Paper Scissors";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.picRock)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picPaper)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picScissors)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox picRock;
    private System.Windows.Forms.PictureBox picPaper;
    private System.Windows.Forms.PictureBox picScissors;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtMessage;
    private System.Windows.Forms.TextBox txtPlayerScore;
    private System.Windows.Forms.TextBox txtComputerScore;
  }
}

