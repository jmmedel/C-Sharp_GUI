/*
Time Calculator Create an application that lets the user enter a number of seconds and works as follows: • There are 60 seconds in a minute. If the number of seconds entered by the user is greater than or equal to 60, the program should display the number of minutes in that many seconds. 
• There are 3,600 seconds in an hour. If the number of seconds entered by the user is greater than or equal to 3,600, the program should display the number of hours in that many seconds. 
• There are 86,400 seconds in a day. If the number of seconds entered by the user is greater than or equal to 86,400, the program should display the number of days in that many seconds.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_04_11_TimeCalculator
{
  public partial class frmTimeCalculator : Form
  {
    public frmTimeCalculator()
    {
      InitializeComponent();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      int totalSeconds;
      int output;

      if (int.TryParse(txtTimeInput.Text, out totalSeconds))
      {
        if (totalSeconds >= 86400)
        {
          output = totalSeconds / 86400;
          txtOutput.Text = "There are " + output + " days in " + totalSeconds + " seconds.";
        }
        else if (totalSeconds >= 3600)
        {
          output = totalSeconds / 3600;
          txtOutput.Text = "There are " + output + " hours in " + totalSeconds + " seconds.";
        }
        else if (totalSeconds >= 60)
        {
          output = totalSeconds / 60;
          txtOutput.Text = "There are " + output + " minutes in " + totalSeconds + " seconds.";
        }
        else
        {
          output = totalSeconds;
          txtOutput.Text = "There are " + output + " seconds in " + totalSeconds + " seconds.";
        }

      }
      else
        MessageBox.Show("Please enter valid number", "Invalid Input");
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
