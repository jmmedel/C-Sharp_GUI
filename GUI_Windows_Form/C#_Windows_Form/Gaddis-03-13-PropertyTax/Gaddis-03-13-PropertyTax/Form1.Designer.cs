namespace Gaddis_03_13_PropertyTax
{
  partial class frmPropertyTax
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
      this.btnCalculateTax = new System.Windows.Forms.Button();
      this.txtPropertyValue = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtPropertyTax = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnCalculateTax
      // 
      this.btnCalculateTax.Location = new System.Drawing.Point(130, 49);
      this.btnCalculateTax.Name = "btnCalculateTax";
      this.btnCalculateTax.Size = new System.Drawing.Size(75, 38);
      this.btnCalculateTax.TabIndex = 0;
      this.btnCalculateTax.Text = "Calculate Tax";
      this.btnCalculateTax.UseVisualStyleBackColor = true;
      this.btnCalculateTax.Click += new System.EventHandler(this.btnCalculateTax_Click);
      // 
      // txtPropertyValue
      // 
      this.txtPropertyValue.Location = new System.Drawing.Point(105, 12);
      this.txtPropertyValue.Name = "txtPropertyValue";
      this.txtPropertyValue.Size = new System.Drawing.Size(100, 20);
      this.txtPropertyValue.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(23, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(76, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Property Value";
      // 
      // txtPropertyTax
      // 
      this.txtPropertyTax.Location = new System.Drawing.Point(105, 114);
      this.txtPropertyTax.Name = "txtPropertyTax";
      this.txtPropertyTax.ReadOnly = true;
      this.txtPropertyTax.Size = new System.Drawing.Size(100, 20);
      this.txtPropertyTax.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(32, 117);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(67, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Property Tax";
      // 
      // frmPropertyTax
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(249, 152);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtPropertyTax);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtPropertyValue);
      this.Controls.Add(this.btnCalculateTax);
      this.Name = "frmPropertyTax";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Property Tax";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnCalculateTax;
    private System.Windows.Forms.TextBox txtPropertyValue;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtPropertyTax;
    private System.Windows.Forms.Label label2;
  }
}

