/*
Create an application with five PictureBox controls. Each PictureBox should display a different card from the set of images. When the user clicks any of the PictureBox controls, the name of the card should be displayed in a Label control.
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

namespace Gaddis_02_03_CardIdentifier
{
  public partial class frmCardIdentifier : Form
  {
    public frmCardIdentifier()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
      lblOutput.Text = "2 of Clubs";
    }

    private void pic2_Click(object sender, EventArgs e)
    {
      lblOutput.Text = "2 of Diamonds";
    }

    private void pic3_Click(object sender, EventArgs e)
    {
      lblOutput.Text = "2 of Hearts";
    }

    private void pic4_Click(object sender, EventArgs e)
    {
      lblOutput.Text = "2 of Spades";
    }

    private void pic5_Click(object sender, EventArgs e)
    {
      lblOutput.Text = "Joker";
    }
  }
}
