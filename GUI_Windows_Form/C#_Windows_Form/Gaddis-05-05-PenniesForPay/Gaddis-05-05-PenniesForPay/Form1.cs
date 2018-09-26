/*
Pennies for Pay Susan is hired for a job, and her employer agrees to pay her every day.Her employer also agrees that Susan’s salary is 1 penny the first day, 2 pennies the second day, 4 pennies the third day, continuing to double each day.Create an application that allows the user to enter the number of days that Susan will work and calculates the total amount of pay she will receive over that period of time.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_05_05_PenniesForPay
{
  public partial class frmPenniesForPay : Form
  {
    public frmPenniesForPay()
    {
      InitializeComponent();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      int numDays;
      decimal pay = 0.01m;

      if (int.TryParse(txtNumOfDays.Text, out numDays))
      {
        lstOutput.Items.Add("Day \t\t Pay");

        for (int i = 1; i <= numDays; i++)
        {
          if (i == 1)
            lstOutput.Items.Add(i + "\t\t" + pay.ToString("C"));
          else
          {
            pay *= 2;
            lstOutput.Items.Add(i + "\t\t" + pay.ToString("C"));
          }
        }
      }
      else
        MessageBox.Show("Please enter valid number of days");
    }


    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
