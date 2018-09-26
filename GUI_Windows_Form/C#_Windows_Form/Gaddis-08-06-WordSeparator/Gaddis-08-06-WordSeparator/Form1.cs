/*
Word Separator Create an application that accepts as input a sentence in which all the words are run together but the first character of each word is uppercase.Convert the sentence to a string in which the words are separated by spaces and only the first word starts with an uppercase letter.For example the string "StopAndSmellTheRoses." would be converted to "Stop and smell the roses." 
*/
using System;
using System.Windows.Forms;

namespace Gaddis_08_06_WordSeparator
{
  public partial class frmWordSeparator : Form
  {
    public frmWordSeparator()
    {
      InitializeComponent();
    }

    private void btnSeparateWords_Click(object sender, EventArgs e)
    {
      string input = txtInput.Text.Trim();
      string separatedWords = "";
      int counter = 0;

      foreach(char c in input)
      {
        if (char.IsUpper(c) && counter != 0)
        {
          separatedWords += " ";
          separatedWords += char.ToLower(c);
        }
        else
          separatedWords += c;

        counter++;
      }

      txtOutput.Text = separatedWords;
    }
  }
}
