/*
 * Done
Calculating the Factorial of a Number In mathematics, the notation n! represents the factorial of the nonnegative integer n.The factorial of n is the product of all the nonnegative integers from 1 through n. For example, 
7! = 1 × 2 × 3 × 4 × 5 × 6 × 7 = 5,040 
4! = 1 × 2 × 3 × 4 = 24 
Create an application that lets the user enter a nonnegative integer and then uses a loop to calculate the factorial of that number. Display the factorial in a label or a message box.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_05_12_FactorialOfNumber
{
  public partial class frmFactorial : Form
  {
    public frmFactorial()
    {
      InitializeComponent();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      int number;
      double factorial = 1;

      if (int.TryParse(txtNumber.Text, out number))
      {
        //4! = 1 × 2 × 3 × 4 = 24 
        for (int i = 1; i <= number; i++)
        {
          factorial *= i;
        }
        MessageBox.Show("Factorial of " + number + " is " + factorial);
      }
      else
        MessageBox.Show("Please enter a valid number", "Invalid input");
    }


    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
