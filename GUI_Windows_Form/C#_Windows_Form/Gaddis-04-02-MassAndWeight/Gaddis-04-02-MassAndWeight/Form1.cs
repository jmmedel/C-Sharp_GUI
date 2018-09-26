/*
Mass and Weight Scientists measure an object’s mass in kilograms and its weight in Newtons. If you know the amount of mass of an object, you can calculate its weight, in Newtons, with the following formula: Weight = Mass × 9.8 Create an application that lets the user enter an object’s mass and then calculates its weight. If the object weighs more than 1000 Newtons, display a message indicating that it is too heavy. If the object weighs less than 10 Newtons, display a message indicating that it is too light.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_04_02_MassAndWeight
{
  public partial class frmMassAndWeight : Form
  {
    public frmMassAndWeight()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      lblWarning.Text = "";
      const double CONSTANT = 9.8;
      double mass = 0;


      if (double.TryParse(txtMass.Text, out mass))
      {
        double weight = mass * CONSTANT;
        txtWeight.Text = weight.ToString("n2");

        if (weight > 1000)
        {
          lblWarning.Text = "The object is too heavy";
        }
        else if (weight < 10)
        {
          lblWarning.Text = "The object is too light";
        }
      }
      else
      {
        MessageBox.Show("Please enter a valid number", "Invalid Input");
      }

    }
  }
}
