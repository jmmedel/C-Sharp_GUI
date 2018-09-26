namespace Gaddis_07_06_NameSearch
{
  partial class frmNameSearch
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
      this.label2 = new System.Windows.Forms.Label();
      this.txtBoyName = new System.Windows.Forms.TextBox();
      this.txtGirlName = new System.Windows.Forms.TextBox();
      this.btnFind = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(91, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Enter Boy\'s Name";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(15, 54);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(88, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Enter Girl\'s Name";
      // 
      // txtBoyName
      // 
      this.txtBoyName.Location = new System.Drawing.Point(109, 20);
      this.txtBoyName.Name = "txtBoyName";
      this.txtBoyName.Size = new System.Drawing.Size(100, 20);
      this.txtBoyName.TabIndex = 2;
      // 
      // txtGirlName
      // 
      this.txtGirlName.Location = new System.Drawing.Point(109, 51);
      this.txtGirlName.Name = "txtGirlName";
      this.txtGirlName.Size = new System.Drawing.Size(100, 20);
      this.txtGirlName.TabIndex = 3;
      // 
      // btnFind
      // 
      this.btnFind.Location = new System.Drawing.Point(83, 100);
      this.btnFind.Name = "btnFind";
      this.btnFind.Size = new System.Drawing.Size(75, 23);
      this.btnFind.TabIndex = 4;
      this.btnFind.Text = "Find";
      this.btnFind.UseVisualStyleBackColor = true;
      this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
      // 
      // frmNameSearch
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(235, 137);
      this.Controls.Add(this.btnFind);
      this.Controls.Add(this.txtGirlName);
      this.Controls.Add(this.txtBoyName);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "frmNameSearch";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Name Search";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtBoyName;
    private System.Windows.Forms.TextBox txtGirlName;
    private System.Windows.Forms.Button btnFind;
  }
}

