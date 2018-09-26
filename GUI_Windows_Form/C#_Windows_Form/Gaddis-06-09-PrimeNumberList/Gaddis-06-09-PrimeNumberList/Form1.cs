/*
Prime Number List This exercise assumes you have already written the IsPrime function. Create another application that uses this function to display all the prime numbers from 1 through 100 in a list box.The program should have a loop that calls the IsPrime function.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_06_09_PrimeNumberList
{
  public partial class frmPrimeNumberList : Form
  {
    public frmPrimeNumberList()
    {
      InitializeComponent();
    }

    private void btnDisplayList_Click(object sender, EventArgs e)
    {
      for (int i = 1; i <= 100; i++)
      {
        if (IsPrime(i))
          lstOutput.Items.Add(i);
      }
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
