namespace Gaddis_10_04_PersonAndCustomerClass
{
  partial class frmCustomers
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
      this.txtId = new System.Windows.Forms.TextBox();
      this.txtName = new System.Windows.Forms.TextBox();
      this.txtAddress = new System.Windows.Forms.TextBox();
      this.txtPhone = new System.Windows.Forms.TextBox();
      this.chkOnMailingList = new System.Windows.Forms.CheckBox();
      this.txtOutput = new System.Windows.Forms.TextBox();
      this.btnDisplay = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.txtAmountSpent = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(55, 48);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Name";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(45, 77);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(45, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Address";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 106);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(78, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Phone Number";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(27, 20);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(63, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "Customer Id";
      // 
      // txtId
      // 
      this.txtId.Location = new System.Drawing.Point(96, 17);
      this.txtId.Name = "txtId";
      this.txtId.Size = new System.Drawing.Size(100, 20);
      this.txtId.TabIndex = 0;
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(96, 45);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(100, 20);
      this.txtName.TabIndex = 1;
      // 
      // txtAddress
      // 
      this.txtAddress.Location = new System.Drawing.Point(96, 74);
      this.txtAddress.Name = "txtAddress";
      this.txtAddress.Size = new System.Drawing.Size(100, 20);
      this.txtAddress.TabIndex = 2;
      // 
      // txtPhone
      // 
      this.txtPhone.Location = new System.Drawing.Point(96, 103);
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Size = new System.Drawing.Size(100, 20);
      this.txtPhone.TabIndex = 3;
      // 
      // chkOnMailingList
      // 
      this.chkOnMailingList.AutoSize = true;
      this.chkOnMailingList.Location = new System.Drawing.Point(96, 169);
      this.chkOnMailingList.Name = "chkOnMailingList";
      this.chkOnMailingList.Size = new System.Drawing.Size(100, 17);
      this.chkOnMailingList.TabIndex = 5;
      this.chkOnMailingList.Text = "Join Mailing List";
      this.chkOnMailingList.UseVisualStyleBackColor = true;
      // 
      // txtOutput
      // 
      this.txtOutput.Location = new System.Drawing.Point(15, 221);
      this.txtOutput.Multiline = true;
      this.txtOutput.Name = "txtOutput";
      this.txtOutput.ReadOnly = true;
      this.txtOutput.Size = new System.Drawing.Size(181, 140);
      this.txtOutput.TabIndex = 5;
      this.txtOutput.TabStop = false;
      // 
      // btnDisplay
      // 
      this.btnDisplay.Location = new System.Drawing.Point(121, 192);
      this.btnDisplay.Name = "btnDisplay";
      this.btnDisplay.Size = new System.Drawing.Size(75, 23);
      this.btnDisplay.TabIndex = 6;
      this.btnDisplay.Text = "Display";
      this.btnDisplay.UseVisualStyleBackColor = true;
      this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(16, 138);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(74, 13);
      this.label5.TabIndex = 7;
      this.label5.Text = "Amount Spent";
      // 
      // txtAmountSpent
      // 
      this.txtAmountSpent.Location = new System.Drawing.Point(96, 135);
      this.txtAmountSpent.Name = "txtAmountSpent";
      this.txtAmountSpent.Size = new System.Drawing.Size(100, 20);
      this.txtAmountSpent.TabIndex = 4;
      // 
      // frmCustomers
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(218, 372);
      this.Controls.Add(this.txtAmountSpent);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.btnDisplay);
      this.Controls.Add(this.txtOutput);
      this.Controls.Add(this.chkOnMailingList);
      this.Controls.Add(this.txtPhone);
      this.Controls.Add(this.txtAddress);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.txtId);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "frmCustomers";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Customers";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtId;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.TextBox txtAddress;
    private System.Windows.Forms.TextBox txtPhone;
    private System.Windows.Forms.CheckBox chkOnMailingList;
    private System.Windows.Forms.TextBox txtOutput;
    private System.Windows.Forms.Button btnDisplay;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtAmountSpent;
  }
}

