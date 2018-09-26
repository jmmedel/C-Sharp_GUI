/*
Alphabetic Telephone Number Translator Many companies use telephone numbers like 555-GET-FOOD so the number is easier for their customers to remember.On a standard telephone, the alphabetic letters are mapped to numbers in the following fashion: 
A, B, and C = 2 
D, E, and F = 3 
G, H, and I = 4 
J, K, and L = 5 
M, N, and O = 6 
P, Q, R, and S = 7 
T, U, and V = 8 
W, X, Y, and Z = 9 
Create an application that lets the user enter a 10-character telephone number in the format XXX-XXX-XXXX.The application should display the telephone number with any alphabetic characters that appeared in the original translated to their numeric equivalent.For example, if the user enters 555-GET-FOOD, the application should display 555-438-3663.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_08_09_AlphabeticTelephoneNumber
{
  public partial class frmAlphabeticPhoneNumber : Form
  {
    public frmAlphabeticPhoneNumber()
    {
      InitializeComponent();
    }

    char[][] letters =
    {
      new char[] { ' ' },
      new char[] { ' ' },
      new char[] { 'A', 'B', 'C' },
      new char[] { 'D', 'E', 'F' },
      new char[] { 'G', 'H', 'I' },
      new char[] { 'J', 'K', 'L' },
      new char[] { 'M', 'N', 'O' },
      new char[] { 'P', 'Q', 'R','S' },
      new char[] { 'T', 'U', 'V' },
      new char[] { 'W', 'X', 'Y','Z' }
    };

    private void btnGetPhoneNumber_Click(object sender, EventArgs e)
    {
      string alphaNumber = txtAlphaNumber.Text;
      string areaCode = alphaNumber.Substring(0, 3) + "-";
      string letterPartOfPhoneNumber = alphaNumber.Substring(4);
      string phoneNumber = areaCode;
      
      foreach(char c in letterPartOfPhoneNumber)
      {
        for (int i = 2; i < letters.Length; i++)
        {
          char[] innerArray = letters[i];
          for (int a = 0; a < innerArray.Length; a++)
          {
            if (char.ToUpper(c) == innerArray[a])
            {
              if (phoneNumber.Length == 7)
                phoneNumber += "-";

              phoneNumber += i.ToString();
            }                          
          }
        }
      }

      txtPhoneNumber.Text = phoneNumber;
    }
  }
}
