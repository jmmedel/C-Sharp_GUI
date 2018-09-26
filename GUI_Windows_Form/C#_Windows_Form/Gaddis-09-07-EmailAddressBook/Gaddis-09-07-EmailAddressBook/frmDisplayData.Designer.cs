namespace Gaddis_09_07_EmailAddressBook
{
  partial class frmDisplayData
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
      this.lstOutput = new System.Windows.Forms.ListBox();
      this.btnReturn = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lstOutput
      // 
      this.lstOutput.Location = new System.Drawing.Point(12, 12);
      this.lstOutput.Name = "lstOutput";
      this.lstOutput.SelectionMode = System.Windows.Forms.SelectionMode.None;
      this.lstOutput.Size = new System.Drawing.Size(260, 173);
      this.lstOutput.TabIndex = 0;
      this.lstOutput.TabStop = false;
      // 
      // btnReturn
      // 
      this.btnReturn.Location = new System.Drawing.Point(96, 204);
      this.btnReturn.Name = "btnReturn";
      this.btnReturn.Size = new System.Drawing.Size(75, 45);
      this.btnReturn.TabIndex = 1;
      this.btnReturn.Text = "Return to Main Form";
      this.btnReturn.UseVisualStyleBackColor = true;
      this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
      // 
      // frmDisplayData
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.btnReturn);
      this.Controls.Add(this.lstOutput);
      this.Name = "frmDisplayData";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Email and Address Book";
      this.Load += new System.EventHandler(this.frmDisplayData_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListBox lstOutput;
    private System.Windows.Forms.Button btnReturn;
  }
}