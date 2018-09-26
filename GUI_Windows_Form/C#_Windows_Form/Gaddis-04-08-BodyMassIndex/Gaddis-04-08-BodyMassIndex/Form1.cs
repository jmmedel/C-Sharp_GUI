/*
 * Done
A person’s BMI is calculated with the following formula: BMI = Weight × 703 ÷ Height(power of 2) In the formula, weight is measured in pounds and height is measured in inches. Enhance the program so it displays a message indicating whether the person has optimal weight, is underweight, or is overweight.A person’s weight is considered to be optimal if his or her BMI is between 18.5 and 25. If the BMI is less than 18.5, the person is considered to be underweight. If the BMI value is greater than 25, the person is considered to be overweight.
*/

using System;
using System.Windows.Forms;

namespace Gaddis_04_08_BodyMassIndex
{
  public partial class frmBMI : Form
  {
    public frmBMI()
    {
      InitializeComponent();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      const double UNDERWEIGHT = 18.5;
      const double OVERWEIGHT = 25;

      double weight;
      double height;
      double bmi;
      string bodyType;

      if (double.TryParse(txtHeight.Text, out height) && double.TryParse(txtWeight.Text, out weight))
      {
        bmi = weight * 703 / Math.Pow(height, 2);

        if (bmi < UNDERWEIGHT)
          bodyType = "Under Weight";
        else if (bmi > OVERWEIGHT)
          bodyType = "Over Weight";
        else
          bodyType = "Optimal";

        txtBMI.Text = bmi.ToString("n2");
        txtBodyType.Text = bodyType;
      }
      else
        MessageBox.Show("Please enter valid height and weight", "Invalid Input");
    }


    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
