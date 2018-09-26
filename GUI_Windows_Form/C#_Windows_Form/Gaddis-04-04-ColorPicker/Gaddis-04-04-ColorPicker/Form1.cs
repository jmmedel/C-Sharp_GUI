/*
Color Mixer The colors red, blue, and yellow are known as the primary colors because they cannot be made by mixing other colors. When you mix two primary colors, you get a secondary color, as shown here: 
• When you mix red and blue, you get purple. 
• When you mix red and yellow, you get orange. 
• When you mix blue and yellow, you get green. 

Create an application that lets the user select two primary colors from two different sets of Radio buttons. The form should also have a Mix button. When the user clicks the Mix button, the form’s background should change to the color that you get when you mix the two selected primary colors. Figure 4-34shows an example of how the form should appear.
Note: If the user picks the same color from both sets of Radio buttons, set the form’s background to that color.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_04_04_ColorPicker
{
  public partial class frmColorMixer : Form
  {
    public frmColorMixer()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnMix_Click(object sender, EventArgs e)
    {
      if (radFirstRed.Checked && radSecondRed.Checked)
        this.BackColor = System.Drawing.Color.Red;
      else if (radFirstBlue.Checked && radSecondBlue.Checked)
        this.BackColor = System.Drawing.Color.Blue;
      else if (radFirstYellow.Checked && radSecondYellow.Checked)
        this.BackColor = System.Drawing.Color.Yellow;
      else if ((radFirstRed.Checked && radSecondBlue.Checked) ||
              (radFirstBlue.Checked && radSecondRed.Checked))
        this.BackColor = System.Drawing.Color.Purple;
      else if ((radFirstBlue.Checked && radSecondYellow.Checked) ||
              radFirstYellow.Checked && radSecondBlue.Checked)
        this.BackColor = System.Drawing.Color.Green;
      else
        this.BackColor = System.Drawing.Color.Orange;
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}
