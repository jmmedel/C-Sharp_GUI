/*
Roman Numeral Converter Create an application that allows the user to enter an integer between 1 and 10 into a TextBox control.The program should display the Roman numeral version of that number. If the number is outside the range of 1 through 10, the program should display an error message.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_04_01_RomanNumeralConverter
{
  public partial class frmRomanNumeralConverter : Form
  {
    public frmRomanNumeralConverter()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnConvertToRomanNumeral_Click(object sender, EventArgs e)
    {
      const string ROMAN_1 = "I";
      const string ROMAN_2 = "II";
      const string ROMAN_3 = "III";
      const string ROMAN_4 = "IV";
      const string ROMAN_5 = "V";
      const string ROMAN_6 = "VI";
      const string ROMAN_7 = "VII";
      const string ROMAN_8 = "VIII";
      const string ROMAN_9 = "IX";
      const string ROMAN_10 = "X";

      int number = 0;
      if (int.TryParse(txtNumber.Text,out number))
      {
        if (number >= 1 && number <= 10)
        {
          switch (number)
          {
            case 1:
              lblRomanNumeral.Text = ROMAN_1;
              break;
            case 2:
              lblRomanNumeral.Text = ROMAN_2;
              break;
            case 3:
              lblRomanNumeral.Text = ROMAN_3;
              break;
            case 4:
              lblRomanNumeral.Text = ROMAN_4;
              break;
            case 5:
              lblRomanNumeral.Text = ROMAN_5;
              break;
            case 6:
              lblRomanNumeral.Text = ROMAN_6;
              break;
            case 7:
              lblRomanNumeral.Text = ROMAN_7;
              break;
            case 8:
              lblRomanNumeral.Text = ROMAN_8;
              break;
            case 9:
              lblRomanNumeral.Text = ROMAN_9;
              break;
            default:
              lblRomanNumeral.Text = ROMAN_10;
              break;
          }
        }
        else
        {
          MessageBox.Show("The number must be between 1 and 10", "Invalid Input");
        }
      }
      else
      {
        MessageBox.Show("Invalid Input. Please enter a valid number 1 through 10", "Invalid Input");
      }
    }
  }
}
