namespace Gaddis_04_09_ChangeForDollar
{
  partial class frmChangeForDollar
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
      this.txtPennies = new System.Windows.Forms.TextBox();
      this.txtNickles = new System.Windows.Forms.TextBox();
      this.txtDimes = new System.Windows.Forms.TextBox();
      this.txtQuarters = new System.Windows.Forms.TextBox();
      this.btnCalculate = new System.Windows.Forms.Button();
      this.txtOutput = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(16, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(73, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Enter Pennies";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(21, 44);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(70, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Enter Nickels";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(27, 73);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(64, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Enter Dimes";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(16, 97);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(75, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "Enter Quarters";
      // 
      // txtPennies
      // 
      this.txtPennies.Location = new System.Drawing.Point(106, 15);
      this.txtPennies.Name = "txtPennies";
      this.txtPennies.Size = new System.Drawing.Size(100, 20);
      this.txtPennies.TabIndex = 4;
      // 
      // txtNickles
      // 
      this.txtNickles.Location = new System.Drawing.Point(106, 41);
      this.txtNickles.Name = "txtNickles";
      this.txtNickles.Size = new System.Drawing.Size(100, 20);
      this.txtNickles.TabIndex = 5;
      // 
      // txtDimes
      // 
      this.txtDimes.Location = new System.Drawing.Point(106, 68);
      this.txtDimes.Name = "txtDimes";
      this.txtDimes.Size = new System.Drawing.Size(100, 20);
      this.txtDimes.TabIndex = 6;
      // 
      // txtQuarters
      // 
      this.txtQuarters.Location = new System.Drawing.Point(106, 94);
      this.txtQuarters.Name = "txtQuarters";
      this.txtQuarters.Size = new System.Drawing.Size(100, 20);
      this.txtQuarters.TabIndex = 7;
      // 
      // btnCalculate
      // 
      this.btnCalculate.Location = new System.Drawing.Point(131, 131);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(75, 23);
      this.btnCalculate.TabIndex = 8;
      this.btnCalculate.Text = "Calculate";
      this.btnCalculate.UseVisualStyleBackColor = true;
      this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
      // 
      // txtOutput
      // 
      this.txtOutput.Location = new System.Drawing.Point(24, 180);
      this.txtOutput.Name = "txtOutput";
      this.txtOutput.ReadOnly = true;
      this.txtOutput.Size = new System.Drawing.Size(236, 20);
      this.txtOutput.TabIndex = 9;
      // 
      // frmChangeForDollar
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(272, 224);
      this.Controls.Add(this.txtOutput);
      this.Controls.Add(this.btnCalculate);
      this.Controls.Add(this.txtQuarters);
      this.Controls.Add(this.txtDimes);
      this.Controls.Add(this.txtNickles);
      this.Controls.Add(this.txtPennies);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "frmChangeForDollar";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Change For A Dollar";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtPennies;
    private System.Windows.Forms.TextBox txtNickles;
    private System.Windows.Forms.TextBox txtDimes;
    private System.Windows.Forms.TextBox txtQuarters;
    private System.Windows.Forms.Button btnCalculate;
    private System.Windows.Forms.TextBox txtOutput;
  }
}

