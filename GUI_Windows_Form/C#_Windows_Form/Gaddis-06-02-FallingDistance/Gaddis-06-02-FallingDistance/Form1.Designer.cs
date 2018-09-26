namespace Gaddis_06_02_FallingDistance
{
    partial class frmFallingDistance
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
      this.txtTime = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtDistanceFallen = new System.Windows.Forms.TextBox();
      this.btnCalculate = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // txtTime
      // 
      this.txtTime.Location = new System.Drawing.Point(140, 21);
      this.txtTime.Name = "txtTime";
      this.txtTime.Size = new System.Drawing.Size(100, 20);
      this.txtTime.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(16, 24);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(118, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Enter Time (in seconds)";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(54, 121);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(80, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Distnace Fallen";
      // 
      // txtDistanceFallen
      // 
      this.txtDistanceFallen.Location = new System.Drawing.Point(140, 118);
      this.txtDistanceFallen.Name = "txtDistanceFallen";
      this.txtDistanceFallen.ReadOnly = true;
      this.txtDistanceFallen.Size = new System.Drawing.Size(100, 20);
      this.txtDistanceFallen.TabIndex = 3;
      // 
      // btnCalculate
      // 
      this.btnCalculate.Location = new System.Drawing.Point(140, 47);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(100, 46);
      this.btnCalculate.TabIndex = 4;
      this.btnCalculate.Text = "Calculate Distance";
      this.btnCalculate.UseVisualStyleBackColor = true;
      this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
      // 
      // frmFallingDistance
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(271, 160);
      this.Controls.Add(this.btnCalculate);
      this.Controls.Add(this.txtDistanceFallen);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtTime);
      this.Name = "frmFallingDistance";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Falling Distance";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDistanceFallen;
        private System.Windows.Forms.Button btnCalculate;
    }
}

