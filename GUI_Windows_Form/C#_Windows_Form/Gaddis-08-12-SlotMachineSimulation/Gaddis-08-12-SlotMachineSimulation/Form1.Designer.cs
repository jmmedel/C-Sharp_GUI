namespace Gaddis_08_12_SlotMachineSimulation
{
  partial class frmSlotMachine
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSlotMachine));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmountInserted = new System.Windows.Forms.TextBox();
            this.btnSpin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount Inserted";
            // 
            // txtAmountInserted
            // 
            this.txtAmountInserted.Location = new System.Drawing.Point(214, 187);
            this.txtAmountInserted.Name = "txtAmountInserted";
            this.txtAmountInserted.Size = new System.Drawing.Size(100, 20);
            this.txtAmountInserted.TabIndex = 1;
            // 
            // btnSpin
            // 
            this.btnSpin.Location = new System.Drawing.Point(127, 223);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(75, 23);
            this.btnSpin.TabIndex = 2;
            this.btnSpin.Text = "Spin";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(239, 223);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "Banana.bmp");
            this.imgList.Images.SetKeyName(1, "Grapes.bmp");
            this.imgList.Images.SetKeyName(2, "Watermelon.bmp");
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(12, 35);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(128, 128);
            this.pic1.TabIndex = 4;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(154, 35);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(128, 128);
            this.pic2.TabIndex = 5;
            this.pic2.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.Location = new System.Drawing.Point(298, 35);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(128, 128);
            this.pic3.TabIndex = 6;
            this.pic3.TabStop = false;
            // 
            // frmSlotMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 261);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.txtAmountInserted);
            this.Controls.Add(this.label1);
            this.Name = "frmSlotMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slot Machine";
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmountInserted;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
    }
}

