namespace Gaddis_09_06_DormAndMealPlanCalculator
{
    partial class frmDormAndMealCost
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDorm = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radUnlimitedMeals = new System.Windows.Forms.RadioButton();
            this.rad14Meals = new System.Windows.Forms.RadioButton();
            this.rad7Meals = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDorm);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Dorm";
            // 
            // cmbDorm
            // 
            this.cmbDorm.FormattingEnabled = true;
            this.cmbDorm.Location = new System.Drawing.Point(14, 31);
            this.cmbDorm.Name = "cmbDorm";
            this.cmbDorm.Size = new System.Drawing.Size(150, 21);
            this.cmbDorm.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radUnlimitedMeals);
            this.groupBox2.Controls.Add(this.rad14Meals);
            this.groupBox2.Controls.Add(this.rad7Meals);
            this.groupBox2.Location = new System.Drawing.Point(12, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 89);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Meal Plan";
            // 
            // radUnlimitedMeals
            // 
            this.radUnlimitedMeals.AutoSize = true;
            this.radUnlimitedMeals.Location = new System.Drawing.Point(7, 65);
            this.radUnlimitedMeals.Name = "radUnlimitedMeals";
            this.radUnlimitedMeals.Size = new System.Drawing.Size(110, 17);
            this.radUnlimitedMeals.TabIndex = 2;
            this.radUnlimitedMeals.TabStop = true;
            this.radUnlimitedMeals.Text = "Unlimited ($1,700)";
            this.radUnlimitedMeals.UseVisualStyleBackColor = true;
            // 
            // rad14Meals
            // 
            this.rad14Meals.AutoSize = true;
            this.rad14Meals.Location = new System.Drawing.Point(7, 42);
            this.rad14Meals.Name = "rad14Meals";
            this.rad14Meals.Size = new System.Drawing.Size(157, 17);
            this.rad14Meals.TabIndex = 1;
            this.rad14Meals.TabStop = true;
            this.rad14Meals.Text = "14 Meals Per Weel ($1,200)";
            this.rad14Meals.UseVisualStyleBackColor = true;
            // 
            // rad7Meals
            // 
            this.rad7Meals.AutoSize = true;
            this.rad7Meals.Location = new System.Drawing.Point(7, 19);
            this.rad7Meals.Name = "rad7Meals";
            this.rad7Meals.Size = new System.Drawing.Size(146, 17);
            this.rad7Meals.TabIndex = 0;
            this.rad7Meals.TabStop = true;
            this.rad7Meals.Text = "7 Meals Per Week ($600)";
            this.rad7Meals.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(72, 279);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmDormAndMealCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 324);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDormAndMealCost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dorm and Meal Cost Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radUnlimitedMeals;
        private System.Windows.Forms.RadioButton rad14Meals;
        private System.Windows.Forms.RadioButton rad7Meals;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ComboBox cmbDorm;
    }
}

