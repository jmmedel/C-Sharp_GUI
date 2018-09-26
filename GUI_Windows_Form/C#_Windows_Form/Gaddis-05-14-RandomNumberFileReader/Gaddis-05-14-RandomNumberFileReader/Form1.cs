/*
 * Done
Random Number File Reader This exercise assumes you have completed Programming Problem 13, Random Number File Writer. Create another application that uses an OpenFileDialog control to let the user select the file that was created by the application that you wrote for Problem 13. This application should read the numbers from the file, display the numbers in a ListBox control, and then display the following data: 
• The sum of the numbers 
• The number of random numbers read from the file
*/
using System;
using System.IO;
using System.Windows.Forms;

namespace Gaddis_05_14_RandomNumberFileReader
{
  public partial class frmRandomNumberFileReader : Form
  {
    public frmRandomNumberFileReader()
    {
      InitializeComponent();
    }

    private void btnReadFile_Click(object sender, EventArgs e)
    {
      ofdOpenFile.ShowDialog();
      if (ofdOpenFile.ShowDialog() == DialogResult.OK)
      {
        int sum = 0;
        int count = 0;
        int number;

        StreamReader inputFile = new StreamReader(ofdOpenFile.FileName);

        while (!inputFile.EndOfStream)
        {
          number = Convert.ToInt32(inputFile.ReadLine());
          sum += number;
          count++;

          lstOutput.Items.Add(number);
        }

        lstOutput.Items.Add("Total numbers in the file: " + count);
        lstOutput.Items.Add("Sum of all numbers is :" + sum);
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
