namespace Gaddist_06_01_RetailPriceCalculator
{
    partial class frmRetailPriceCalculator
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtWholesaleCost = new System.Windows.Forms.TextBox();
      this.txtMarkupPercent = new System.Windows.Forms.TextBox();
      this.txtRetailPrice = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnCalculate
      // 
      this.btnCalculate.Location = new System.Drawing.Point(148, 108);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(100, 35);
      this.btnCalculate.TabIndex = 0;
      this.btnCalculate.Text = "Calculate Retail Price";
      this.btnCalculate.UseVisualStyleBackColor = true;
      this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 27);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(109, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Enter Wholesale Cost";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 74);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(129, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Enter Markup Percentage";
      // 
      // txtWholesaleCost
      // 
      this.txtWholesaleCost.Location = new System.Drawing.Point(148, 24);
      this.txtWholesaleCost.Name = "txtWholesaleCost";
      this.txtWholesaleCost.Size = new System.Drawing.Size(100, 20);
      this.txtWholesaleCost.TabIndex = 3;
      // 
      // txtMarkupPercent
      // 
      this.txtMarkupPercent.Location = new System.Drawing.Point(148, 71);
      this.txtMarkupPercent.Name = "txtMarkupPercent";
      this.txtMarkupPercent.Size = new System.Drawing.Size(100, 20);
      this.txtMarkupPercent.TabIndex = 4;
      // 
      // txtRetailPrice
      // 
      this.txtRetailPrice.Location = new System.Drawing.Point(148, 167);
      this.txtRetailPrice.Name = "txtRetailPrice";
      this.txtRetailPrice.ReadOnly = true;
      this.txtRetailPrice.Size = new System.Drawing.Size(100, 20);
      this.txtRetailPrice.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(80, 170);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(61, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Retail Price";
      // 
      // frmRetailPriceCalculator
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(266, 209);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtRetailPrice);
      this.Controls.Add(this.txtMarkupPercent);
      this.Controls.Add(this.txtWholesaleCost);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnCalculate);
      this.Name = "frmRetailPriceCalculator";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Retail Price Calculator";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWholesaleCost;
        private System.Windows.Forms.TextBox txtMarkupPercent;
        private System.Windows.Forms.TextBox txtRetailPrice;
        private System.Windows.Forms.Label label3;
    }
}

