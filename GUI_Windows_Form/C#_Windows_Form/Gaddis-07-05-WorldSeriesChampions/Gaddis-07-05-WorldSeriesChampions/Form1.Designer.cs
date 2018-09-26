namespace Gaddis_07_05_WorldSeriesChampions
{
  partial class frmWorldSeriesChampions
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
      this.btnDisplayChampions = new System.Windows.Forms.Button();
      this.lstChampions = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // btnDisplayChampions
      // 
      this.btnDisplayChampions.Location = new System.Drawing.Point(89, 12);
      this.btnDisplayChampions.Name = "btnDisplayChampions";
      this.btnDisplayChampions.Size = new System.Drawing.Size(115, 23);
      this.btnDisplayChampions.TabIndex = 0;
      this.btnDisplayChampions.Text = "Display Champions";
      this.btnDisplayChampions.UseVisualStyleBackColor = true;
      this.btnDisplayChampions.Click += new System.EventHandler(this.btnDisplayChampions_Click);
      // 
      // lstChampions
      // 
      this.lstChampions.FormattingEnabled = true;
      this.lstChampions.Location = new System.Drawing.Point(12, 41);
      this.lstChampions.Name = "lstChampions";
      this.lstChampions.Size = new System.Drawing.Size(260, 381);
      this.lstChampions.TabIndex = 1;
      this.lstChampions.SelectedIndexChanged += new System.EventHandler(this.lstChampions_SelectedIndexChanged);
      // 
      // frmWorldSeriesChampions
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 434);
      this.Controls.Add(this.lstChampions);
      this.Controls.Add(this.btnDisplayChampions);
      this.Name = "frmWorldSeriesChampions";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "World Series Champions";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnDisplayChampions;
    private System.Windows.Forms.ListBox lstChampions;
  }
}

