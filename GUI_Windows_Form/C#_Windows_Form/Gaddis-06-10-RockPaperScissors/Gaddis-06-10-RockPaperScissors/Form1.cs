/*
Rock, Paper, Scissors Game Create an application that lets the user play the game of Rock, Paper, Scissors against the computer.The program should work as follows. 
1. When the program begins, a random number in the range of 1 through 3 is generated.If the number is 1, then the computer has chosen rock.If the number is 2, then the computer has chosen paper. If the number is 3, then the computer has chosen scissors. (Do not display the computer’s choice yet.) 
2. The user selects his or her choice of rock, paper, or scissors.To get this input you can use Button controls, or clickable PictureBox controls displaying some of the artwork that you will find in the student sample files. 
3. The computer’s choice is displayed. 
4. A winner is selected according to the following rules: 
• If one player chooses rock and the other player chooses scissors, then rock wins. (Rock smashes scissors.) 
• If one player chooses scissors and the other player chooses paper, then scissors wins. (Scissors cuts paper.) 
• If one player chooses paper and the other player chooses rock, then paper wins. (Paper wraps rock.) 
• If both players make the same choice, the game must be played again to determine the winner.
Be sure to modularize the program into methods that perform each major task.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_06_10_RockPaperScissors
{
  public partial class frmRockPaperScissors : Form
  {
    Random rand = new Random();
    int computerChoice;
    int userChoice;
    int computerWinCount;
    int userWinCount;

    public frmRockPaperScissors()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      GetComputerChoice();
    }

    private void picRock_Click(object sender, EventArgs e)
    {
      userChoice = 1;
      WhoWins();
    }

    private void picPaper_Click(object sender, EventArgs e)
    {
      userChoice = 2;
      WhoWins();
    }

    private void picScissors_Click(object sender, EventArgs e)
    {
      userChoice = 3;
      WhoWins();
    }

    private void WhoWins()
    {
      if ((userChoice == 1 && computerChoice == 1) ||
        (userChoice == 2 && computerChoice == 2) ||
        (userChoice == 3 && computerChoice == 3))
      {
        txtMessage.Text = "You selected " + Choice(userChoice) +
          " and computer selected " + Choice(computerChoice) + ".\n It's a draw.";
      }
      else if ((userChoice == 1 && computerChoice == 2) ||
        (userChoice == 2 && computerChoice == 3) ||
        (userChoice == 3 && computerChoice == 1))
      {
        computerWinCount++;
        txtMessage.Text = "You selected " + Choice(userChoice) +
          " and computer selected " + Choice(computerChoice) + ".\n Computer Wins!";
      }
      else
      {
        userWinCount++;
        txtMessage.Text = "You selected " + Choice(userChoice) +
          " and computer selected " + Choice(computerChoice) + ".\n You Win!";
      }

      txtComputerScore.Text = computerWinCount.ToString();
      txtPlayerScore.Text = userWinCount.ToString();
      GetComputerChoice();
    }

    private string Choice(int n)
    {
      string rockPaperScissors = "";
      switch (n)
      {
        case 1:
          rockPaperScissors = "Rock";
          break;
        case 2:
          rockPaperScissors = "Paper";
          break;
        case 3:
          rockPaperScissors = "Scissors";
          break;
      }

      return rockPaperScissors;
    }

    private void GetComputerChoice()
    {
      computerChoice = rand.Next(1, 4);
    }
  }
}
