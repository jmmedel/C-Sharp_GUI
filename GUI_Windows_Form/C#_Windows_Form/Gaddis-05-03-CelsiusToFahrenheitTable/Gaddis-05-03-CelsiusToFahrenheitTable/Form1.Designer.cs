namespace Gaddis_05_03_CelsiusToFahrenheitTable
{
  partial class frmCelsiusToFahrenheitTable
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
      this.btnCreateTable = new System.Windows.Forms.Button();
      this.lstTable = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // btnCreateTable
      // 
      this.btnCreateTable.Location = new System.Drawing.Point(178, 305);
      this.btnCreateTable.Name = "btnCreateTable";
      this.btnCreateTable.Size = new System.Drawing.Size(86, 23);
      this.btnCreateTable.TabIndex = 0;
      this.btnCreateTable.Text = "Create Table";
      this.btnCreateTable.UseVisualStyleBackColor = true;
      this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
      // 
      // lstTable
      // 
      this.lstTable.FormattingEnabled = true;
      this.lstTable.Location = new System.Drawing.Point(12, 12);
      this.lstTable.Name = "lstTable";
      this.lstTable.Size = new System.Drawing.Size(377, 277);
      this.lstTable.TabIndex = 1;
      // 
      // frmCelsiusToFahrenheitTable
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(401, 340);
      this.Controls.Add(this.lstTable);
      this.Controls.Add(this.btnCreateTable);
      this.Name = "frmCelsiusToFahrenheitTable";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Celsius To Fahrenheit Table";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnCreateTable;
    private System.Windows.Forms.ListBox lstTable;
  }
}

