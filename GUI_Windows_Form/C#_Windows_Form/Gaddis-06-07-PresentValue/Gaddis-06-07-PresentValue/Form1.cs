/*
Present Value Suppose you want to deposit a certain amount of money into a savings account and then leave it alone to draw interest for the next 10 years.At the end of 10 years you would like to have $10,000 in the account.How much do you need to deposit today to make that happen? You can use the following formula, which is known as the present-value formula, to find out: 
P = F / (1 + r)(pow of n) 
The terms in the formula are as follows: 
• P is the present value, or the amount that you need to deposit today. 
• F is the future value that you want in the account. (In this case, F is $10,000.)
• r is the annual interest rate. 
• n is the number of years that you plan to let the money sit in the account. 
Write a method named PresentValue that performs this calculation.The method should accept the future value, annual interest rate, and number of years as arguments.It should return the present value, which is the amount that you need to deposit today. Demonstrate the method in an application that lets the user experiment with different values for the formula’s terms.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_06_07_PresentValue
{ 
  public partial class frmPresentValue : Form
  {
    public frmPresentValue()
    {
      InitializeComponent();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      double F; //future value
      double r; //interest rate
      int n; //number of years
      double P; //present value

      if (double.TryParse(txtFutureValue.Text, out F) && double.TryParse(txtInterestRate.Text, out r) &&
        int.TryParse(txtYears.Text, out n))
      {
        P = CalcPresentValue(F, r, n);
        txtPresentValue.Text = P.ToString("C");
      }
      else
        MessageBox.Show("Please enter valid values", "Invalid input");
    }

    private double CalcPresentValue(double F, double r, int n)
    {
      double P;
      P = F / Math.Pow((1 + (r / 100)), n);
      return P;
    }
  }
}
