/*
Create an application that displays 5 images in PictureBox controls. The application should perform the following actions: • When the user clicks the 1 image, the application should display the word One in a message box. • When the user clicks the 2 image, the application should display the word Two in a message box. • When the user clicks the 3 image, the application should display the word Three in a message box. • When the user clicks the 4 image, the application should display the word Four in a message box. • When the user clicks the 5 image, the application should display the word Five in a message box.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaddis_02_02_ClickableImages
{
  public partial class frmClickableImages : Form
  {
    public frmClickableImages()
    {
      InitializeComponent();
    }

    private void frmClickableImages_Load(object sender, EventArgs e)
    {

    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
      MessageBox.Show("One", "Clickable Image");
      pictureBox1.Enabled = false;
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Two", "Clickable Image");
    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Three", "Clickable Image");
    }

    private void pictureBox4_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Four", "Clickable Image");
    }

    private void pictureBox5_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Five", "Clickable Image");
    }
  }
}
