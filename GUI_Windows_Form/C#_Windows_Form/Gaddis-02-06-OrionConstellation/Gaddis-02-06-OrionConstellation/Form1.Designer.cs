namespace Gaddis_02_06_OrionConstellation
{
  partial class frmOrion
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
      this.btnDisplayStars = new System.Windows.Forms.Button();
      this.btnHideStars = new System.Windows.Forms.Button();
      this.btnExit = new System.Windows.Forms.Button();
      this.picOrion = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.picOrion)).BeginInit();
      this.SuspendLayout();
      // 
      // btnDisplayStars
      // 
      this.btnDisplayStars.Location = new System.Drawing.Point(71, 343);
      this.btnDisplayStars.Name = "btnDisplayStars";
      this.btnDisplayStars.Size = new System.Drawing.Size(75, 23);
      this.btnDisplayStars.TabIndex = 0;
      this.btnDisplayStars.Text = "Show Stars";
      this.btnDisplayStars.UseVisualStyleBackColor = true;
      this.btnDisplayStars.Click += new System.EventHandler(this.btnDisplayStars_Click);
      // 
      // btnHideStars
      // 
      this.btnHideStars.Location = new System.Drawing.Point(212, 343);
      this.btnHideStars.Name = "btnHideStars";
      this.btnHideStars.Size = new System.Drawing.Size(75, 23);
      this.btnHideStars.TabIndex = 1;
      this.btnHideStars.Text = "Hide Stars";
      this.btnHideStars.UseVisualStyleBackColor = true;
      this.btnHideStars.Click += new System.EventHandler(this.btnHideStars_Click);
      // 
      // btnExit
      // 
      this.btnExit.Location = new System.Drawing.Point(342, 343);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(75, 23);
      this.btnExit.TabIndex = 2;
      this.btnExit.Text = "Exit";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // picOrion
      // 
      this.picOrion.Image = global::Gaddis_02_06_OrionConstellation.Properties.Resources.Orion;
      this.picOrion.Location = new System.Drawing.Point(12, 12);
      this.picOrion.Name = "picOrion";
      this.picOrion.Size = new System.Drawing.Size(439, 325);
      this.picOrion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picOrion.TabIndex = 3;
      this.picOrion.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(68, 26);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(60, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Betelgeuse";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(279, 154);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(45, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Mintaka";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(184, 139);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(40, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Alnilam";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(91, 172);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(39, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Alnitak";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(91, 284);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(34, 13);
      this.label5.TabIndex = 8;
      this.label5.Text = "Saiph";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(303, 264);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(31, 13);
      this.label6.TabIndex = 9;
      this.label6.Text = "Rigel";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(303, 44);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(40, 13);
      this.label7.TabIndex = 10;
      this.label7.Text = "Meissa";
      // 
      // frmOrion
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(463, 396);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.picOrion);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.btnHideStars);
      this.Controls.Add(this.btnDisplayStars);
      this.Name = "frmOrion";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Orion Constellation";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.picOrion)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnDisplayStars;
    private System.Windows.Forms.Button btnHideStars;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.PictureBox picOrion;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
  }
}

