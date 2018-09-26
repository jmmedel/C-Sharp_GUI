/*
How Much Insurance? Many financial experts advise that property owners should insure their homes or buildings for at least 80 percent of the amount it would cost to replace the structure. Create an application that lets the user enter the replacement cost of a building and then displays the minimum amount of insurance he or she should buy for the property.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_03_08_HowMuchInsurance
{
  public partial class frmInsurance : Form
  {
    public frmInsurance()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      const double PERCENTAGE = 0.8; //80%
      int replacementCost;
      double insurance;

      replacementCost = Convert.ToInt32(txtReplacementCost.Text);

      insurance = replacementCost * PERCENTAGE;

      txtInsurance.Text = insurance.ToString("C");
    }
  }
}
