/*
Sum of Numbers in a String Create an application that lets the user enter a string containing series of numbers separated by commas.Here is an example of valid input: 7,9,10,2,18,6 The program should calculate and display the sum of all the numbers.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_08_08_SumOfNumbersInString
{
  public partial class frmSumOfNumbers : Form
  {
    public frmSumOfNumbers()
    {
      InitializeComponent();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      string[] input = txtNumbers.Text.Trim().Split(',');
      int sum = 0;
      int number;

      foreach (string s in input)
      {
        if (int.TryParse(s, out number))
        {
          sum += number;
        }
      }

      txtSum.Text = sum.ToString();
    }
  }
}
