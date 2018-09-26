namespace Gaddis_06_08_PrimeNumbers
{
    partial class frmPrimeNumbers
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
      this.btnIsPrime = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtNumber = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // btnIsPrime
      // 
      this.btnIsPrime.Location = new System.Drawing.Point(105, 60);
      this.btnIsPrime.Name = "btnIsPrime";
      this.btnIsPrime.Size = new System.Drawing.Size(104, 23);
      this.btnIsPrime.TabIndex = 1;
      this.btnIsPrime.Text = "Is Prime Number?";
      this.btnIsPrime.UseVisualStyleBackColor = true;
      this.btnIsPrime.Click += new System.EventHandler(this.btnIsPrime_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(20, 28);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(79, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Enter a number";
      // 
      // txtNumber
      // 
      this.txtNumber.Location = new System.Drawing.Point(105, 25);
      this.txtNumber.Name = "txtNumber";
      this.txtNumber.Size = new System.Drawing.Size(100, 20);
      this.txtNumber.TabIndex = 0;
      // 
      // frmPrimeNumbers
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(237, 107);
      this.Controls.Add(this.txtNumber);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnIsPrime);
      this.Name = "frmPrimeNumbers";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Prime Numbers";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIsPrime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumber;
    }
}

