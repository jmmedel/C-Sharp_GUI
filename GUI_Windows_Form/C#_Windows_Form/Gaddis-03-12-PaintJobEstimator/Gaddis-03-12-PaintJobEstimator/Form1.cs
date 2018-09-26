/*
Paint Job Estimator A painting company has determined that for every 115 square feet of wall space, 1 gallon of paint and 8 hours of labor will be required. The company charges $20.00 per hour for labor. Create an application that allows the user to enter the square feet of wall space to be painted and the price of the paint per gallon. The program should display the following data: 
• The number of gallons of paint required 
• The hours of labor required
• The cost of the paint 
• The labor charges 
• The total cost of the paint job
 */
using System;
using System.Windows.Forms;

namespace Gaddis_03_12_PaintJobEstimator
{
  public partial class frmPaintJobEstimator : Form
  {
    public frmPaintJobEstimator()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      const int SQUARE_FEET = 115;
      const int HOUR_LABOR_COST = 20;

      decimal feetPaintedPerHour = SQUARE_FEET / 8m;
      decimal gallonsPerFoot = 1m / SQUARE_FEET;

      int squareFeetToPaint = Convert.ToInt32(txtSquareFeet.Text);
      decimal costPerGallon = Convert.ToDecimal(txtCostOfPaint.Text);

      decimal gallonsNeeded = squareFeetToPaint * gallonsPerFoot;
      decimal laborHoursNeeded = squareFeetToPaint / feetPaintedPerHour;
      decimal costOfPaint = gallonsNeeded * costPerGallon;
      decimal laborCharge = laborHoursNeeded * HOUR_LABOR_COST;
      decimal totalCostOfJob = laborCharge + costOfPaint;

      lstOutput.Items.Add("Gallons Needed: " + gallonsNeeded.ToString("n2"));
      lstOutput.Items.Add("Hours Of Labor Needed: " + laborHoursNeeded.ToString("n2"));
      lstOutput.Items.Add("Cost Of Paint: " + costOfPaint.ToString("C"));
      lstOutput.Items.Add("Labor Charges: " + laborCharge.ToString("C"));
      lstOutput.Items.Add("Total Cost Of Job: " + totalCostOfJob.ToString("C"));
    }
  }
}
