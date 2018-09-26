/*
Sentence Capitalizer Create an application with a method that accepts a string as an argument and returns a copy of the string with the first character of each sentence capitalized.For instance, if the argument is "hello. my name is Joe. what is your name?" the method should return the string "Hello. My name is Joe. What is your name?" The application should let the user enter a string and then pass it to the method.The modified string should be displayed. 
*/
using System;
using System.Windows.Forms;

namespace Gaddis_08_03_SentenceCapitalizer
{
  public partial class frmSentenceCapitalizer : Form
  {
    public frmSentenceCapitalizer()
    {
      InitializeComponent();
    }

    private void btnCapitalize_Click(object sender, EventArgs e)
    {
      string sentences = txtSentence.Text.Trim();
      txtOutput.Text = CapitalizedSentences(sentences);
    }

    private string CapitalizedSentences(string s)
    {
      int counter = 0;
      string newString = "";
      int nextCaps = 0;

      foreach (char c in s)
      {
        if (char.IsPunctuation(c) && counter < s.Length - 1)
          nextCaps = counter + 2; //position of the next letter to capitalize

        if (counter == nextCaps || counter == 0)
          newString += s.ToUpper()[counter];
        else
          newString += s[counter];

        counter++;
      }

      return newString;
    }
  }
}
