namespace Gaddis_09_07_EmailAddressBook
{
  partial class frmInputData
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
      this.lstData = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // lstData
      // 
      this.lstData.FormattingEnabled = true;
      this.lstData.Location = new System.Drawing.Point(12, 12);
      this.lstData.Name = "lstData";
      this.lstData.Size = new System.Drawing.Size(260, 225);
      this.lstData.TabIndex = 1;
      this.lstData.SelectedIndexChanged += new System.EventHandler(this.lstData_SelectedIndexChanged);
      // 
      // frmInputData
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.lstData);
      this.Name = "frmInputData";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Input Data";
      this.Load += new System.EventHandler(this.frmInputData_Load);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.ListBox lstData;
  }
}

