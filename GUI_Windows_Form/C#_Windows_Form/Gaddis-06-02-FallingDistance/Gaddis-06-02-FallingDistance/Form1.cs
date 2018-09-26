/*
 * Done
Falling Distance When an object is falling because of gravity, the following formula can be used to determine the distance the object falls in a specific time period: 
d = 1/2 gt(pow of 2)
The variables in the formula are as follows: 
d is the distance in meters, 
g is 9.8, 
and t is the amount of time in seconds that the object has been falling.
Create an application that allows the user to enter the amount of time that an object has fallen and then displays the distance that the object fell. The application should have a function named FallingDistance. The FallingDistance function should accept an object’s falling time (in seconds) as an argument.The function should return the distance in meters that the object has fallen during that time interval.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_06_02_FallingDistance
{
  public partial class frmFallingDistance : Form
  {
    const double g = 9.8;  
    public frmFallingDistance()
    {
      InitializeComponent();
    }
    
    private void btnCalculate_Click(object sender, EventArgs e)
    {
      double t;
      if (double.TryParse(txtTime.Text, out t))
      {
        double d = FallingDistance(t);
        txtDistanceFallen.Text = d.ToString("n") + " meters";
      }
      else
        MessageBox.Show("Please enter valid time in seconds", "Invalid Input");
    }

    private double FallingDistance(double t)
    {
      double d = 0.5 * g * Math.Pow(t, 2);
      return d;
    }
  }
}
