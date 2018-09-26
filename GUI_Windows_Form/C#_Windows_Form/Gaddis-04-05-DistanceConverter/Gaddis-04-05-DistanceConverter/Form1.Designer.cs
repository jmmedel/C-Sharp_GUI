namespace Gaddis_04_05_DistanceConverter
{
  partial class frmDistanceConverter
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
      this.lstConvertFrom = new System.Windows.Forms.ListBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.lstConvertTo = new System.Windows.Forms.ListBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtDistanceInput = new System.Windows.Forms.TextBox();
      this.txtDinstanceOutput = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.btnConvert = new System.Windows.Forms.Button();
      this.btnExit = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // lstConvertFrom
      // 
      this.lstConvertFrom.FormattingEnabled = true;
      this.lstConvertFrom.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
      this.lstConvertFrom.Location = new System.Drawing.Point(18, 19);
      this.lstConvertFrom.Name = "lstConvertFrom";
      this.lstConvertFrom.Size = new System.Drawing.Size(120, 43);
      this.lstConvertFrom.TabIndex = 0;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.lstConvertFrom);
      this.groupBox1.Location = new System.Drawing.Point(12, 78);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(149, 75);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "From";
      // 
      // lstConvertTo
      // 
      this.lstConvertTo.FormattingEnabled = true;
      this.lstConvertTo.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
      this.lstConvertTo.Location = new System.Drawing.Point(191, 94);
      this.lstConvertTo.Name = "lstConvertTo";
      this.lstConvertTo.Size = new System.Drawing.Size(120, 43);
      this.lstConvertTo.TabIndex = 1;
      // 
      // groupBox2
      // 
      this.groupBox2.Location = new System.Drawing.Point(178, 78);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(148, 75);
      this.groupBox2.TabIndex = 3;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "To";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(15, 34);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(135, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Enter a distance to convert";
      // 
      // txtDistanceInput
      // 
      this.txtDistanceInput.Location = new System.Drawing.Point(178, 31);
      this.txtDistanceInput.Name = "txtDistanceInput";
      this.txtDistanceInput.Size = new System.Drawing.Size(146, 20);
      this.txtDistanceInput.TabIndex = 5;
      // 
      // txtDinstanceOutput
      // 
      this.txtDinstanceOutput.Location = new System.Drawing.Point(178, 174);
      this.txtDinstanceOutput.Name = "txtDinstanceOutput";
      this.txtDinstanceOutput.ReadOnly = true;
      this.txtDinstanceOutput.Size = new System.Drawing.Size(146, 20);
      this.txtDinstanceOutput.TabIndex = 7;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(49, 177);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(101, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Converted Distance";
      // 
      // btnConvert
      // 
      this.btnConvert.Location = new System.Drawing.Point(86, 216);
      this.btnConvert.Name = "btnConvert";
      this.btnConvert.Size = new System.Drawing.Size(75, 23);
      this.btnConvert.TabIndex = 8;
      this.btnConvert.Text = "Convert";
      this.btnConvert.UseVisualStyleBackColor = true;
      this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
      // 
      // btnExit
      // 
      this.btnExit.Location = new System.Drawing.Point(191, 216);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(75, 23);
      this.btnExit.TabIndex = 9;
      this.btnExit.Text = "Exit";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // frmDistanceConverter
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(336, 261);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.btnConvert);
      this.Controls.Add(this.txtDinstanceOutput);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtDistanceInput);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lstConvertTo);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.groupBox2);
      this.Name = "frmDistanceConverter";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Distance Converter";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox lstConvertFrom;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ListBox lstConvertTo;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtDistanceInput;
    private System.Windows.Forms.TextBox txtDinstanceOutput;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnConvert;
    private System.Windows.Forms.Button btnExit;
  }
}

