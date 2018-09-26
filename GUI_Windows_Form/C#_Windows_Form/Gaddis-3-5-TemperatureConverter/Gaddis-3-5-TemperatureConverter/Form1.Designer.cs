namespace Gaddis_3_5_TemperatureConverter
{
  partial class frmTemperatureConverter
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
      this.txtTemperature = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnToFahrenheit = new System.Windows.Forms.Button();
      this.btnToCelsius = new System.Windows.Forms.Button();
      this.txtOutput = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // txtTemperature
      // 
      this.txtTemperature.Location = new System.Drawing.Point(133, 12);
      this.txtTemperature.Name = "txtTemperature";
      this.txtTemperature.Size = new System.Drawing.Size(100, 20);
      this.txtTemperature.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(28, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(95, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Enter Temperature";
      // 
      // btnToFahrenheit
      // 
      this.btnToFahrenheit.Location = new System.Drawing.Point(31, 45);
      this.btnToFahrenheit.Name = "btnToFahrenheit";
      this.btnToFahrenheit.Size = new System.Drawing.Size(75, 42);
      this.btnToFahrenheit.TabIndex = 2;
      this.btnToFahrenheit.Text = "Convert To Fehrenheit";
      this.btnToFahrenheit.UseVisualStyleBackColor = true;
      this.btnToFahrenheit.Click += new System.EventHandler(this.btnToFahrenheit_Click);
      // 
      // btnToCelsius
      // 
      this.btnToCelsius.Location = new System.Drawing.Point(158, 45);
      this.btnToCelsius.Name = "btnToCelsius";
      this.btnToCelsius.Size = new System.Drawing.Size(75, 42);
      this.btnToCelsius.TabIndex = 3;
      this.btnToCelsius.Text = "Convert To Celsius";
      this.btnToCelsius.UseVisualStyleBackColor = true;
      this.btnToCelsius.Click += new System.EventHandler(this.btnToCelsius_Click);
      // 
      // txtOutput
      // 
      this.txtOutput.Location = new System.Drawing.Point(31, 103);
      this.txtOutput.Name = "txtOutput";
      this.txtOutput.ReadOnly = true;
      this.txtOutput.Size = new System.Drawing.Size(202, 20);
      this.txtOutput.TabIndex = 4;
      this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // frmTemperatureConverter
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(263, 147);
      this.Controls.Add(this.txtOutput);
      this.Controls.Add(this.btnToCelsius);
      this.Controls.Add(this.btnToFahrenheit);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtTemperature);
      this.Name = "frmTemperatureConverter";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Temperature Converter";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtTemperature;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnToFahrenheit;
    private System.Windows.Forms.Button btnToCelsius;
    private System.Windows.Forms.TextBox txtOutput;
  }
}

