/*
Distance File Modify the Distance Calculator program that you wrote for Programming Problem 1 so it writes its output to a file instead of displaying it in a ListBox control. Open the file in Notepad or Visual Studio to confirm the output.
*/
using System;
using System.IO;
using System.Windows.Forms;

namespace Gaddis_05_01_DistanceCalculator
{
  public partial class frmDistanceCalculator : Form
  {
    public frmDistanceCalculator()
    {
      InitializeComponent();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      int speed;
      int hours;
      int distance;

      if (int.TryParse(txtSpeed.Text, out speed) && int.TryParse(txtHours.Text, out hours))
      {
        try
        {
          StreamWriter outputFile;
          outputFile = File.CreateText("Distance.txt");

          for (int i = 1; i <= hours; i++)
          {
            distance = speed * i;
            outputFile.WriteLine("After hour " + i + " the vehicle traveled " + distance.ToString("n") + " miles");
          }

          outputFile.Close();
          MessageBox.Show("File was created");
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);
        }
        
      }
      else
        MessageBox.Show("Please enter valid numbers", "Invalid Input");      
    }


    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
