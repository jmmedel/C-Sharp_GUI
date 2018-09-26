namespace Gaddis_03_11_AutomibileCost
{
  partial class frmAutomobileCost
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
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.txtLoanPayment = new System.Windows.Forms.TextBox();
      this.txtInsurance = new System.Windows.Forms.TextBox();
      this.txtGas = new System.Windows.Forms.TextBox();
      this.txtOil = new System.Windows.Forms.TextBox();
      this.txtTires = new System.Windows.Forms.TextBox();
      this.txtMaintenance = new System.Windows.Forms.TextBox();
      this.btnCalculate = new System.Windows.Forms.Button();
      this.lstOutput = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(11, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(75, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Loan Payment";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(32, 41);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(54, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Insurance";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(54, 67);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(26, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Gas";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(61, 93);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(19, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "Oil";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(56, 120);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(30, 13);
      this.label5.TabIndex = 4;
      this.label5.Text = "Tires";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(17, 147);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(69, 13);
      this.label6.TabIndex = 5;
      this.label6.Text = "Maintenance";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtLoanPayment
      // 
      this.txtLoanPayment.Location = new System.Drawing.Point(103, 12);
      this.txtLoanPayment.Name = "txtLoanPayment";
      this.txtLoanPayment.Size = new System.Drawing.Size(100, 20);
      this.txtLoanPayment.TabIndex = 0;
      // 
      // txtInsurance
      // 
      this.txtInsurance.Location = new System.Drawing.Point(103, 38);
      this.txtInsurance.Name = "txtInsurance";
      this.txtInsurance.Size = new System.Drawing.Size(100, 20);
      this.txtInsurance.TabIndex = 1;
      // 
      // txtGas
      // 
      this.txtGas.Location = new System.Drawing.Point(103, 64);
      this.txtGas.Name = "txtGas";
      this.txtGas.Size = new System.Drawing.Size(100, 20);
      this.txtGas.TabIndex = 2;
      // 
      // txtOil
      // 
      this.txtOil.Location = new System.Drawing.Point(103, 90);
      this.txtOil.Name = "txtOil";
      this.txtOil.Size = new System.Drawing.Size(100, 20);
      this.txtOil.TabIndex = 3;
      // 
      // txtTires
      // 
      this.txtTires.Location = new System.Drawing.Point(103, 117);
      this.txtTires.Name = "txtTires";
      this.txtTires.Size = new System.Drawing.Size(100, 20);
      this.txtTires.TabIndex = 4;
      // 
      // txtMaintenance
      // 
      this.txtMaintenance.Location = new System.Drawing.Point(103, 144);
      this.txtMaintenance.Name = "txtMaintenance";
      this.txtMaintenance.Size = new System.Drawing.Size(100, 20);
      this.txtMaintenance.TabIndex = 5;
      // 
      // btnCalculate
      // 
      this.btnCalculate.Location = new System.Drawing.Point(103, 170);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(100, 37);
      this.btnCalculate.TabIndex = 6;
      this.btnCalculate.Text = "Calculate Expenses";
      this.btnCalculate.UseVisualStyleBackColor = true;
      this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
      // 
      // lstOutput
      // 
      this.lstOutput.FormattingEnabled = true;
      this.lstOutput.Location = new System.Drawing.Point(20, 223);
      this.lstOutput.Name = "lstOutput";
      this.lstOutput.Size = new System.Drawing.Size(183, 95);
      this.lstOutput.TabIndex = 7;
      // 
      // frmAutomobileCost
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(224, 323);
      this.Controls.Add(this.lstOutput);
      this.Controls.Add(this.btnCalculate);
      this.Controls.Add(this.txtMaintenance);
      this.Controls.Add(this.txtTires);
      this.Controls.Add(this.txtOil);
      this.Controls.Add(this.txtGas);
      this.Controls.Add(this.txtInsurance);
      this.Controls.Add(this.txtLoanPayment);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "frmAutomobileCost";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Automibile Cost";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtLoanPayment;
    private System.Windows.Forms.TextBox txtInsurance;
    private System.Windows.Forms.TextBox txtGas;
    private System.Windows.Forms.TextBox txtOil;
    private System.Windows.Forms.TextBox txtTires;
    private System.Windows.Forms.TextBox txtMaintenance;
    private System.Windows.Forms.Button btnCalculate;
    private System.Windows.Forms.ListBox lstOutput;
  }
}

