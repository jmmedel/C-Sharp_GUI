/*
Celsius and Fahrenheit Temperature Converter Assuming that C is a Celsius temperature, the following formula converts the temperature to Fahrenheit: 
F = (9/5) * C + 32 Assuming that F is a Fahrenheit temperature, the following formula converts the temperature to Celsius: 
C = (5/9) * (F − 32) Create an application that allows the user to enter a temperature.The application should have Button controls described as follows: • A button that reads Convert to Fahrenheit.If the user clicks this button, the application should treat the temperature that is entered as a Celsius temperature and convert it to Fahrenheit. • A button that reads Convert to Celsius.If the user clicks this button, the application should treat the temperature that is entered as a Fahrenheit temperature, and convert it to Celsius.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_3_5_TemperatureConverter
{
  public partial class frmTemperatureConverter : Form
  {
    public frmTemperatureConverter()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnToFahrenheit_Click(object sender, EventArgs e)
    {
      //F = (9/5) * C + 32
      decimal C;
      decimal F;
      C = Convert.ToDecimal(txtTemperature.Text);
      F = (9 / 5m) * C + 32;

      txtOutput.Text = F.ToString();
    }

    private void btnToCelsius_Click(object sender, EventArgs e)
    {
      //C = (5/9) * (F − 32)
      decimal F;
      decimal C;
      F = Convert.ToDecimal(txtTemperature.Text);
      C = (5 / 9m) * (F - 32);

      txtOutput.Text = C.ToString();
      
    }
  }
}
