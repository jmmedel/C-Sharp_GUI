/*
 * Done
Population Create an application that predicts the approximate size of a population of organisms.The application should use text boxes to allow the user to enter the starting number of organisms, the average daily population increase (as a percentage), and the number of days the organisms will be left to multiply.For example, assume the user enters the following values: 
Starting number of organisms: 2 
Average daily increase: 30% 
Number of days to multiply: 10 
The application should display the table of data in a ListBox control.
*/ 
using System;
using System.Windows.Forms;

namespace Gaddis_05_04_Population
{
  public partial class frmPopulation : Form
  {
    public frmPopulation()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      int startingNumber;
      int dailyIncrease;
      int numOfDays;
      decimal population;

      if (int.TryParse(txtStartingNumber.Text, out startingNumber) &&
        int.TryParse(txtDailyIncrease.Text, out dailyIncrease) &&
        int.TryParse(txtNumOfDays.Text, out numOfDays))
      {
        population = startingNumber;

        lstOutput.Items.Add("Days              Approx. Population");
        for (int i = 1; i <= numOfDays; i++)
        {
          if (i == 1)
          {
            lstOutput.Items.Add(i + "\t\t" + population);
          }
          else
          {
            population += population * (dailyIncrease / 100m);
            lstOutput.Items.Add(i + "\t\t" + population.ToString("n2"));
          }          
        }
      }
      else
        MessageBox.Show("Please enter valid numbers", "Invalid Input");
    }
  }
}
