/*
Total Sales In the Chap07 folder of the Student Sample Programs, you will find a file named Sales.txt. Create an application that reads this file’s contents into an array, displays the array’s contents in a ListBox control, and calculates and displays the total of the array’s values.
*/
using System;
using System.IO;
using System.Windows.Forms;

namespace Gaddis_07_01_TotalSales
{
  public partial class frmTotalSales : Form
  {
    public frmTotalSales()
    {
      InitializeComponent();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      try
      {
        string[] allLines = File.ReadAllLines("Sales.txt");
        double[] numbers = new double[allLines.Length];
        int counter = 0;
        double sum = 0;

        //populate numbers from allLines to numbers[]
        foreach (string value in allLines)
        {
          numbers[counter] = Convert.ToDouble(value);
          sum += numbers[counter];
          lstOutput.Items.Add(numbers[counter]);
          counter++;
        }

        lstOutput.Items.Add("\nTotal: " + sum.ToString("n"));
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}
