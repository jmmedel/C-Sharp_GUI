namespace Gaddis_03_04_SalesTaxTotal
{
  partial class frmSalesTax
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
      this.label1 = new System.Windows.Forms.Label();
      this.txtSalesAmount = new System.Windows.Forms.TextBox();
      this.btnCalculate = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lstOutput
      // 
      this.lstOutput.FormattingEnabled = true;
      this.lstOutput.Location = new System.Drawing.Point(12, 100);
      this.lstOutput.Name = "lstOutput";
      this.lstOutput.Size = new System.Drawing.Size(206, 95);
      this.lstOutput.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Enter Sales Amount";
      // 
      // txtSalesAmount
      // 
      this.txtSalesAmount.Location = new System.Drawing.Point(118, 19);
      this.txtSalesAmount.Name = "txtSalesAmount";
      this.txtSalesAmount.Size = new System.Drawing.Size(100, 20);
      this.txtSalesAmount.TabIndex = 2;
      // 
      // btnCalculate
      // 
      this.btnCalculate.Location = new System.Drawing.Point(129, 55);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(89, 30);
      this.btnCalculate.TabIndex = 3;
      this.btnCalculate.Text = "Calculate";
      this.btnCalculate.UseVisualStyleBackColor = true;
      this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
      // 
      // frmSalesTax
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(234, 206);
      this.Controls.Add(this.btnCalculate);
      this.Controls.Add(this.txtSalesAmount);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lstOutput);
      this.Name = "frmSalesTax";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Sales Tax";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox lstOutput;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtSalesAmount;
    private System.Windows.Forms.Button btnCalculate;
  }
}

