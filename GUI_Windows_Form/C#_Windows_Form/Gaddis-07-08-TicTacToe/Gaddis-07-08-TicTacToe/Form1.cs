/*
Tic-Tac-Toe Simulator Create an application that simulates a game of tic-tac-toe.The form uses eight large Label controls to display the Xs and Os.The application should use a two-dimensional int array to simulate the game board in memory.When the user clicks the New Game button, the application should step through the array, storing a random number in the range of 0 through 1 in each element. The number 0 represents the letter O, and the number 1 represents the letter X. The form should then be updated to display the game board.The application should display a message indicating whether player X won, player Y won, or the game was a tie.
*/
using System;
using System.Linq;
using System.Windows.Forms;

namespace Gaddis_07_08_TicTacToe
{
  public partial class frmTicTacToe : Form
  {
    public frmTicTacToe()
    {
      InitializeComponent();
    }

    char[,] gameBoard;
    string[,] labels;
    Random rand;
    char currentTurn;
    int moveCounter;

    private void btnPlay_Click(object sender, EventArgs e)
    {
      Initialize();
      bool endOfRound = false;
      int whoWins;

      do
      {
        MakeMove();
        whoWins = WhoWins();
        if (whoWins == 1 || whoWins == 2)
        {
          txtMessage.Text = currentTurn + " wins!";
          endOfRound = true;
        }
        else if (whoWins == 0 && moveCounter == 9) //no more available plays
        {
          txtMessage.Text = "It's a tie!";
          endOfRound = true;
        }

        moveCounter++;
        SwitchTurn();
      }
      while (!endOfRound);
    }

    private void SwitchTurn()
    {
      if (currentTurn == 'X')
        currentTurn = 'O';
      else
        currentTurn = 'X';
    }

    private void MakeMove()
    {
      int row;
      int col;

      do
      {
        row = rand.Next(0, 3);
        col = rand.Next(0, 3);
      } while (!ValidateMove(row, col));

      gameBoard[row, col] = currentTurn;
      UpdateForm(row, col);
    }

    private int WhoWins()
    {
      //player 1 wins
      if (gameBoard[0, 0] == 'X' && gameBoard[0, 1] == 'X' && gameBoard[0, 2] == 'X') //1st row
        return 1;
      else if (gameBoard[1, 0] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[1, 2] == 'X') //2 row
        return 1;
      else if (gameBoard[2, 0] == 'X' && gameBoard[2, 1] == 'X' && gameBoard[2, 2] == 'X') //3 row
        return 1;
      else if (gameBoard[0, 0] == 'X' && gameBoard[1, 0] == 'X' && gameBoard[2, 0] == 'X') //1st col
        return 1;
      else if (gameBoard[0, 1] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[2, 1] == 'X') //2nd col
        return 1;
      else if (gameBoard[0, 2] == 'X' && gameBoard[1, 2] == 'X' && gameBoard[2, 2] == 'X') //3rd col
        return 1;
      else if (gameBoard[0, 0] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[2, 2] == 'X') //across left to right
        return 1;
      else if (gameBoard[0, 2] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[2, 0] == 'X') //acros right to left
        return 1;

      //player 2 wins
      if (gameBoard[0, 0] == 'O' && gameBoard[0, 1] == 'O' && gameBoard[0, 2] == 'O')
        return 2;
      else if (gameBoard[1, 0] == 'O' && gameBoard[1, 1] == 'O' && gameBoard[1, 2] == 'O')
        return 2;
      else if (gameBoard[2, 0] == 'O' && gameBoard[2, 1] == 'O' && gameBoard[2, 2] == 'O')
        return 2;
      else if (gameBoard[0, 0] == 'O' && gameBoard[1, 0] == 'O' && gameBoard[2, 0] == 'O')
        return 2;
      else if (gameBoard[0, 1] == 'O' && gameBoard[1, 1] == 'O' && gameBoard[2, 1] == 'O')
        return 2;
      else if (gameBoard[0, 2] == 'O' && gameBoard[1, 2] == 'O' && gameBoard[2, 2] == 'O')
        return 2;
      else if (gameBoard[0, 0] == 'O' && gameBoard[1, 1] == 'O' && gameBoard[2, 2] == 'O')
        return 2;
      else if (gameBoard[0, 2] == 'O' && gameBoard[1, 1] == 'O' && gameBoard[2, 0] == 'O')
        return 2;

      return 0; //tie or contine playing
    }

    private void UpdateForm(int row, int col)
    {
      foreach (Label l in Controls.OfType<Label>())
      {
        if (l.Name.EndsWith(row.ToString()+col.ToString()))
        {
          l.Text = currentTurn.ToString();
        }
      }
    }

    private bool ValidateMove(int row, int col)
    {
      if (gameBoard[row, col] != ' ') //invalid move
        return false;

      return true;
    }

    private void Initialize()
    {
      rand = new Random();
      gameBoard = new char[3, 3];
      labels = new string[3, 3];
      moveCounter = 1;

      currentTurn = rand.Next(0, 2) == 0 ? 'X' : 'O';

      for (int r = 0; r < 3; r++)
      {
        for (int c = 0; c < 3; c++)
        {
          gameBoard[r, c] = ' ';
          labels[r, c] = "lbl" + r + c;
        }
      }

      foreach(Label l in Controls.OfType<Label>())
      {
        l.Text = " ";
      }
    }
   

    private void btnExit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}
