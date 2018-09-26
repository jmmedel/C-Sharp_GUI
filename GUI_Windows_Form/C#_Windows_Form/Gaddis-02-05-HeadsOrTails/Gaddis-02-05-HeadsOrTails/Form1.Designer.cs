namespace Gaddis_02_05_HeadsOrTails
{
  partial class frmCoinToss
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
      this.btnHeads = new System.Windows.Forms.Button();
      this.btnTails = new System.Windows.Forms.Button();
      this.picHeads = new System.Windows.Forms.PictureBox();
      this.picTails = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.picHeads)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picTails)).BeginInit();
      this.SuspendLayout();
      // 
      // btnHeads
      // 
      this.btnHeads.Location = new System.Drawing.Point(26, 206);
      this.btnHeads.Name = "btnHeads";
      this.btnHeads.Size = new System.Drawing.Size(75, 43);
      this.btnHeads.TabIndex = 0;
      this.btnHeads.Text = "Show Heads";
      this.btnHeads.UseVisualStyleBackColor = true;
      this.btnHeads.Click += new System.EventHandler(this.btnHeads_Click);
      // 
      // btnTails
      // 
      this.btnTails.Location = new System.Drawing.Point(186, 206);
      this.btnTails.Name = "btnTails";
      this.btnTails.Size = new System.Drawing.Size(75, 43);
      this.btnTails.TabIndex = 1;
      this.btnTails.Text = "Show Tails";
      this.btnTails.UseVisualStyleBackColor = true;
      this.btnTails.Click += new System.EventHandler(this.btnTails_Click);
      // 
      // picHeads
      // 
      this.picHeads.Image = global::Gaddis_02_05_HeadsOrTails.Properties.Resources.Heads1;
      this.picHeads.Location = new System.Drawing.Point(26, 24);
      this.picHeads.Name = "picHeads";
      this.picHeads.Size = new System.Drawing.Size(100, 99);
      this.picHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picHeads.TabIndex = 2;
      this.picHeads.TabStop = false;
      this.picHeads.Visible = false;
      // 
      // picTails
      // 
      this.picTails.Image = global::Gaddis_02_05_HeadsOrTails.Properties.Resources.Tails1;
      this.picTails.Location = new System.Drawing.Point(172, 24);
      this.picTails.Name = "picTails";
      this.picTails.Size = new System.Drawing.Size(100, 99);
      this.picTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picTails.TabIndex = 3;
      this.picTails.TabStop = false;
      this.picTails.Visible = false;
      // 
      // frmCoinToss
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.picTails);
      this.Controls.Add(this.picHeads);
      this.Controls.Add(this.btnTails);
      this.Controls.Add(this.btnHeads);
      this.Name = "frmCoinToss";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Coin Toss";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.picHeads)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picTails)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnHeads;
    private System.Windows.Forms.Button btnTails;
    private System.Windows.Forms.PictureBox picHeads;
    private System.Windows.Forms.PictureBox picTails;
  }
}

