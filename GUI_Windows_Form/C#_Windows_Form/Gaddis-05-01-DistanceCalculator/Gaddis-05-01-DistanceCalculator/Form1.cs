/*
Distance Calculator If you know a vehicle’s speed and the amount of time it has traveled, you can calculate the distance it has traveled as follows: 
Distance = Speed × Time 
For example, if a train travels 40 miles per hour for 3 hours, the distance traveled is 120 miles. The user enters a vehicle’s speed and the number of hours traveled into text boxes. When the user clicks the Calculate button, the application should use a loop to display in a list box the distance the vehicle has traveled for each hour of that time period.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_05_01_DistanceCalculator
{
  public partial class frmDistanceCalculator : Form
  {
    public frmDistanceCalculator()
    {
      InitializeComponent();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      int speed;
      int hours;
      int distance;

      lstOutput.Items.Clear();

      if (int.TryParse(txtSpeed.Text, out speed) && int.TryParse(txtHours.Text, out hours))
      {
        for (int i = 1; i <= hours; i++)
        {
          distance = speed * i;
          lstOutput.Items.Add("After hour " + i + " the vehicle traveled " + distance.ToString("n") + " miles");
        }
      }
      else
        MessageBox.Show("Please enter valid numbers", "Invalid Input");      
    }


    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
