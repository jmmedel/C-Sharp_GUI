/*
Pig Latin Create an application that accepts a sentence as input and converts each word to “Pig Latin.” In one version, to convert a word to Pig Latin you remove the first letter and place that letter at the end of the word. Then you append the string "ay" to the word.Here is an example: English: I SLEPT MOST OF THE NIGHT Pig Latin: IAY LEPTSAY OSTMAY FOAY HETAY IGHTNAY
*/
using System;
using System.Windows.Forms;

namespace Gaddis_08_07_PigLatin
{
  public partial class frmPigLatin : Form
  {
    public frmPigLatin()
    {
      InitializeComponent();
    }

    const string SUFFIX = "AY";
    const string SPACE = " ";

    private void btnTranslate_Click(object sender, EventArgs e)
    {
      string english = txtEnglish.Text.Trim().ToUpper();
      string latin = "";
      string[] words = english.Split(' ');
      string latinWord = "";

      foreach(string s in words)
      {
        if (s != SPACE)
        {
          char firstChar = s[0];
          latinWord = s.Remove(0, 1) + firstChar + SUFFIX + SPACE;
          latin += latinWord;
        }
      }
      txtPigLatin.Text = latin;
    }
  }
}
