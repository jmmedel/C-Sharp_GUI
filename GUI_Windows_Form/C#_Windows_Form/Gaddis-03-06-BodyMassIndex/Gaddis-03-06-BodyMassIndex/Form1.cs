/*
Body Mass Index Create an application that lets the user enter his or her weight (in pounds) and height (in inches). The application should display the user’s body mass index (BMI). The BMI is often used to determine whether a person is overweight or underweight for his or her height. A person’s BMI is calculated with the following formula: BMI = weight × 703 ÷ height (to power of 2) 
*/
using System;
using System.Windows.Forms;

namespace Gaddis_03_06_BodyMassIndex
{
  public partial class frmBMI : Form
  {
    public frmBMI()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      /*
      decimal weight;
      decimal height;
      decimal bmi;

      weight = Convert.ToDecimal(txtWeight.Text);
      height = Convert.ToDecimal(txtHeight.Text);

      bmi = weight * 703 / (height * height);  
      */
      double weight;
      double height;
      double bmi;

      weight = Convert.ToDouble(txtWeight.Text);
      height = Convert.ToDouble(txtHeight.Text);

      bmi = weight * 703 / Math.Pow(height, 2);

      txtBMI.Text = bmi.ToString("n2");
    }
  }
}
