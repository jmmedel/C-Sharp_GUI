namespace Gaddis_08_07_PigLatin
{
    partial class frmPigLatin
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
            this.btnTranslate = new System.Windows.Forms.Button();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtPigLatin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter English Words";
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(85, 60);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(126, 23);
            this.btnTranslate.TabIndex = 1;
            this.btnTranslate.Text = "Translate To Pig Latin";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(12, 25);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(260, 20);
            this.txtEnglish.TabIndex = 2;
            // 
            // txtPigLatin
            // 
            this.txtPigLatin.Location = new System.Drawing.Point(12, 106);
            this.txtPigLatin.Name = "txtPigLatin";
            this.txtPigLatin.ReadOnly = true;
            this.txtPigLatin.Size = new System.Drawing.Size(260, 20);
            this.txtPigLatin.TabIndex = 3;
            // 
            // frmPigLatin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 142);
            this.Controls.Add(this.txtPigLatin);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.label1);
            this.Name = "frmPigLatin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pig Latin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtPigLatin;
    }
}

