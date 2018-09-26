namespace Gaddis_06_07_PresentValue
{
    partial class frmPresentValue
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
      this.txtFutureValue = new System.Windows.Forms.TextBox();
      this.txtInterestRate = new System.Windows.Forms.TextBox();
      this.txtYears = new System.Windows.Forms.TextBox();
      this.txtPresentValue = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.btnCalculate = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(59, 21);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(67, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Future Value";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(58, 47);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(68, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Interest Rate";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(38, 73);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(88, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Number Of Years";
      // 
      // txtFutureValue
      // 
      this.txtFutureValue.Location = new System.Drawing.Point(132, 18);
      this.txtFutureValue.Name = "txtFutureValue";
      this.txtFutureValue.Size = new System.Drawing.Size(100, 20);
      this.txtFutureValue.TabIndex = 0;
      // 
      // txtInterestRate
      // 
      this.txtInterestRate.Location = new System.Drawing.Point(132, 44);
      this.txtInterestRate.Name = "txtInterestRate";
      this.txtInterestRate.Size = new System.Drawing.Size(100, 20);
      this.txtInterestRate.TabIndex = 1;
      // 
      // txtYears
      // 
      this.txtYears.Location = new System.Drawing.Point(132, 70);
      this.txtYears.Name = "txtYears";
      this.txtYears.Size = new System.Drawing.Size(100, 20);
      this.txtYears.TabIndex = 2;
      // 
      // txtPresentValue
      // 
      this.txtPresentValue.Location = new System.Drawing.Point(132, 170);
      this.txtPresentValue.Name = "txtPresentValue";
      this.txtPresentValue.ReadOnly = true;
      this.txtPresentValue.Size = new System.Drawing.Size(100, 20);
      this.txtPresentValue.TabIndex = 6;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(53, 173);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(73, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Present Value";
      // 
      // btnCalculate
      // 
      this.btnCalculate.Location = new System.Drawing.Point(132, 96);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(100, 37);
      this.btnCalculate.TabIndex = 3;
      this.btnCalculate.Text = "Calculate Present Value";
      this.btnCalculate.UseVisualStyleBackColor = true;
      this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
      // 
      // frmPresentValue
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 212);
      this.Controls.Add(this.btnCalculate);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtPresentValue);
      this.Controls.Add(this.txtYears);
      this.Controls.Add(this.txtInterestRate);
      this.Controls.Add(this.txtFutureValue);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "frmPresentValue";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Present Value";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFutureValue;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.TextBox txtPresentValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalculate;
    }
}

