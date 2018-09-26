/*
Vowels and Consonants Create an application with a method that accepts a string as an argument and returns the number of vowels that the string contains.The application should have another method that accepts a string as an argument and returns the number of consonants that the string contains. The application should let the user enter a string, and should display the number of vowels and the number of consonants it contains.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_08_04_VowelsAndConsonants
{
  public partial class frmVowelsAndConsonants : Form
  {
    public frmVowelsAndConsonants()
    {
      InitializeComponent();
    }

    private void btnCount_Click(object sender, EventArgs e)
    {
      string input = txtInput.Text.Trim();
      int validLettersCount = CountValidLetters(input);

      int vowelCount = CountVowels(input);
      int constCount = CountConsonants(validLettersCount, vowelCount);

      MessageBox.Show("Vowel Count: " + vowelCount + "\n" +
                      "Consonant Count: " + constCount);
    }
    
    private int CountConsonants(int validLettersCount, int vowelCount)
    {
      return validLettersCount - vowelCount;
    }   

    private int CountVowels(string s)
    {
      int count = 0;
      char[] vowels = { 'a', 'e', 'o', 'i', 'u' };

      for (int i = 0; i < s.Length; i++)
      {
        for (int v = 0; v < vowels.Length; v++)
        {
          if (s.ToLower()[i] == vowels[v])
            count++;
        }
      }

      return count;
    }
    
    private int CountValidLetters(string s)
    {
      int count = 0;
      foreach(char c in s)
      {
        if (char.IsLetter(c))
          count++;
      }

      return count;
    } 
  }
}
