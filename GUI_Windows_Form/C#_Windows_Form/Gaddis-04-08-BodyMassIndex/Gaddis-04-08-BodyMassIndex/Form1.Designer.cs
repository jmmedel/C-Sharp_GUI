namespace Gaddis_04_08_BodyMassIndex
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
      this.label3 = new System.Windows.Forms.Label();
      this.txtBMI = new System.Windows.Forms.TextBox();
      this.btnCalculate = new System.Windows.Forms.Button();
      this.txtHeight = new System.Windows.Forms.TextBox();
      this.txtWeight = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.txtBodyType = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(116, 156);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(26, 13);
      this.label3.TabIndex = 13;
      this.label3.Text = "BMI";
      // 
      // txtBMI
      // 
      this.txtBMI.Location = new System.Drawing.Point(148, 153);
      this.txtBMI.Name = "txtBMI";
      this.txtBMI.ReadOnly = true;
      this.txtBMI.Size = new System.Drawing.Size(100, 20);
      this.txtBMI.TabIndex = 12;
      // 
      // btnCalculate
      // 
      this.btnCalculate.Location = new System.Drawing.Point(88, 101);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(120, 32);
      this.btnCalculate.TabIndex = 11;
      this.btnCalculate.Text = "Calculate";
      this.btnCalculate.UseVisualStyleBackColor = true;
      this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
      // 
      // txtHeight
      // 
      this.txtHeight.Location = new System.Drawing.Point(148, 64);
      this.txtHeight.Name = "txtHeight";
      this.txtHeight.Size = new System.Drawing.Size(100, 20);
      this.txtHeight.TabIndex = 10;
      // 
      // txtWeight
      // 
      this.txtWeight.Location = new System.Drawing.Point(148, 12);
      this.txtWeight.Name = "txtWeight";
      this.txtWeight.Size = new System.Drawing.Size(100, 20);
      this.txtWeight.TabIndex = 9;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(23, 15);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(126, 13);
      this.label2.TabIndex = 8;
      this.label2.Text = "Enter Weight (In Pounds)";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(23, 67);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(119, 13);
      this.label1.TabIndex = 7;
      this.label1.Text = "Enter Height (In Inches)";
      // 
      // txtBodyType
      // 
      this.txtBodyType.Location = new System.Drawing.Point(148, 191);
      this.txtBodyType.Name = "txtBodyType";
      this.txtBodyType.ReadOnly = true;
      this.txtBodyType.Size = new System.Drawing.Size(100, 20);
      this.txtBodyType.TabIndex = 14;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(84, 194);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(58, 13);
      this.label4.TabIndex = 15;
      this.label4.Text = "Body Type";
      // 
      // frmBMI
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 238);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtBodyType);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtBMI);
      this.Controls.Add(this.btnCalculate);
      this.Controls.Add(this.txtHeight);
      this.Controls.Add(this.txtWeight);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "frmBMI";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Body Mass Index";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtBMI;
    private System.Windows.Forms.Button btnCalculate;
    private System.Windows.Forms.TextBox txtHeight;
    private System.Windows.Forms.TextBox txtWeight;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtBodyType;
    private System.Windows.Forms.Label label4;
  }
}

