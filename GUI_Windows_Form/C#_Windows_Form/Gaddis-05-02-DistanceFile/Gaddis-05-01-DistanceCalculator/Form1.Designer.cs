namespace Gaddis_05_01_DistanceCalculator
{
  partial class frmDistanceCalculator
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
      this.txtSpeed = new System.Windows.Forms.TextBox();
      this.txtHours = new System.Windows.Forms.TextBox();
      this.btnCalculate = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(154, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Vehicle Speed (Miles Per Hour)";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(86, 63);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(80, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Hours Traveled";
      // 
      // txtSpeed
      // 
      this.txtSpeed.Location = new System.Drawing.Point(172, 20);
      this.txtSpeed.Name = "txtSpeed";
      this.txtSpeed.Size = new System.Drawing.Size(100, 20);
      this.txtSpeed.TabIndex = 2;
      // 
      // txtHours
      // 
      this.txtHours.Location = new System.Drawing.Point(172, 60);
      this.txtHours.Name = "txtHours";
      this.txtHours.Size = new System.Drawing.Size(100, 20);
      this.txtHours.TabIndex = 3;
      // 
      // btnCalculate
      // 
      this.btnCalculate.Location = new System.Drawing.Point(197, 100);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(75, 23);
      this.btnCalculate.TabIndex = 4;
      this.btnCalculate.Text = "Calculate";
      this.btnCalculate.UseVisualStyleBackColor = true;
      this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
      // 
      // frmDistanceCalculator
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 149);
      this.Controls.Add(this.btnCalculate);
      this.Controls.Add(this.txtHours);
      this.Controls.Add(this.txtSpeed);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "frmDistanceCalculator";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Distance Calculator";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtSpeed;
    private System.Windows.Forms.TextBox txtHours;
    private System.Windows.Forms.Button btnCalculate;
  }
}

