/*
 * Done
Addition Tutor Create an application that generates two random integers, each in the range of 100 through 500. The numbers should be displayed as addition problems on the application’s form, such as 247 + 129 =? The form should have a text box for the user to enter the problem’s answer.When a button is clicked, the application should do the following: 
• Check the user’s input and display a message indicating whether it is the correct answer. 
• Generate two new random numbers and display them in a new problem on the form.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_05_10_AdditionTutor
{
  public partial class frmAdditionTutor : Form
  {

    // get the the two number
    int first;
    int second;
    // random number
    Random rand;
    public frmAdditionTutor()
    {
      InitializeComponent();
    }

    private void btnSubmitAnswer_Click(object sender, EventArgs e)
    {
      int answer;
      if (int.TryParse(txtAnswer.Text, out answer))
      {
        if (answer == first + second)
          lblMessage.Text = "CORRECT";
        else
          lblMessage.Text = "INCORRECT! Correct answer is " + (first + second);

        first = rand.Next(100, 501);
        second = rand.Next(100, 501);
        lblAddition.Text = first + " + " + second + "= ?";
      }
      else
        MessageBox.Show("Please enter a valid number", "Invalid Input");
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      rand = new Random();
      first = rand.Next(100, 501);
      second = rand.Next(100, 501);
      lblAddition.Text = first + " + " + second + " = ?";
    }
  }
}
