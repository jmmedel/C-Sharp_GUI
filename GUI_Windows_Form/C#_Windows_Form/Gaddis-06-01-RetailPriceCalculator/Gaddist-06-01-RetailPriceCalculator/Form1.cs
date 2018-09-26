/*
 * Done
Retail Price Calculator Create an application that lets the user enter an item’s wholesale cost and its markup percentage. It should then display the item’s retail price. For example: 
• If an item’s wholesale cost is $5.00 and its markup percentage is 100 percent, then the item’s retail price is $10.00. 
• If an item’s wholesale cost is $5.00 and its markup percentage is 50 percent, then the item’s retail price is $7.50. 
The program should have a method named CalculateRetail that receives the wholesale cost and the markup percentage as arguments and returns the retail price of the item.
*/
using System;
using System.Windows.Forms;

namespace Gaddist_06_01_RetailPriceCalculator
{
  public partial class frmRetailPriceCalculator : Form
  {
    public frmRetailPriceCalculator()
    {
      InitializeComponent();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      double wholesale;
      double markup;

      if (double.TryParse(txtWholesaleCost.Text, out wholesale) && double.TryParse(txtMarkupPercent.Text, out markup))
      {
        double retailPrice;
        retailPrice = CalculateRetail(wholesale, markup);
        txtRetailPrice.Text = retailPrice.ToString("C");
      }
      else
        MessageBox.Show("Please enter valid numbers", "Invalid Input");
    }

    private double CalculateRetail(double wholesale, double markup)
    {
      double markupPercent = markup / 100;
      double retailPrice;

      retailPrice = wholesale + (wholesale * markupPercent);
      return retailPrice;
    }
    
  }
}
