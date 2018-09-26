/*
Book Club Points Serendipity Booksellers has a book club that awards points to its customers based on the number of books purchased each month. The points are awarded as follows: 
• If a customer purchases 0 books, he or she earns 0 points. 
• If a customer purchases 1 book, he or she earns 5 points. 
• If a customer purchases 2 books, he or she earns 15 points. 
• If a customer purchases 3 books, he or she earns 30 points. 
• If a customer purchases 4 or more books, he or she earns 60 points.
Create an application that lets the user enter the number of books that he or she has purchased this month and displays the number of points awarded.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_04_06_BookClubPoints
{
  public partial class frmBookClubPoints : Form
  {
    public frmBookClubPoints()
    {
      InitializeComponent();
    }

    private void btnCalculatePoints_Click(object sender, EventArgs e)
    {
      const int BOOKS_PURCHASED_0 = 0;
      const int BOOKS_PURCHASED_1 = 5;
      const int BOOKS_PURCHASED_2 = 15;
      const int BOOKS_PURCHASED_3 = 30;
      const int BOOKS_PURCHASED_4 = 60;

      int numOfBooksPurchased;
      int pointsEarned;

      if (int.TryParse(txtNumOfPurchasedBooks.Text, out numOfBooksPurchased) &&
        numOfBooksPurchased >=0)
      {
        switch (numOfBooksPurchased)
        {
          case 0:
            pointsEarned = BOOKS_PURCHASED_0;
            break;
          case 1:
            pointsEarned = BOOKS_PURCHASED_1;
            break;
          case 2:
            pointsEarned = BOOKS_PURCHASED_2;
            break;
          case 3:
            pointsEarned = BOOKS_PURCHASED_3;
            break;
          default:
            pointsEarned = BOOKS_PURCHASED_4;
            break; 
        }

        txtEarnedPoints.Text = pointsEarned.ToString("n");
      }
      else
        MessageBox.Show("Please enter a valid number", "Invalid Input");
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
