/*
Sentence Builder The form in Figure 3-41contains buttons showing various words, phrases, and punctuation.Create an application with a form similar to this one.When the application runs, the user clicks the buttons to build a sentence, which is shown in a Label control.You can use the same buttons as shown in the figure or make up your own.The Reset button should clear the sentence so the user can start over.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_03_07_SentenceBuilder
{
  public partial class frmSentenceBuilder : Form
  {
    public frmSentenceBuilder()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      txtOutput.Text += button1.Text;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      txtOutput.Text += button2.Text;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      txtOutput.Text += button3.Text;
    }

    private void button4_Click(object sender, EventArgs e)
    {
      txtOutput.Text += button4.Text;
    }

    private void button5_Click(object sender, EventArgs e)
    {
      txtOutput.Text += button5.Text;
    }

    private void button6_Click(object sender, EventArgs e)
    {
      txtOutput.Text += button6.Text;
    }

    private void button7_Click(object sender, EventArgs e)
    {
      txtOutput.Text += button7.Text;
    }

    private void button8_Click(object sender, EventArgs e)
    {
      txtOutput.Text += button8.Text;
    }

    private void button9_Click(object sender, EventArgs e)
    {
      txtOutput.Text += button9.Text;
    }

    private void button10_Click(object sender, EventArgs e)
    {
      txtOutput.Text += button10.Text;
    }

    private void button11_Click(object sender, EventArgs e)
    {
      txtOutput.Text += button11.Text;
    }

    private void button12_Click(object sender, EventArgs e)
    {
      txtOutput.Text += button12.Text;
    }

    private void button13_Click(object sender, EventArgs e)
    {
      txtOutput.Text += button13.Text;
    }

    private void button14_Click(object sender, EventArgs e)
    {
      txtOutput.Text += button14.Text;
    }

    private void button15_Click(object sender, EventArgs e)
    {
      txtOutput.Text += button15.Text;
    }

    private void button16_Click(object sender, EventArgs e)
    {
      txtOutput.Text += button16.Text;
    }

    private void button17_Click(object sender, EventArgs e)
    {
      txtOutput.Text += button17.Text;
    }

    private void button18_Click(object sender, EventArgs e)
    {
      txtOutput.Text += button18.Text;
    }

    private void button19_Click(object sender, EventArgs e)
    {
      txtOutput.Text += button19.Text;
    }

    private void button20_Click(object sender, EventArgs e)
    {
      txtOutput.Text += button20.Text;
    }

    private void button21_Click(object sender, EventArgs e)
    {
      txtOutput.Text += button21.Text;
    }

    private void button22_Click(object sender, EventArgs e)
    {
      txtOutput.Text += " ";
    }

    private void button23_Click(object sender, EventArgs e)
    {
      txtOutput.Text += button23.Text;
    }

    private void button24_Click(object sender, EventArgs e)
    {
      txtOutput.Text += button24.Text;
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      txtOutput.Clear();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}
