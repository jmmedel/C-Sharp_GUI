/*
Create an application with a Show Heads button and a Show Tails button. When the user clicks the Show Heads button, an image of the heads side of a coin should appear. When the user clicks the Show Tails button, an image of the tails side of a coin should appear.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_02_05_HeadsOrTails
{
  public partial class frmCoinToss : Form
  {
    public frmCoinToss()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnHeads_Click(object sender, EventArgs e)
    {
      picHeads.Visible = true;
      picTails.Visible = false;
    }

    private void btnTails_Click(object sender, EventArgs e)
    {
      picTails.Visible = true;
      picHeads.Visible = false;
    }
  }
}
