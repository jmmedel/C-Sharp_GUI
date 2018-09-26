namespace Gaddis_03_09_CookieCalories
{
  partial class frmCalories
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
      this.txtCaloriesEaten = new System.Windows.Forms.TextBox();
      this.txtNumberOfCookies = new System.Windows.Forms.TextBox();
      this.btnCalculate = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 24);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(103, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Hoe Many Cookies?";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 106);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(102, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Total Calories Eaten";
      // 
      // txtCaloriesEaten
      // 
      this.txtCaloriesEaten.Location = new System.Drawing.Point(121, 103);
      this.txtCaloriesEaten.Name = "txtCaloriesEaten";
      this.txtCaloriesEaten.Size = new System.Drawing.Size(100, 20);
      this.txtCaloriesEaten.TabIndex = 2;
      // 
      // txtNumberOfCookies
      // 
      this.txtNumberOfCookies.Location = new System.Drawing.Point(121, 21);
      this.txtNumberOfCookies.Name = "txtNumberOfCookies";
      this.txtNumberOfCookies.Size = new System.Drawing.Size(100, 20);
      this.txtNumberOfCookies.TabIndex = 3;
      // 
      // btnCalculate
      // 
      this.btnCalculate.Location = new System.Drawing.Point(136, 47);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(85, 37);
      this.btnCalculate.TabIndex = 4;
      this.btnCalculate.Text = "Calculate Calories";
      this.btnCalculate.UseVisualStyleBackColor = true;
      this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
      // 
      // frmCalories
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(246, 146);
      this.Controls.Add(this.btnCalculate);
      this.Controls.Add(this.txtNumberOfCookies);
      this.Controls.Add(this.txtCaloriesEaten);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "frmCalories";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Calories Calculator";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtCaloriesEaten;
    private System.Windows.Forms.TextBox txtNumberOfCookies;
    private System.Windows.Forms.Button btnCalculate;
  }
}

