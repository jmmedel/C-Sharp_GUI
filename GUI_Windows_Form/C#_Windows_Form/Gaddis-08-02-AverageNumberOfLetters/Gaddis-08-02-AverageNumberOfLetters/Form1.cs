/*
Average Number of Letters Modify the program you wrote for Problem 1 (Word Counter) so it also displays the average number of letters in each word.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_08_02_AverageNumberOfLetters
{
  public partial class frmWordCounter : Form
  {
    public frmWordCounter()
    {
      InitializeComponent();
    }

    private void btnCountWords_Click(object sender, EventArgs e)
    {
      string words = txtString.Text.Trim();
      int wordCount = CountWords(words);
      double avgLetterCount = AvgLetterCount(words, wordCount);

      MessageBox.Show("Number of Words: " + wordCount + "\n" +
                      "Average Letter Count: " + avgLetterCount);
    }

    private double AvgLetterCount(string words, int wordCount)
    {
      int letterCount = LetterCount(words);
      return letterCount * 1.00 / wordCount;
    }

    private int LetterCount(string words)
    {
      string finalString = "";
      foreach(char c in words)
      {
        if (c != ' ')
          finalString += c;
      }

      return finalString.Length;
    }

    private int CountWords(string words)
    {
      string[] allWords = words.Split(' ');     

      return allWords.Length;
    }
  }
}
