namespace Gaddis_06_04_CaloriesFromFatCarbs
{
    partial class Form1
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
      this.txtFat = new System.Windows.Forms.TextBox();
      this.txtCarbs = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnCalculate = new System.Windows.Forms.Button();
      this.lstOutput = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // txtFat
      // 
      this.txtFat.Location = new System.Drawing.Point(157, 12);
      this.txtFat.Name = "txtFat";
      this.txtFat.Size = new System.Drawing.Size(100, 20);
      this.txtFat.TabIndex = 0;
      // 
      // txtCarbs
      // 
      this.txtCarbs.Location = new System.Drawing.Point(157, 49);
      this.txtCarbs.Name = "txtCarbs";
      this.txtCarbs.Size = new System.Drawing.Size(100, 20);
      this.txtCarbs.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(82, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(69, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Grams Of Fat";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(29, 52);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(122, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Grams Of Carbohydrates";
      // 
      // btnCalculate
      // 
      this.btnCalculate.Location = new System.Drawing.Point(182, 85);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(75, 23);
      this.btnCalculate.TabIndex = 4;
      this.btnCalculate.Text = "Calculate";
      this.btnCalculate.UseVisualStyleBackColor = true;
      this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
      // 
      // lstOutput
      // 
      this.lstOutput.FormattingEnabled = true;
      this.lstOutput.Location = new System.Drawing.Point(15, 137);
      this.lstOutput.Name = "lstOutput";
      this.lstOutput.Size = new System.Drawing.Size(242, 95);
      this.lstOutput.TabIndex = 5;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(276, 262);
      this.Controls.Add(this.lstOutput);
      this.Controls.Add(this.btnCalculate);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtCarbs);
      this.Controls.Add(this.txtFat);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Calories from Fat and Carbs";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFat;
        private System.Windows.Forms.TextBox txtCarbs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox lstOutput;
    }
}

