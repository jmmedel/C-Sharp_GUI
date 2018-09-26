/*
Slot Machine Simulation A slot machine is a gambling device into which the user inserts money and then pulls a lever(or presses a button). The slot machine then displays a set of random images.If two or more of the images match, the user wins an amount of money that the slot machine dispenses back to the user. 
Create an application that simulates a slot machine. The application should let the user enter into a TextBox the amount of money he or she is inserting into the machine. When the user clicks the Spin button, the application should display three randomly selected symbols. (Slot machines traditionally display fruit symbols. If none of the randomly displayed images match, the program should inform the user that he or she has won $0. If two of the images match, the program should inform the user that he or she has won two times the amount entered.If three of the images match, the program should inform the user that he or she has won three times the amount entered.When the user clicks the Exit button to exit the application, the program should display the total amount of money entered into the slot machine and the total amount won.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_08_12_SlotMachineSimulation
{
  public partial class frmSlotMachine : Form
  {
    public frmSlotMachine()
    {
      InitializeComponent();
    }

    decimal totalInserted = 0.0m;
    decimal totalWinnings = 0.0m; 

    private void btnSpin_Click(object sender, EventArgs e)
    {
      decimal winningAmount = 0.0m;
      decimal amountInserted = 0.0m;

      if (decimal.TryParse(txtAmountInserted.Text, out amountInserted) && amountInserted > 0)
      {
        Random rand = new Random();
        int pic_1 = rand.Next(0, 3);
        int pic_2 = rand.Next(0, 3);
        int pic_3 = rand.Next(0, 3);

        pic1.Image = imgList.Images[pic_1];
        pic2.Image = imgList.Images[pic_2];
        pic3.Image = imgList.Images[pic_3];

        totalInserted += amountInserted;
        totalWinnings += winningAmount = GetWinningAmount(pic_1, pic_2, pic_3, amountInserted);
      }
      else
        MessageBox.Show("Please insert money first");
    }

    private decimal GetWinningAmount(int p1, int p2, int p3, decimal amountInserted)
    {
      if (p1 == p2 && p2 == p3)
      {
        return amountInserted * 3;
      }
      else if (p1 == p2 || p1 == p3 || p2 == p3)
      {
        return amountInserted * 2;
      }

      return 0;
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Total Inserted: " + totalInserted.ToString("C") + "\n" +
                      "Total Won: " + totalWinnings.ToString("C"));

      Application.Exit();
    }
  }
}
