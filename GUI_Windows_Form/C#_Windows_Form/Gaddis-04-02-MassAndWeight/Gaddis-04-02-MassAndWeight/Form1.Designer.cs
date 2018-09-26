namespace Gaddis_04_02_MassAndWeight
{
  partial class frmMassAndWeight
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
      this.txtMass = new System.Windows.Forms.TextBox();
      this.txtWeight = new System.Windows.Forms.TextBox();
      this.btnCalculate = new System.Windows.Forms.Button();
      this.lblWarning = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 30);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(101, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Enter Object\'s Mass";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 125);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(82, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Object\'s Weight";
      // 
      // txtMass
      // 
      this.txtMass.Location = new System.Drawing.Point(119, 27);
      this.txtMass.Name = "txtMass";
      this.txtMass.Size = new System.Drawing.Size(100, 20);
      this.txtMass.TabIndex = 2;
      // 
      // txtWeight
      // 
      this.txtWeight.Location = new System.Drawing.Point(119, 122);
      this.txtWeight.Name = "txtWeight";
      this.txtWeight.Size = new System.Drawing.Size(100, 20);
      this.txtWeight.TabIndex = 3;
      // 
      // btnCalculate
      // 
      this.btnCalculate.Location = new System.Drawing.Point(119, 65);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(100, 26);
      this.btnCalculate.TabIndex = 4;
      this.btnCalculate.Text = "Calculate Weight";
      this.btnCalculate.UseVisualStyleBackColor = true;
      this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
      // 
      // lblWarning
      // 
      this.lblWarning.AutoSize = true;
      this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblWarning.ForeColor = System.Drawing.Color.Red;
      this.lblWarning.Location = new System.Drawing.Point(12, 160);
      this.lblWarning.Name = "lblWarning";
      this.lblWarning.Size = new System.Drawing.Size(0, 16);
      this.lblWarning.TabIndex = 5;
      // 
      // frmMassAndWeight
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(255, 196);
      this.Controls.Add(this.lblWarning);
      this.Controls.Add(this.btnCalculate);
      this.Controls.Add(this.txtWeight);
      this.Controls.Add(this.txtMass);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "frmMassAndWeight";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Mass And Weight";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtMass;
    private System.Windows.Forms.TextBox txtWeight;
    private System.Windows.Forms.Button btnCalculate;
    private System.Windows.Forms.Label lblWarning;
  }
}

