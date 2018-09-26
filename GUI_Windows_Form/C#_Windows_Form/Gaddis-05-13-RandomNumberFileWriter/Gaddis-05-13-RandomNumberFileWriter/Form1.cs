/*
 * Done
Random Number File Writer Create an application that writes a series of random numbers to a file. Each random number should be in the range of 1 through 100. The application should let the user specify how many random numbers the file will hold and should use a SaveFileDialog control to let the user specify the file’s name and location.
*/
using System;
using System.IO;
using System.Windows.Forms;

namespace Gaddis_05_13_RandomNumberFileWriter
{
  public partial class frmRandomNumberFileWriter : Form
  {
    public frmRandomNumberFileWriter()
    {
      InitializeComponent();
    }

    private void btnWriteFile_Click(object sender, EventArgs e)
    {
      Random rand = new Random();
      int howManyNumbers;
      int randomNumber;

      if (int.TryParse(txtHowManyNumbers.Text, out howManyNumbers))
      {
        if (sfdSaveFile.ShowDialog() == DialogResult.OK)
        {
          StreamWriter outputFile;
          outputFile = File.CreateText(sfdSaveFile.FileName);
          
          for (int i = 0; i < howManyNumbers; i++)
          {
            randomNumber = rand.Next(1, 101);
            outputFile.WriteLine(randomNumber);
          }
          outputFile.Close();
        }
      }
      else
        MessageBox.Show("Please enter valid number", "Invalid Input");
    }


    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
