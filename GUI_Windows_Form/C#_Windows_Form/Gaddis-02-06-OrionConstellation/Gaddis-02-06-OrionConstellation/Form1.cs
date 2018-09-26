/*
Orion Constellation Orion is one of the most famous constellations in the night sky. Create an application that displays the Orion image in a PictureBox control. The application should have a button that, when clicked, displays the names of each of the stars. The application should have another button that, when clicked, hides the star names. The names of the stars are Betelgeuse, Meissa, Alnitak, Alnilam, Mintaka, Saiph, and Rigel. 
*/
using System;
using System.Windows.Forms;

namespace Gaddis_02_06_OrionConstellation
{
  public partial class frmOrion : Form
  {
    public frmOrion()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnDisplayStars_Click(object sender, EventArgs e)
    {
      label1.Visible = true;
      label2.Visible = true;
      label3.Visible = true;
      label4.Visible = true;
      label5.Visible = true;
      label6.Visible = true;
      label7.Visible = true;
    }

    private void btnHideStars_Click(object sender, EventArgs e)
    {
      label1.Visible = false;
      label2.Visible = false;
      label3.Visible = false;
      label4.Visible = false;
      label5.Visible = false;
      label6.Visible = false;
      label7.Visible = false;
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}
