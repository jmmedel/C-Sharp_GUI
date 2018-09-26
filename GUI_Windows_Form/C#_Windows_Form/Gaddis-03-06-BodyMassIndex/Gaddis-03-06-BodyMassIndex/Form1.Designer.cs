namespace Gaddis_03_06_BodyMassIndex
{
  partial class frmBMI
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
      this.txtWeight = new System.Windows.Forms.TextBox();
      this.txtHeight = new System.Windows.Forms.TextBox();
      this.btnCalculate = new System.Windows.Forms.Button();
      this.txtBMI = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 72);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(119, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Enter Height (In Inches)";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 20);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(126, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Enter Weight (In Pounds)";
      // 
      // txtWeight
      // 
      this.txtWeight.Location = new System.Drawing.Point(137, 17);
      this.txtWeight.Name = "txtWeight";
      this.txtWeight.Size = new System.Drawing.Size(100, 20);
      this.txtWeight.TabIndex = 2;
      // 
      // txtHeight
      // 
      this.txtHeight.Location = new System.Drawing.Point(137, 69);
      this.txtHeight.Name = "txtHeight";
      this.txtHeight.Size = new System.Drawing.Size(100, 20);
      this.txtHeight.TabIndex = 3;
      // 
      // btnCalculate
      // 
      this.btnCalculate.Location = new System.Drawing.Point(77, 106);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(120, 32);
      this.btnCalculate.TabIndex = 4;
      this.btnCalculate.Text = "Calculate";
      this.btnCalculate.UseVisualStyleBackColor = true;
      this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
      // 
      // txtBMI
      // 
      this.txtBMI.Location = new System.Drawing.Point(137, 158);
      this.txtBMI.Name = "txtBMI";
      this.txtBMI.ReadOnly = true;
      this.txtBMI.Size = new System.Drawing.Size(100, 20);
      this.txtBMI.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(105, 161);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(26, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "BMI";
      // 
      // frmBMI
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(259, 199);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtBMI);
      this.Controls.Add(this.btnCalculate);
      this.Controls.Add(this.txtHeight);
      this.Controls.Add(this.txtWeight);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "frmBMI";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Body Max Index Calculator";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtWeight;
    private System.Windows.Forms.TextBox txtHeight;
    private System.Windows.Forms.Button btnCalculate;
    private System.Windows.Forms.TextBox txtBMI;
    private System.Windows.Forms.Label label3;
  }
}

