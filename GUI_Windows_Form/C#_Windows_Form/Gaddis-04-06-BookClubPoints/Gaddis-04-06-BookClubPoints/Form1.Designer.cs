namespace Gaddis_04_06_BookClubPoints
{
  partial class frmBookClubPoints
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
      this.txtNumOfPurchasedBooks = new System.Windows.Forms.TextBox();
      this.btnCalculatePoints = new System.Windows.Forms.Button();
      this.txtEarnedPoints = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 26);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(145, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Number Of Books Purchased";
      // 
      // txtNumOfPurchasedBooks
      // 
      this.txtNumOfPurchasedBooks.Location = new System.Drawing.Point(163, 23);
      this.txtNumOfPurchasedBooks.Name = "txtNumOfPurchasedBooks";
      this.txtNumOfPurchasedBooks.Size = new System.Drawing.Size(100, 20);
      this.txtNumOfPurchasedBooks.TabIndex = 1;
      // 
      // btnCalculatePoints
      // 
      this.btnCalculatePoints.Location = new System.Drawing.Point(163, 49);
      this.btnCalculatePoints.Name = "btnCalculatePoints";
      this.btnCalculatePoints.Size = new System.Drawing.Size(100, 23);
      this.btnCalculatePoints.TabIndex = 2;
      this.btnCalculatePoints.Text = "Calculate Points";
      this.btnCalculatePoints.UseVisualStyleBackColor = true;
      this.btnCalculatePoints.Click += new System.EventHandler(this.btnCalculatePoints_Click);
      // 
      // txtEarnedPoints
      // 
      this.txtEarnedPoints.Location = new System.Drawing.Point(163, 104);
      this.txtEarnedPoints.Name = "txtEarnedPoints";
      this.txtEarnedPoints.Size = new System.Drawing.Size(100, 20);
      this.txtEarnedPoints.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(84, 107);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(73, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Earned Points";
      // 
      // frmBookClubPoints
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 151);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtEarnedPoints);
      this.Controls.Add(this.btnCalculatePoints);
      this.Controls.Add(this.txtNumOfPurchasedBooks);
      this.Controls.Add(this.label1);
      this.Name = "frmBookClubPoints";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Book Club Points";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtNumOfPurchasedBooks;
    private System.Windows.Forms.Button btnCalculatePoints;
    private System.Windows.Forms.TextBox txtEarnedPoints;
    private System.Windows.Forms.Label label2;
  }
}

