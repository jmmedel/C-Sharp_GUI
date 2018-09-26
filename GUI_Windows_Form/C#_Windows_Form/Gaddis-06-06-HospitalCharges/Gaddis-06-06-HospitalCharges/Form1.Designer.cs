namespace Gaddis_06_06_HospitalCharges
{
    partial class frmHospitalCharges
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
      this.label5 = new System.Windows.Forms.Label();
      this.txtDays = new System.Windows.Forms.TextBox();
      this.txtMedication = new System.Windows.Forms.TextBox();
      this.txtSurgical = new System.Windows.Forms.TextBox();
      this.txtLabFees = new System.Windows.Forms.TextBox();
      this.txtRehabilitation = new System.Windows.Forms.TextBox();
      this.lstBill = new System.Windows.Forms.ListBox();
      this.btnCalculateBill = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(44, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(138, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Number Of Days In Hospital";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(28, 41);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(154, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Amount Of Medication Charges";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(42, 72);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(140, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Amount Of Surgical Charges";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(78, 102);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(104, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "Amount Of Lab Fees";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(16, 136);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(166, 13);
      this.label5.TabIndex = 4;
      this.label5.Text = "Amount Of Rehabilitation Charges";
      // 
      // txtDays
      // 
      this.txtDays.Location = new System.Drawing.Point(188, 6);
      this.txtDays.Name = "txtDays";
      this.txtDays.Size = new System.Drawing.Size(100, 20);
      this.txtDays.TabIndex = 0;
      // 
      // txtMedication
      // 
      this.txtMedication.Location = new System.Drawing.Point(188, 38);
      this.txtMedication.Name = "txtMedication";
      this.txtMedication.Size = new System.Drawing.Size(100, 20);
      this.txtMedication.TabIndex = 1;
      // 
      // txtSurgical
      // 
      this.txtSurgical.Location = new System.Drawing.Point(188, 69);
      this.txtSurgical.Name = "txtSurgical";
      this.txtSurgical.Size = new System.Drawing.Size(100, 20);
      this.txtSurgical.TabIndex = 2;
      // 
      // txtLabFees
      // 
      this.txtLabFees.Location = new System.Drawing.Point(188, 99);
      this.txtLabFees.Name = "txtLabFees";
      this.txtLabFees.Size = new System.Drawing.Size(100, 20);
      this.txtLabFees.TabIndex = 3;
      // 
      // txtRehabilitation
      // 
      this.txtRehabilitation.Location = new System.Drawing.Point(188, 133);
      this.txtRehabilitation.Name = "txtRehabilitation";
      this.txtRehabilitation.Size = new System.Drawing.Size(100, 20);
      this.txtRehabilitation.TabIndex = 4;
      // 
      // lstBill
      // 
      this.lstBill.FormattingEnabled = true;
      this.lstBill.Location = new System.Drawing.Point(19, 207);
      this.lstBill.Name = "lstBill";
      this.lstBill.Size = new System.Drawing.Size(269, 95);
      this.lstBill.TabIndex = 5;
      // 
      // btnCalculateBill
      // 
      this.btnCalculateBill.Location = new System.Drawing.Point(213, 159);
      this.btnCalculateBill.Name = "btnCalculateBill";
      this.btnCalculateBill.Size = new System.Drawing.Size(75, 23);
      this.btnCalculateBill.TabIndex = 5;
      this.btnCalculateBill.Text = "Calculate Bill";
      this.btnCalculateBill.UseVisualStyleBackColor = true;
      this.btnCalculateBill.Click += new System.EventHandler(this.btnCalculateBill_Click);
      // 
      // frmHospitalCharges
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(314, 314);
      this.Controls.Add(this.btnCalculateBill);
      this.Controls.Add(this.lstBill);
      this.Controls.Add(this.txtRehabilitation);
      this.Controls.Add(this.txtLabFees);
      this.Controls.Add(this.txtSurgical);
      this.Controls.Add(this.txtMedication);
      this.Controls.Add(this.txtDays);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "frmHospitalCharges";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Hospital Charges";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtMedication;
        private System.Windows.Forms.TextBox txtSurgical;
        private System.Windows.Forms.TextBox txtLabFees;
        private System.Windows.Forms.TextBox txtRehabilitation;
        private System.Windows.Forms.ListBox lstBill;
        private System.Windows.Forms.Button btnCalculateBill;
    }
}

