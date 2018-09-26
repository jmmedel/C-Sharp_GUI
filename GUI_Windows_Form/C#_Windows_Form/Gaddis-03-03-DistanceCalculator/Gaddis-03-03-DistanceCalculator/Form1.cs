/*
Distance Traveled Assuming there are no accidents or delays, the distance that a car travels down an interstate highway can be calculated with the following formula: Distance = Speed × Time Create an application that allows the user to enter a car’s speed in miles per hour.The application should have buttons that display the following: • The distance the car will travel in 5 hours • The distance the car will travel in 8 hours • The distance the car will travel in 12 hours
*/
using System;
using System.Windows.Forms;

namespace Gaddis_03_03_DistanceCalculator
{
  public partial class frmDistanceCalculator : Form
  {
    public frmDistanceCalculator()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      int speed;
      decimal timeTravelled;
      decimal distance;

      speed = Convert.ToInt32(txtSpeed.Text);
      timeTravelled = Convert.ToDecimal(txtTime.Text);

      distance = speed * timeTravelled;

      txtDistance.Text = distance.ToString();
    }
  }
}
