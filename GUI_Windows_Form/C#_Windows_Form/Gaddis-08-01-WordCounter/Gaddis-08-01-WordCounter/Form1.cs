/*
Word Counter Create an application with a method that accepts a string as an argument and returns the number of words it contains.
For instance, if the argument is "Four score and seven years ago," the method should return the number 6. The application should let the user enter a string, and then it should pass the string to the method. The number of words in the string should be displayed.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_08_01_WordCounter
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
      MessageBox.Show("Number of Words: " + CountWords(words));
    }

    private int CountWords(string words)
    {
      string[] allWords = words.Split(' ');
      return allWords.Length;
    }
  }
}
