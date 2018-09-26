/*
Property Tax If you own real estate in a particular county, the property tax that you owe each year is calculated as 64 cents per $100 of the property’s value. For example, if the property’s value is $10,000, then the property tax is calculated as follows: Tax = $10,000 ÷ 100 × 0.64 Create an application that allows the user to enter a property’s value and displays the sales tax on that property.
*/ 
using System;
using System.Windows.Forms;

namespace Gaddis_03_13_PropertyTax
{
  public partial class frmPropertyTax : Form
  {
    public frmPropertyTax()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void btnCalculateTax_Click(object sender, EventArgs e)
    {
      const double CENTS_PER_HUNDRED = 0.64;
      int propertyValue = Convert.ToInt32(txtPropertyValue.Text);

      double propertyTax = propertyValue / 100 * CENTS_PER_HUNDRED;

      txtPropertyTax.Text = propertyTax.ToString("C");
    }
  }
}
