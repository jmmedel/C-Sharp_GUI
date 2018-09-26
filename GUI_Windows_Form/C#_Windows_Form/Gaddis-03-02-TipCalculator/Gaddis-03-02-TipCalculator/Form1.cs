/*
Tip, Tax, and Total Create an application that lets the user enter the food charge for a meal at a restaurant. When a button is clicked, the application should calculate and display the amount of a 15 percent tip, 7 percent sales tax, and the total of all three amounts.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_03_02_TipCalculator
{
  public partial class frmTipCalculator : Form
  {
    public frmTipCalculator()
    {
      InitializeComponent();
    }

    private void frmTipCalculator_Load(object sender, EventArgs e)
    {

    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      const double TIP = 0.15; //15%
      const double SALES_TAX = 0.07;//7%
      double costOfMeal;
      double totalAmountDue;

      costOfMeal = Convert.ToDouble(txtMealCost.Text);
      totalAmountDue = costOfMeal + (costOfMeal * TIP) + (costOfMeal * SALES_TAX);

      lstOutput.Items.Add("Cost Of Meal: " + costOfMeal.ToString("C"));
      lstOutput.Items.Add("Sales Tax: " + SALES_TAX.ToString("P"));
      lstOutput.Items.Add("Tip: " + TIP.ToString("P"));
      lstOutput.Items.Add("Total Amount Due: " + totalAmountDue.ToString("C"));
    }
  }
}
