namespace Gaddis_08_11_DrinkVendingMachine
{
  partial class frmVendingMachine
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtColaLeft = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picCola = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRootBeerLeft = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picRootBeer = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLemonLimeLeft = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.picLemonLime = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtGrapeSodaLeft = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.picGrapeSoda = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtCreamSodaLeft = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.picCreamSoda = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtTotalSales = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCola)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRootBeer)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLemonLime)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGrapeSoda)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCreamSoda)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Drink";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtColaLeft);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.picCola);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 95);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtColaLeft
            // 
            this.txtColaLeft.Location = new System.Drawing.Point(82, 60);
            this.txtColaLeft.Name = "txtColaLeft";
            this.txtColaLeft.ReadOnly = true;
            this.txtColaLeft.Size = new System.Drawing.Size(63, 20);
            this.txtColaLeft.TabIndex = 3;
            this.txtColaLeft.TabStop = false;
            this.txtColaLeft.Text = "20";
            this.txtColaLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Drinks Left";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "$1.00";
            // 
            // picCola
            // 
            this.picCola.Image = global::Gaddis_08_11_DrinkVendingMachine.Properties.Resources.Cola;
            this.picCola.Location = new System.Drawing.Point(3, 16);
            this.picCola.Name = "picCola";
            this.picCola.Size = new System.Drawing.Size(64, 64);
            this.picCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCola.TabIndex = 0;
            this.picCola.TabStop = false;
            this.picCola.Click += new System.EventHandler(this.picCola_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRootBeerLeft);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.picRootBeer);
            this.groupBox2.Location = new System.Drawing.Point(172, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 95);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // txtRootBeerLeft
            // 
            this.txtRootBeerLeft.Location = new System.Drawing.Point(82, 60);
            this.txtRootBeerLeft.Name = "txtRootBeerLeft";
            this.txtRootBeerLeft.ReadOnly = true;
            this.txtRootBeerLeft.Size = new System.Drawing.Size(63, 20);
            this.txtRootBeerLeft.TabIndex = 3;
            this.txtRootBeerLeft.TabStop = false;
            this.txtRootBeerLeft.Text = "20";
            this.txtRootBeerLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Drinks Left";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "$1.00";
            // 
            // picRootBeer
            // 
            this.picRootBeer.Image = global::Gaddis_08_11_DrinkVendingMachine.Properties.Resources.RootBeer;
            this.picRootBeer.Location = new System.Drawing.Point(3, 16);
            this.picRootBeer.Name = "picRootBeer";
            this.picRootBeer.Size = new System.Drawing.Size(64, 64);
            this.picRootBeer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRootBeer.TabIndex = 0;
            this.picRootBeer.TabStop = false;
            this.picRootBeer.Click += new System.EventHandler(this.picRootBeer_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLemonLimeLeft);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.picLemonLime);
            this.groupBox3.Location = new System.Drawing.Point(12, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(151, 95);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // txtLemonLimeLeft
            // 
            this.txtLemonLimeLeft.Location = new System.Drawing.Point(82, 60);
            this.txtLemonLimeLeft.Name = "txtLemonLimeLeft";
            this.txtLemonLimeLeft.ReadOnly = true;
            this.txtLemonLimeLeft.Size = new System.Drawing.Size(63, 20);
            this.txtLemonLimeLeft.TabIndex = 3;
            this.txtLemonLimeLeft.TabStop = false;
            this.txtLemonLimeLeft.Text = "20";
            this.txtLemonLimeLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Drinks Left";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(94, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "$1.00";
            // 
            // picLemonLime
            // 
            this.picLemonLime.Image = global::Gaddis_08_11_DrinkVendingMachine.Properties.Resources.LemonLime;
            this.picLemonLime.Location = new System.Drawing.Point(3, 16);
            this.picLemonLime.Name = "picLemonLime";
            this.picLemonLime.Size = new System.Drawing.Size(62, 64);
            this.picLemonLime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLemonLime.TabIndex = 0;
            this.picLemonLime.TabStop = false;
            this.picLemonLime.Click += new System.EventHandler(this.picLemonLime_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtGrapeSodaLeft);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.picGrapeSoda);
            this.groupBox4.Location = new System.Drawing.Point(169, 129);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(151, 95);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // txtGrapeSodaLeft
            // 
            this.txtGrapeSodaLeft.Location = new System.Drawing.Point(82, 60);
            this.txtGrapeSodaLeft.Name = "txtGrapeSodaLeft";
            this.txtGrapeSodaLeft.ReadOnly = true;
            this.txtGrapeSodaLeft.Size = new System.Drawing.Size(63, 20);
            this.txtGrapeSodaLeft.TabIndex = 3;
            this.txtGrapeSodaLeft.TabStop = false;
            this.txtGrapeSodaLeft.Text = "20";
            this.txtGrapeSodaLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Drinks Left";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(94, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "$1.50";
            // 
            // picGrapeSoda
            // 
            this.picGrapeSoda.Image = global::Gaddis_08_11_DrinkVendingMachine.Properties.Resources.GrapeSoda;
            this.picGrapeSoda.Location = new System.Drawing.Point(3, 16);
            this.picGrapeSoda.Name = "picGrapeSoda";
            this.picGrapeSoda.Size = new System.Drawing.Size(62, 64);
            this.picGrapeSoda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picGrapeSoda.TabIndex = 0;
            this.picGrapeSoda.TabStop = false;
            this.picGrapeSoda.Click += new System.EventHandler(this.picGrapeSoda_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtCreamSodaLeft);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.picCreamSoda);
            this.groupBox5.Location = new System.Drawing.Point(15, 230);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(151, 95);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            // 
            // txtCreamSodaLeft
            // 
            this.txtCreamSodaLeft.Location = new System.Drawing.Point(82, 60);
            this.txtCreamSodaLeft.Name = "txtCreamSodaLeft";
            this.txtCreamSodaLeft.ReadOnly = true;
            this.txtCreamSodaLeft.Size = new System.Drawing.Size(63, 20);
            this.txtCreamSodaLeft.TabIndex = 3;
            this.txtCreamSodaLeft.TabStop = false;
            this.txtCreamSodaLeft.Text = "20";
            this.txtCreamSodaLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(87, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Drinks Left";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(94, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "$1.50";
            // 
            // picCreamSoda
            // 
            this.picCreamSoda.Image = global::Gaddis_08_11_DrinkVendingMachine.Properties.Resources.CreamSoda;
            this.picCreamSoda.Location = new System.Drawing.Point(3, 16);
            this.picCreamSoda.Name = "picCreamSoda";
            this.picCreamSoda.Size = new System.Drawing.Size(62, 64);
            this.picCreamSoda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCreamSoda.TabIndex = 0;
            this.picCreamSoda.TabStop = false;
            this.picCreamSoda.Click += new System.EventHandler(this.picCreamSoda_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtTotalSales);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Location = new System.Drawing.Point(174, 230);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(151, 95);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            // 
            // txtTotalSales
            // 
            this.txtTotalSales.Location = new System.Drawing.Point(32, 60);
            this.txtTotalSales.Name = "txtTotalSales";
            this.txtTotalSales.ReadOnly = true;
            this.txtTotalSales.Size = new System.Drawing.Size(76, 20);
            this.txtTotalSales.TabIndex = 3;
            this.txtTotalSales.TabStop = false;
            this.txtTotalSales.Text = "$0.00";
            this.txtTotalSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(29, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "Total Sales";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(219, 339);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(52, 339);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(97, 23);
            this.btnNewCustomer.TabIndex = 8;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // frmVendingMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 374);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmVendingMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vending Machine";
            this.Load += new System.EventHandler(this.frmVendingMachine_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCola)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRootBeer)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLemonLime)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGrapeSoda)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCreamSoda)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtColaLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picCola;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRootBeerLeft;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picRootBeer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtLemonLimeLeft;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picLemonLime;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtGrapeSodaLeft;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox picGrapeSoda;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtCreamSodaLeft;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox picCreamSoda;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtTotalSales;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNewCustomer;
    }
}

