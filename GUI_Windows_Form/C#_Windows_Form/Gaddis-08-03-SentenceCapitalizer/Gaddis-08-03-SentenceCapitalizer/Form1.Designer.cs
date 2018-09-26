namespace Gaddis_08_03_SentenceCapitalizer
{
    partial class frmSentenceCapitalizer
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
            this.txtSentence = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnCapitalize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Sentence";
            // 
            // txtSentence
            // 
            this.txtSentence.Location = new System.Drawing.Point(12, 25);
            this.txtSentence.Name = "txtSentence";
            this.txtSentence.Size = new System.Drawing.Size(260, 20);
            this.txtSentence.TabIndex = 1;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 99);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(260, 20);
            this.txtOutput.TabIndex = 3;
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCapitalize
            // 
            this.btnCapitalize.Location = new System.Drawing.Point(69, 51);
            this.btnCapitalize.Name = "btnCapitalize";
            this.btnCapitalize.Size = new System.Drawing.Size(135, 23);
            this.btnCapitalize.TabIndex = 4;
            this.btnCapitalize.Text = "Capitalize Sentence";
            this.btnCapitalize.UseVisualStyleBackColor = true;
            this.btnCapitalize.Click += new System.EventHandler(this.btnCapitalize_Click);
            // 
            // frmSentenceCapitalizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 136);
            this.Controls.Add(this.btnCapitalize);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtSentence);
            this.Controls.Add(this.label1);
            this.Name = "frmSentenceCapitalizer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sentence Capitalizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSentence;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnCapitalize;
    }
}

