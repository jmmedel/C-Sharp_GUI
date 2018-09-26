/*
Think of your favorite joke and identify its setup and punch line. Then, create an application that has a Label and two buttons on a form. One of the buttons should read “Setup” and the other button should read “Punch line.” When the Setup button is clicked, display the joke’s setup in the Label control. When the Punch line button is clicked, display the joke’s punch line in the Label control.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_02_04_JokeAndPunchline
{
  public partial class frmJoke : Form
  {
    public frmJoke()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnSetup_Click(object sender, EventArgs e)
    {
      lblJoke.Text = "Why Java Programmers Wear Glasses?";
    }

    private void btnPunchLine_Click(object sender, EventArgs e)
    {
      lblJoke.Text = "Because They Can't C#";
    }
  }
}
