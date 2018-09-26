/*
 * Done
Change for a Dollar Game Create a change-counting game that gets the user to enter the number of coins required to make exactly one dollar.The program should let the user enter the number of pennies, nickels, dimes, and quarters. If the total value of the coins entered is equal to one dollar, the program should congratulate the user for winning the game.Otherwise, the program should display a message indicating whether the amount entered was more than or less than one dollar.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_04_09_ChangeForDollar
{
  public partial class frmChangeForDollar : Form
  {
    public frmChangeForDollar()
    {
      InitializeComponent();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      const int PENNIES = 1;
      const int NICKLES = 5;
      const int DIMES = 10;
      const int QUARTERS = 25;

      int pennies;
      int nickels;
      int dimes;
      int quarters;
      int sum;

      if (int.TryParse(txtPennies.Text, out pennies) && int.TryParse(txtNickles.Text, out nickels) &&
        int.TryParse(txtDimes.Text, out dimes) && int.TryParse(txtQuarters.Text, out quarters))
      {
        sum = (pennies * PENNIES) + (nickels * NICKLES) + (dimes * DIMES) + (quarters * QUARTERS);

        if (sum == 100)
          txtOutput.Text = "Congratulations! The sum equals $1";
        else if (sum > 100)
          txtOutput.Text = "The amount is greater than a dollar. " + (sum / 100m).ToString("C");
        else
          txtOutput.Text = "The amount is less than a dollar. " + (sum / 100m).ToString("C");
      }
      else
        MessageBox.Show("Please enter valid numbers", "Invalid Input");
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
