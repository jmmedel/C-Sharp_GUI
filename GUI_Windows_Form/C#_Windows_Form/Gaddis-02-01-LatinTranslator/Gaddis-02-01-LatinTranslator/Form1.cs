/*
Latin Translator Look at the following list of Latin words and their meanings. 
Latin sinister - dexter - medium 
English left - right - center
Create an application that translates the Latin words to English. 
The form should have three buttons, one for each Latin word. 
When the user clicks a button, the application should display the English translation in a Label control.
*/
/*
  
 this is import class
 
*/
using System;
using System.Windows.Forms;

namespace Gaddis_02_01_LatinTranslator
{
  public partial class frmLatinTranslator : Form
  {
    public frmLatinTranslator()
    {
      InitializeComponent();
    }
        //load
    private void Form1_Load(object sender, EventArgs e)
    {

    }
        //clickbutton
    private void btnLatinSinister_Click(object sender, EventArgs e)
    {
      lblOutput.Text = "Left";
      lblOutput.Left = 50;
    }
        //clickbutton
        private void btnLatinMedium_Click(object sender, EventArgs e)
    {
      lblOutput.Text = "Center";
      lblOutput.Left = (this.ClientSize.Width -lblOutput.Width) / 2;
    }
        //clickbutton
        private void btnLatinDexter_Click(object sender, EventArgs e)
    {
      lblOutput.Text = "Right";
      lblOutput.Left = 240;
    }
  }
}
