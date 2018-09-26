/*
Morse Code Converter Design a program that asks the user to enter a string and then converts that string to Morse code.Morse code is a code where each letter of the English alphabet, each digit, and various punctuation characters are represented by a series of dots and dashes.Table 8-7shows part of the code.
*/
using System;
using System.IO;
using System.Windows.Forms;

namespace Gaddis_08_10_MorseCode
{
  public partial class frmMorseCode : Form
  {
    public frmMorseCode()
    {
      InitializeComponent();
    }
    //http://morsecode.scphillips.com/translator.html
    private void btnTranslate_Click(object sender, EventArgs e)
    {
      string[] file = File.ReadAllLines("MorseCode.txt");
      string input = txtInput.Text.Trim();
      string morseCode = "";

      for (int i = 0; i < input.Length; i++)
      {
        for (int c = 0; c < file.Length; c++)
        {
          if (file[c].Substring(0,1) == input[i].ToString().ToUpper())
          {
            morseCode += file[c].Substring(1);
          }
        }
      }
      //Pavol is a awesome programmer!
      //.--. .- ...- --- .-.. / .. ... / .- / .- .-- . ... --- -- . / .--. .-. --- --. .-. .- -- -- . .-. #
      //.--. .- ...- --- .-.. / .. ... / .- / .- .-- . ... --- -- . / .--. .-. --- --. .-. .- -- -- . .-. 

      string finalCode = morseCode.Replace("   ", " / ");
      txtMorseCode.Text = finalCode;
    }
  }
}
