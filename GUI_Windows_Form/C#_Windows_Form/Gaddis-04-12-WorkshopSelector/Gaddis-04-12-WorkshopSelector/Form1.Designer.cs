namespace Gaddis_04_12_WorkshopSelector
{
  partial class frmWorkshopSelector
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.lstWorkshop = new System.Windows.Forms.ListBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.lstLocation = new System.Windows.Forms.ListBox();
      this.btnCalculateCost = new System.Windows.Forms.Button();
      this.lstOutput = new System.Windows.Forms.ListBox();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.lstWorkshop);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(167, 125);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Select Workshop";
      // 
      // lstWorkshop
      // 
      this.lstWorkshop.FormattingEnabled = true;
      this.lstWorkshop.Items.AddRange(new object[] {
            "Handling Stress",
            "Time Management",
            "Supervision Skills",
            "Negotiation",
            "How to Interview"});
      this.lstWorkshop.Location = new System.Drawing.Point(29, 19);
      this.lstWorkshop.Name = "lstWorkshop";
      this.lstWorkshop.Size = new System.Drawing.Size(120, 95);
      this.lstWorkshop.TabIndex = 0;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.lstLocation);
      this.groupBox2.Location = new System.Drawing.Point(213, 12);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(167, 125);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Select Location";
      // 
      // lstLocation
      // 
      this.lstLocation.FormattingEnabled = true;
      this.lstLocation.Items.AddRange(new object[] {
            "Austin",
            "Chicago",
            "Dallas",
            "Orlando",
            "Phoenix",
            "Raleigh"});
      this.lstLocation.Location = new System.Drawing.Point(29, 19);
      this.lstLocation.Name = "lstLocation";
      this.lstLocation.Size = new System.Drawing.Size(120, 95);
      this.lstLocation.TabIndex = 0;
      // 
      // btnCalculateCost
      // 
      this.btnCalculateCost.Location = new System.Drawing.Point(146, 143);
      this.btnCalculateCost.Name = "btnCalculateCost";
      this.btnCalculateCost.Size = new System.Drawing.Size(95, 23);
      this.btnCalculateCost.TabIndex = 3;
      this.btnCalculateCost.Text = "Calculate cost";
      this.btnCalculateCost.UseVisualStyleBackColor = true;
      this.btnCalculateCost.Click += new System.EventHandler(this.btnCalculateCost_Click);
      // 
      // lstOutput
      // 
      this.lstOutput.FormattingEnabled = true;
      this.lstOutput.Location = new System.Drawing.Point(12, 191);
      this.lstOutput.Name = "lstOutput";
      this.lstOutput.Size = new System.Drawing.Size(368, 56);
      this.lstOutput.TabIndex = 4;
      // 
      // frmWorkshopSelector
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(403, 263);
      this.Controls.Add(this.lstOutput);
      this.Controls.Add(this.btnCalculateCost);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "frmWorkshopSelector";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Workshop Selector";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ListBox lstWorkshop;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.ListBox lstLocation;
    private System.Windows.Forms.Button btnCalculateCost;
    private System.Windows.Forms.ListBox lstOutput;
  }
}

