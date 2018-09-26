namespace Gaddis_08_09_AlphabeticTelephoneNumber
{
  partial class frmAlphabeticPhoneNumber
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
      this.txtAlphaNumber = new System.Windows.Forms.MaskedTextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtPhoneNumber = new System.Windows.Forms.TextBox();
      this.btnGetPhoneNumber = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 26);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(155, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Enter alphabetic phone number";
      // 
      // txtAlphaNumber
      // 
      this.txtAlphaNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtAlphaNumber.Location = new System.Drawing.Point(173, 23);
      this.txtAlphaNumber.Mask = "000-LLL-LLLL";
      this.txtAlphaNumber.Name = "txtAlphaNumber";
      this.txtAlphaNumber.Size = new System.Drawing.Size(144, 22);
      this.txtAlphaNumber.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(89, 120);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(78, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Phone Number";
      // 
      // txtPhoneNumber
      // 
      this.txtPhoneNumber.Location = new System.Drawing.Point(173, 117);
      this.txtPhoneNumber.Name = "txtPhoneNumber";
      this.txtPhoneNumber.ReadOnly = true;
      this.txtPhoneNumber.Size = new System.Drawing.Size(144, 20);
      this.txtPhoneNumber.TabIndex = 3;
      // 
      // btnGetPhoneNumber
      // 
      this.btnGetPhoneNumber.Location = new System.Drawing.Point(210, 60);
      this.btnGetPhoneNumber.Name = "btnGetPhoneNumber";
      this.btnGetPhoneNumber.Size = new System.Drawing.Size(107, 23);
      this.btnGetPhoneNumber.TabIndex = 4;
      this.btnGetPhoneNumber.Text = "Get Phone Number";
      this.btnGetPhoneNumber.UseVisualStyleBackColor = true;
      this.btnGetPhoneNumber.Click += new System.EventHandler(this.btnGetPhoneNumber_Click);
      // 
      // frmAlphabeticPhoneNumber
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(336, 158);
      this.Controls.Add(this.btnGetPhoneNumber);
      this.Controls.Add(this.txtPhoneNumber);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtAlphaNumber);
      this.Controls.Add(this.label1);
      this.Name = "frmAlphabeticPhoneNumber";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Alphabetic Phone Number";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.MaskedTextBox txtAlphaNumber;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtPhoneNumber;
    private System.Windows.Forms.Button btnGetPhoneNumber;
  }
}

