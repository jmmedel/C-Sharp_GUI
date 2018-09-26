/*
 * Done
Calories Burned Running on a particular treadmill, you burn 3.9 calories per minute.Create an application that uses a loop to display the number of calories burned after 10, 15, 20, 25, and 30 minutes. Display the output in a ListBox control.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_05_07_CaloriesBurned
{
  public partial class frmCaloriesBurned : Form
  {
    public frmCaloriesBurned()
    {
      InitializeComponent();
    }
    
    private void btnCalculate_Click(object sender, EventArgs e)
    {
      const int INCREMENT = 5;
      const int MIN_MINS = 10;
      const int MAX_MINS = 30;
      const decimal CALORIES_BURNED_PER_MIN = 3.9m;
      decimal result = 0.0m;

      lstOutput.Items.Add("Minutes \t     Calories Burned");
      for (int i = MIN_MINS; i <= MAX_MINS; i+=INCREMENT)
      {
        result = i * CALORIES_BURNED_PER_MIN;
        lstOutput.Items.Add(i + "\t\t" + result);
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

  }
}
