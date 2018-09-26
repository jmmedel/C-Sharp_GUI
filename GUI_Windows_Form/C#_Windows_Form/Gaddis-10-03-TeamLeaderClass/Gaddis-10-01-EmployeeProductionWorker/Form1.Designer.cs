namespace Gaddis_10_01_EmployeeProductionWorker
{
  partial class frmEmployee
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
      this.btnDisplay = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.txtId = new System.Windows.Forms.TextBox();
      this.txtShift = new System.Windows.Forms.TextBox();
      this.txtPay = new System.Windows.Forms.TextBox();
      this.txtOutput = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.radSupervisor = new System.Windows.Forms.RadioButton();
      this.radWorker = new System.Windows.Forms.RadioButton();
      this.label5 = new System.Windows.Forms.Label();
      this.txtBonus = new System.Windows.Forms.TextBox();
      this.radTeamLeader = new System.Windows.Forms.RadioButton();
      this.txtTrainingHours = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnDisplay
      // 
      this.btnDisplay.Location = new System.Drawing.Point(130, 269);
      this.btnDisplay.Name = "btnDisplay";
      this.btnDisplay.Size = new System.Drawing.Size(75, 23);
      this.btnDisplay.TabIndex = 9;
      this.btnDisplay.Text = "Display";
      this.btnDisplay.UseVisualStyleBackColor = true;
      this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(31, 163);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(68, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Shift Number";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(74, 189);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(25, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Pay";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(15, 110);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(84, 13);
      this.label3.TabIndex = 3;
      this.label3.Text = "Employee Name";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(34, 137);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(65, 13);
      this.label4.TabIndex = 4;
      this.label4.Text = "Employee Id";
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(105, 107);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(100, 20);
      this.txtName.TabIndex = 3;
      // 
      // txtId
      // 
      this.txtId.Location = new System.Drawing.Point(105, 134);
      this.txtId.Name = "txtId";
      this.txtId.Size = new System.Drawing.Size(100, 20);
      this.txtId.TabIndex = 4;
      // 
      // txtShift
      // 
      this.txtShift.Location = new System.Drawing.Point(105, 160);
      this.txtShift.Name = "txtShift";
      this.txtShift.Size = new System.Drawing.Size(100, 20);
      this.txtShift.TabIndex = 5;
      // 
      // txtPay
      // 
      this.txtPay.Location = new System.Drawing.Point(105, 186);
      this.txtPay.Name = "txtPay";
      this.txtPay.Size = new System.Drawing.Size(100, 20);
      this.txtPay.TabIndex = 6;
      // 
      // txtOutput
      // 
      this.txtOutput.Location = new System.Drawing.Point(18, 298);
      this.txtOutput.Multiline = true;
      this.txtOutput.Name = "txtOutput";
      this.txtOutput.ReadOnly = true;
      this.txtOutput.Size = new System.Drawing.Size(187, 132);
      this.txtOutput.TabIndex = 9;
      this.txtOutput.TabStop = false;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.radTeamLeader);
      this.groupBox1.Controls.Add(this.radSupervisor);
      this.groupBox1.Controls.Add(this.radWorker);
      this.groupBox1.Location = new System.Drawing.Point(12, 7);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(193, 94);
      this.groupBox1.TabIndex = 10;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Position";
      // 
      // radSupervisor
      // 
      this.radSupervisor.AutoSize = true;
      this.radSupervisor.Location = new System.Drawing.Point(7, 44);
      this.radSupervisor.Name = "radSupervisor";
      this.radSupervisor.Size = new System.Drawing.Size(75, 17);
      this.radSupervisor.TabIndex = 1;
      this.radSupervisor.Text = "Supervisor";
      this.radSupervisor.UseVisualStyleBackColor = true;
      this.radSupervisor.CheckedChanged += new System.EventHandler(this.radSupervisor_CheckedChanged);
      // 
      // radWorker
      // 
      this.radWorker.AutoSize = true;
      this.radWorker.Checked = true;
      this.radWorker.Location = new System.Drawing.Point(7, 20);
      this.radWorker.Name = "radWorker";
      this.radWorker.Size = new System.Drawing.Size(60, 17);
      this.radWorker.TabIndex = 0;
      this.radWorker.TabStop = true;
      this.radWorker.Text = "Worker";
      this.radWorker.UseVisualStyleBackColor = true;
      this.radWorker.CheckedChanged += new System.EventHandler(this.radWorker_CheckedChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(62, 215);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(37, 13);
      this.label5.TabIndex = 11;
      this.label5.Text = "Bonus";
      // 
      // txtBonus
      // 
      this.txtBonus.Enabled = false;
      this.txtBonus.Location = new System.Drawing.Point(105, 212);
      this.txtBonus.Name = "txtBonus";
      this.txtBonus.Size = new System.Drawing.Size(100, 20);
      this.txtBonus.TabIndex = 7;
      // 
      // radTeamLeader
      // 
      this.radTeamLeader.AutoSize = true;
      this.radTeamLeader.Location = new System.Drawing.Point(7, 68);
      this.radTeamLeader.Name = "radTeamLeader";
      this.radTeamLeader.Size = new System.Drawing.Size(88, 17);
      this.radTeamLeader.TabIndex = 2;
      this.radTeamLeader.TabStop = true;
      this.radTeamLeader.Text = "Team Leader";
      this.radTeamLeader.UseVisualStyleBackColor = true;
      this.radTeamLeader.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
      // 
      // txtTrainingHours
      // 
      this.txtTrainingHours.Enabled = false;
      this.txtTrainingHours.Location = new System.Drawing.Point(105, 238);
      this.txtTrainingHours.Name = "txtTrainingHours";
      this.txtTrainingHours.Size = new System.Drawing.Size(100, 20);
      this.txtTrainingHours.TabIndex = 8;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(23, 241);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(76, 13);
      this.label6.TabIndex = 14;
      this.label6.Text = "Training Hours";
      // 
      // frmEmployee
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(223, 442);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.txtTrainingHours);
      this.Controls.Add(this.txtBonus);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.txtOutput);
      this.Controls.Add(this.txtPay);
      this.Controls.Add(this.txtShift);
      this.Controls.Add(this.txtId);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnDisplay);
      this.Name = "frmEmployee";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Employees";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnDisplay;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.TextBox txtId;
    private System.Windows.Forms.TextBox txtShift;
    private System.Windows.Forms.TextBox txtPay;
    private System.Windows.Forms.TextBox txtOutput;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton radSupervisor;
    private System.Windows.Forms.RadioButton radWorker;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtBonus;
    private System.Windows.Forms.RadioButton radTeamLeader;
    private System.Windows.Forms.TextBox txtTrainingHours;
    private System.Windows.Forms.Label label6;
  }
}

