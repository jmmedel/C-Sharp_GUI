namespace Gaddis_05_09_DiceSimulator
{
  partial class frmDiceSumulator
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
      this.btnRollDice = new System.Windows.Forms.Button();
      this.picDie1 = new System.Windows.Forms.PictureBox();
      this.picDie2 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.picDie1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picDie2)).BeginInit();
      this.SuspendLayout();
      // 
      // btnRollDice
      // 
      this.btnRollDice.Location = new System.Drawing.Point(99, 138);
      this.btnRollDice.Name = "btnRollDice";
      this.btnRollDice.Size = new System.Drawing.Size(75, 23);
      this.btnRollDice.TabIndex = 0;
      this.btnRollDice.Text = "Roll Dice";
      this.btnRollDice.UseVisualStyleBackColor = true;
      this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
      // 
      // picDie1
      // 
      this.picDie1.Location = new System.Drawing.Point(12, 12);
      this.picDie1.Name = "picDie1";
      this.picDie1.Size = new System.Drawing.Size(104, 104);
      this.picDie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.picDie1.TabIndex = 1;
      this.picDie1.TabStop = false;
      // 
      // picDie2
      // 
      this.picDie2.Location = new System.Drawing.Point(152, 12);
      this.picDie2.Name = "picDie2";
      this.picDie2.Size = new System.Drawing.Size(104, 104);
      this.picDie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.picDie2.TabIndex = 2;
      this.picDie2.TabStop = false;
      // 
      // frmDiceSumulator
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(281, 173);
      this.Controls.Add(this.picDie2);
      this.Controls.Add(this.picDie1);
      this.Controls.Add(this.btnRollDice);
      this.Name = "frmDiceSumulator";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Dice Simulator";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.picDie1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picDie2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnRollDice;
    private System.Windows.Forms.PictureBox picDie1;
    private System.Windows.Forms.PictureBox picDie2;
  }
}

