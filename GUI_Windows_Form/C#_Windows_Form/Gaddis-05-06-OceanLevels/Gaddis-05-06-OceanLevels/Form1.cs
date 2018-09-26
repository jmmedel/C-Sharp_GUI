/*
 * Done
Ocean Levels Assuming the ocean’s level is currently rising at about 1.5 millimeters per year, create an application that displays the number of millimeters that the ocean will have risen each year for the next 10 years.Display the output in a ListBox control.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_05_06_OceanLevels
{
  public partial class frmOceanLevels : Form
  {
    public frmOceanLevels()
    {
      InitializeComponent();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      const int NUM_OF_YEARS = 10;
      const decimal LEVEL_INCREASE = 1.5m;
      decimal result = 0;

      lstOutput.Items.Add("Year \t\t Level Increase");
      for (int i = 1; i <= NUM_OF_YEARS; i++)
      {
        result += LEVEL_INCREASE;
        lstOutput.Items.Add(i + "\t\t" + result + "mm");
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
