/*
Prime Numbers A prime number is a number that can be evenly divided by only itself and 1. For example, the number 5 is prime because it can be evenly divided by only 1 and 5. The number 6, however, is not prime because it can be evenly divided by 1, 2, 3, and 6. Write a Boolean function named IsPrime that takes an integer as an argument and returns true if the argument is a prime number or false otherwise.Use the function in an application that lets the user enter a number and then displays a message indicating whether the number is prime.
TIP: Recall that the % operator divides one number by another and returns the remainder of the division. In an expression such as num1 % num2, the % operator returns 0 if num1 is evenly divisible by num2.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_06_08_PrimeNumbers
{
  public partial class frmPrimeNumbers : Form
  {
    public frmPrimeNumbers()
    {
      InitializeComponent();
    }

    private void btnIsPrime_Click(object sender, EventArgs e)
    {
      int number;
      if (int.TryParse(txtNumber.Text, out number))
      {
        if (IsPrime(number))
          MessageBox.Show(number + " is a Prime number");
        else
          MessageBox.Show(number + " is NOT a Prime number");
      }
      else
        MessageBox.Show("Please enter valid input", "Invalid Input");
    }

    private bool IsPrime(int number)
    {
      if (number == 1 || number == 2 || number == 3)
        return true;

      if (number % 2 == 0)
        return false;

      int half = number / 2;
      for (int i = 3; i <= half; i++)
      {
        if (number % i == 0)
          return false;
      }

      return true;
    }
  }
}
