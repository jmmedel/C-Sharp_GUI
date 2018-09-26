/*
Population Data In the Chap07 folder of the Student Sample Programs, you will find a file named USPopulation.txt.The file contains the midyear population of the United States, in thousands, during the years 1950 through 1990. The first line in the file contains the population for 1950, the second line contains the population for 1951, and so forth.Create an application that reads the file’s contents into an array or a List.The application should display the following data: 
• The average annual change in population during the time period 
• The year with the greatest increase in population during the time period 
• The year with the least increase in population during the time period
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Gaddis_07_07_PopulationData
{
  public partial class frmPopulationData : Form
  {
    public frmPopulationData()
    {
      InitializeComponent();
    }

    private void btnStatistics_Click(object sender, EventArgs e)
    {
      try
      {
        StreamReader sr = new StreamReader("USPopulation.txt");
        List<int> years = new List<int>();

        string line;
        int actualIncrease;
        int largestIncrease;
        int smallestIncrease;
        int smallestIncreaseYear = 0;
        int largestIncreaseYear = 0;
        int sumOfIncreases = 0;

        while (!sr.EndOfStream)
        {
          line = sr.ReadLine();
          years.Add(Convert.ToInt32(line));
        }

        largestIncrease = 0;
        smallestIncrease = years[1] - years[0];

        for (int i = 0; i < years.Count - 1; i++)
        {
          actualIncrease = years[i + 1] - years[i];
          lstOutput.Items.Add("Increase between year " + (1950 + i) + " and " + (1950 + i + 1) + "    " + actualIncrease);
          sumOfIncreases += actualIncrease;

          if (actualIncrease <= smallestIncrease)
          {
            smallestIncrease = actualIncrease;
            smallestIncreaseYear = 1950 + i;
          }

          if (actualIncrease >= largestIncrease)
          {
            largestIncrease = actualIncrease;
            largestIncreaseYear = 1950 + i;
          }
        }

        double avg = sumOfIncreases / years.Count;

        lstOutput.Items.Add("Average Increase is: " + (avg * 1000).ToString("n2"));
        lstOutput.Items.Add("Largest Increase: " + (largestIncrease * 1000).ToString("n2") + " happened in the year " +
                            largestIncreaseYear);
        lstOutput.Items.Add("Smallest Increase: " + (smallestIncrease * 1000).ToString("n2") + " happened in the year " +
                            smallestIncreaseYear);

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }     
    }
  }
}
