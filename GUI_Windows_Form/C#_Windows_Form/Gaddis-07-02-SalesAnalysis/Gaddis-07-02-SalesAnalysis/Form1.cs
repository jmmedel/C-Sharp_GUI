/*
Sales Analysis Modify the application that you created in Programming Exercise 1 so it also displays the following: 
• The average of the values in the array 
• The largest value in the array 
• The smallest value in the array
*/
using System;
using System.IO;
using System.Windows.Forms;

namespace Gaddis_07_02_SalesAnalysis
{
  public partial class frmSalesAnalysis : Form
  {
    public frmSalesAnalysis()
    {
      InitializeComponent();
    }

    double smallest;
    double largest;
    double sum;

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      try
      {
        string[] allLines = File.ReadAllLines("Sales.txt");
        double[] numbers = new double[allLines.Length];
        int counter = 0;
        sum = 0;

        smallest = Convert.ToDouble(allLines[0]);
        largest = Convert.ToDouble(allLines[0]);

        //populate numbers from allLines to numbers[]
        foreach (string value in allLines)
        {
          numbers[counter] = Convert.ToDouble(value);
          lstOutput.Items.Add(numbers[counter]);

          Sum(numbers[counter]);
          SmallestNumber(numbers[counter]);
          LargestNumber(numbers[counter]);
          
          counter++;
        }

        lstOutput.Items.Add("\nTotal: " + sum.ToString("n"));
        lstOutput.Items.Add("Average: " + Average(counter).ToString("n"));
        lstOutput.Items.Add("Smallest: " + smallest.ToString("n"));
        lstOutput.Items.Add("Largest: " + largest.ToString("n"));
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void Sum(double number)
    {
      sum += number;
    }

    private void SmallestNumber(double number)
    {
      if (number < smallest)
        smallest = number;
    }

    private void LargestNumber(double number)
    {
      if (number > largest)
        largest = number;
    }

    private double Average(int numberCount)
    {
      return sum / numberCount;
    }
  }
}
