/*
Most Frequent Character Create an application that lets the user enter a string and displays the character that appears most frequently in the string. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gaddis_08_05_MostFrequentCharacter
{
  public partial class frmMostFrequentCharacter : Form
  {
    public frmMostFrequentCharacter()
    {
      InitializeComponent();
    }

    List<char> distinctChars = new List<char>();
    private void btnDisplay_Click(object sender, EventArgs e)
    {
      string input = txtInput.Text.Trim();
      GetDistinctChars(input);
      char mostFrequent = GetMostFrequentChar(input);

      MessageBox.Show("Most frequent character is: " + mostFrequent);
    }

    private char GetMostFrequentChar(string s)
    {
      //array that has the same number of elements as the distict char list
      int[] charIndex = new int[distinctChars.Count];

      //compare each distinct character with all chars in the string
      //if match is found, increase the value if index corresponding with the index of that distinct character
      for (int i = 0; i < distinctChars.Count; i++)
      {
        for (int c = 0; c < s.Length; c++)
        {
          if (distinctChars[i] == s[c])
            charIndex[i] += 1;
        }
      }

      //get the index with highest value. This corresponds with number of occurences of a letter of the same index from the distinctChar list
      int index = Array.IndexOf(charIndex, charIndex.Max());
      return distinctChars[index];
    }

    private void GetDistinctChars(string s)
    {
      foreach(char c in s)
      {
        if (!distinctChars.Contains(c) && c != ' ')
          distinctChars.Add(c);
      }
    }
  }
}
