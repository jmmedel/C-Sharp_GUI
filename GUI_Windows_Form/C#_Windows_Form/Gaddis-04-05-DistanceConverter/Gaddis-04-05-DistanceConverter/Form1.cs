/*
Distance Converter In the English measurement system, 1 yard equals 3 feet and 1 foot equals 12 inches.Use this information to create an application that lets the user convert distances to and from inches, feet, and yards. The user enters the distance to be converted into a TextBox.A ListBox allows the user to select the units being converted from, and another ListBox allows the user to select the units being converted to.
  Note: Be sure to handle the situation where the user picks the same units from both list boxes.The converted value will be the same as the value entered.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_04_05_DistanceConverter
{
  public partial class frmDistanceConverter : Form
  {
    public frmDistanceConverter()
    {
      InitializeComponent();
    }    

    private void btnConvert_Click(object sender, EventArgs e)
    {
      //1 ft = 12" - ft to inch                    1" = 1/12 ft  - inch to ft    
      //1 yard = 3 feet - yard to ft               1 ft = 1/3 yards  - ft to yard
      //1 yard = 3 (ft) x 12" - yard to inch       1"  = 1 / (3x12)  -  inch to yard

      const decimal INCH_TO_FOOT = 1m / 12;
      const decimal INCH_TO_YARD = 1m / (3 * 12);
      const decimal FOOT_TO_INCH = 12m;
      const decimal FOOT_TO_YARD = 1m / 3;
      const decimal YARD_TO_INCH = 3m * 12;
      const decimal YARD_TO_FOOT = 3m;

      decimal distanceToConvert;
      decimal convertedDistance;

      if (decimal.TryParse(txtDistanceInput.Text, out distanceToConvert))
      {
        string from = lstConvertFrom.SelectedItem.ToString().ToUpper();
        string to = lstConvertTo.SelectedItem.ToString().ToUpper();

        if (from == "INCHES" && to == "FEET")
          convertedDistance = distanceToConvert * INCH_TO_FOOT;
        else if (from == "INCHES" && to == "YARDS")
          convertedDistance = distanceToConvert * INCH_TO_YARD;
        else if (from == "FEET" && to == "INCHES")
          convertedDistance = distanceToConvert * FOOT_TO_INCH;
        else if (from == "FEET" && to == "YARDS")
          convertedDistance = distanceToConvert * FOOT_TO_YARD;
        else if (from == "YARDS" && to == "INCHES")
          convertedDistance = distanceToConvert * YARD_TO_INCH;
        else if (from == "YARDS" && to == "FEET")
          convertedDistance = distanceToConvert * YARD_TO_FOOT;
        else
          convertedDistance = distanceToConvert; //if using the same units

        txtDinstanceOutput.Text = convertedDistance.ToString("n2");
      }
      else
        MessageBox.Show("Please enter valid number", "Invalid Input");
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}
