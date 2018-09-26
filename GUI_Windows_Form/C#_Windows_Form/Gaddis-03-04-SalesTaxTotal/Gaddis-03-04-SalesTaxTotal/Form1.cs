/*
Sales Tax and Total Create an application that allows the user to enter the amount of a purchase.The program should then calculate the state and county sales tax. Assume the state sales tax is 4 percent and the county sales tax is 2 percent. The program should display the amount of the purchase, the state sales tax, the county sales tax, the total sales tax, and the total of the sale (which is the sum of the amount of purchase plus the total sales tax).
*/
using System;
using System.Windows.Forms;

namespace Gaddis_03_04_SalesTaxTotal
{
  public partial class frmSalesTax : Form
  {
    public frmSalesTax()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
        //onclick
    private void btnCalculate_Click(object sender, EventArgs e)
    {
      double salesAmount;
      const double STATE_TAX = 0.04; //4%
      const double COUNTY_TAX = 0.02;//2%
      double totalSalesTax;
      double totalSales;
      double totalStateTax;
      double totalCountyTax;

      salesAmount = Convert.ToDouble(txtSalesAmount.Text);
      totalStateTax = salesAmount * STATE_TAX;
      totalCountyTax = salesAmount * COUNTY_TAX;
      totalSalesTax = totalStateTax + totalCountyTax;
      totalSales = totalSalesTax + salesAmount;

      lstOutput.Items.Add("Sales Amount: " + salesAmount.ToString("C"));
      lstOutput.Items.Add("State Tax: " + totalStateTax.ToString("C"));
      lstOutput.Items.Add("County Tax: " + totalCountyTax.ToString("C"));
      lstOutput.Items.Add("Total Sales Tax: " + totalSalesTax.ToString("C"));
      lstOutput.Items.Add("Total Amount: " + totalSales.ToString("C"));
    }
  }
}
