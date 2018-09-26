/*
Celsius-to-Fahrenheit Table Assuming that C is a Celsius temperature, the following formula converts the temperature to a Fahrenheit temperature(F): F = 9/5 * C + 32 Create an application that displays a table of the Celsius temperatures 0–20 and their Fahrenheit equivalents.The application should use a loop to display the temperatures in a list box.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_05_03_CelsiusToFahrenheitTable
{
  public partial class frmCelsiusToFahrenheitTable : Form
  {
    public frmCelsiusToFahrenheitTable()
    {
      InitializeComponent();
    }

    private void btnCreateTable_Click(object sender, EventArgs e)
    {
      const int MIN_TEMPERATURE = 0;
      const int MAX_TEMPERATURE = 20;
      decimal f;

      lstTable.Items.Add("         CELSIUS \t       FAHRENHEIT");
      for (int i = MIN_TEMPERATURE; i <= MAX_TEMPERATURE; i++)
      {
        f = (9m / 5) * i + 32;
        lstTable.Items.Add("\t" + i + "\t\t" + f);
      }
    }


    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
