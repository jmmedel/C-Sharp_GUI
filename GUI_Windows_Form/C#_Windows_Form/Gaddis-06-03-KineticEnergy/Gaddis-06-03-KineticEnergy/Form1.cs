/*
 * Done
Kinetic Energy In physics, an object that is in motion is said to have kinetic energy.The following formula can be used to determine a moving object’s kinetic energy: 
KE = 1/2 mv(pow of 2)
In the formula KE is the kinetic energy, m is the object’s mass in kilograms, and v is the object’s velocity in meters per second.Create an application that allows the user to enter an object’s mass and velocity and then displays the object’s kinetic energy. The application should have a function named KineticEnergy that accepts an object’s mass(in kilograms) and velocity(in meters per second) as arguments.The function should return the amount of kinetic energy that the object has.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_06_03_KineticEnergy
{
  public partial class frmKineticEnergy : Form
  {
    public frmKineticEnergy()
    {
      InitializeComponent();
    }
    private void btnCalculate_Click(object sender, EventArgs e)
    {
      double m;
      double v;

      if (double.TryParse(txtMass.Text, out m) && double.TryParse(txtVelocity.Text, out v))
      {
        double KE = KineticEnergy(m, v);
        txtKineticEnergy.Text = KE.ToString("n");
      }
      else
        MessageBox.Show("Please enter valid numbers", "Invalid Input");
    }

    private double KineticEnergy(double m, double v)
    {
      double KE = 0.5 * m * Math.Pow(v, 2);
      return KE;
    }
  }
}
