/*
 * Done
Dice Simulator Create an application that simulates rolling a pair of dice.When the user clicks a button, the application should generate two random numbers, each in the range of 1 through 6, to represent the value of the dice.Use PictureBox controls to display the dice. (In the Student Sample Programs, in the Chap05 folder, you will find six images named Die1.bmp, Die2.bmp, Die3.bmp, Die4.bmp, Die5.bmp, and Die6.bmp that you can use in the PictureBoxes.)
*/
using System;
using System.Windows.Forms;

namespace Gaddis_05_09_DiceSimulator
{
  public partial class frmDiceSumulator : Form
  {
    public frmDiceSumulator()
    {
      InitializeComponent();
    }

    private void btnRollDice_Click(object sender, EventArgs e)
    {
      Random rand = new Random();
      int die = rand.Next(1, 7);

      switch(die)
      {
        case 1:
          picDie1.Image = Properties.Resources.Die1;
          break;
        case 2:
          picDie1.Image = Properties.Resources.Die2;
          break;
        case 3:
          picDie1.Image = Properties.Resources.Die3;
          break;
        case 4:
          picDie1.Image = Properties.Resources.Die4;
          break;
        case 5:
          picDie1.Image = Properties.Resources.Die5;
          break;
        case 6:
          picDie1.Image = Properties.Resources.Die6;
          break;
      }

      die = rand.Next(1, 7);
      switch (die)
      {
        case 1:
          picDie2.Image = Properties.Resources.Die1;
          break;
        case 2:
          picDie2.Image = Properties.Resources.Die2;
          break;
        case 3:
          picDie2.Image = Properties.Resources.Die3;
          break;
        case 4:
          picDie2.Image = Properties.Resources.Die4;
          break;
        case 5:
          picDie2.Image = Properties.Resources.Die5;
          break;
        case 6:
          picDie2.Image = Properties.Resources.Die6;
          break;
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
