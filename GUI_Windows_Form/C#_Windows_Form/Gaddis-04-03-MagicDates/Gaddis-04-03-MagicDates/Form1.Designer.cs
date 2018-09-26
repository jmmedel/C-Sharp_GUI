namespace Gaddis_04_03_MagicDates
{
  partial class frmMagicDates
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
      this.label3 = new System.Windows.Forms.Label();
      this.txtDay = new System.Windows.Forms.TextBox();
      this.txtMonth = new System.Windows.Forms.TextBox();
      this.txtYear = new System.Windows.Forms.MaskedTextBox();
      this.btnDetermineMagicDate = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(65, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Enter Month";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 39);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(54, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Enter Day";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 69);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(57, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Enter Year";
      // 
      // txtDay
      // 
      this.txtDay.Location = new System.Drawing.Point(95, 36);
      this.txtDay.Name = "txtDay";
      this.txtDay.Size = new System.Drawing.Size(100, 20);
      this.txtDay.TabIndex = 1;
      // 
      // txtMonth
      // 
      this.txtMonth.Location = new System.Drawing.Point(95, 6);
      this.txtMonth.Name = "txtMonth";
      this.txtMonth.Size = new System.Drawing.Size(100, 20);
      this.txtMonth.TabIndex = 0;
      // 
      // txtYear
      // 
      this.txtYear.Location = new System.Drawing.Point(95, 66);
      this.txtYear.Mask = "00";
      this.txtYear.Name = "txtYear";
      this.txtYear.Size = new System.Drawing.Size(33, 20);
      this.txtYear.TabIndex = 2;
      // 
      // btnDetermineMagicDate
      // 
      this.btnDetermineMagicDate.Location = new System.Drawing.Point(95, 101);
      this.btnDetermineMagicDate.Name = "btnDetermineMagicDate";
      this.btnDetermineMagicDate.Size = new System.Drawing.Size(100, 40);
      this.btnDetermineMagicDate.TabIndex = 3;
      this.btnDetermineMagicDate.Text = "Determine Magic Date";
      this.btnDetermineMagicDate.UseVisualStyleBackColor = true;
      this.btnDetermineMagicDate.Click += new System.EventHandler(this.btnDetermineMagicDate_Click);
      // 
      // frmMagicDates
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(233, 162);
      this.Controls.Add(this.btnDetermineMagicDate);
      this.Controls.Add(this.txtYear);
      this.Controls.Add(this.txtMonth);
      this.Controls.Add(this.txtDay);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "frmMagicDates";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Magic Dates";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtDay;
    private System.Windows.Forms.TextBox txtMonth;
    private System.Windows.Forms.MaskedTextBox txtYear;
    private System.Windows.Forms.Button btnDetermineMagicDate;
  }
}

