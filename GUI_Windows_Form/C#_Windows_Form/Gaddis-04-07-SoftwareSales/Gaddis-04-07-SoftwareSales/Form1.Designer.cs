namespace Gaddis_04_07_SoftwareSales
{
  partial class frmSoftwareSales
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
      this.btnCalculate = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.txtNumOfPurchasedPackages = new System.Windows.Forms.TextBox();
      this.lstOutput = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // btnCalculate
      // 
      this.btnCalculate.Location = new System.Drawing.Point(181, 50);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(100, 39);
      this.btnCalculate.TabIndex = 0;
      this.btnCalculate.Text = "Calculate Discount";
      this.btnCalculate.UseVisualStyleBackColor = true;
      this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 27);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(163, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Number Of Purchased Packages";
      // 
      // txtNumOfPurchasedPackages
      // 
      this.txtNumOfPurchasedPackages.Location = new System.Drawing.Point(181, 24);
      this.txtNumOfPurchasedPackages.Name = "txtNumOfPurchasedPackages";
      this.txtNumOfPurchasedPackages.Size = new System.Drawing.Size(100, 20);
      this.txtNumOfPurchasedPackages.TabIndex = 4;
      // 
      // lstOutput
      // 
      this.lstOutput.FormattingEnabled = true;
      this.lstOutput.Location = new System.Drawing.Point(15, 105);
      this.lstOutput.Name = "lstOutput";
      this.lstOutput.Size = new System.Drawing.Size(257, 95);
      this.lstOutput.TabIndex = 5;
      // 
      // frmSoftwareSales
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(296, 217);
      this.Controls.Add(this.lstOutput);
      this.Controls.Add(this.txtNumOfPurchasedPackages);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.btnCalculate);
      this.Name = "frmSoftwareSales";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Software Sales";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnCalculate;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtNumOfPurchasedPackages;
    private System.Windows.Forms.ListBox lstOutput;
  }
}

