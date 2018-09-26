/*
 * Done
Random Number Guessing Game Create an application that generates a random number in the range of 1 through 100 and asks the user to guess what the number is. If the user’s guess is higher than the random number, the program should display “Too high, try again.” If the user’s guess is lower than the random number, the program should display “Too low, try again.” If the user guesses the number, the application should congratulate the user and then generate a new random number so the game can start over.Optional Enhancement: Enhance the game so it keeps count of the number of guesses that the user makes. When the user correctly guesses the random number, the program should display the number of guesses.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_05_11_RandomNumberGuessingGame
{
  public partial class frmRandomNumberGuessingGame : Form
  {
    Random rand;
    int number;
    int guessCounter = 0;

    public frmRandomNumberGuessingGame()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      rand = new Random();
      number = rand.Next(1, 101);
      txtMessage.Text = "Can you guess what number I am thinking of?";
    }

    private void btnGuessNumber_Click(object sender, EventArgs e)
    {
      int guess;
      guessCounter++;

      if (int.TryParse(txtGuess.Text, out guess))
      {
        if(guess == number)
        {
          MessageBox.Show("Congratulations, you guessed the number correctly in " + guessCounter + " tries");
          txtMessage.Text = "Can you guess what number I am thinking of?";
          guessCounter = 0;
          txtGuess.Text = "";
          txtGuess.Focus();
          number = rand.Next(1, 101);
        }
        else if (guess < number)
          txtMessage.Text = "Sorry, Too low";
        else 
          txtMessage.Text = "Sorry, too high";
      }
      else
        MessageBox.Show("Please enter a valid number", "Invalid input");
    }
  }
}
