/*
Magic Dates The date June 10, 1960, is special because when it is written in the following format, the month times the day equals the year: 6/10/60 Create an application that lets the user enter a month (in numeric form), a day, and a two-digit year. The program should then determine whether the month times the day equals the year. If so, it should display a message saying the date is magic. Otherwise, it should display a message saying the date is not magic.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_04_03_MagicDates
{
  public partial class frmMagicDates : Form
  {
    public frmMagicDates()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnDetermineMagicDate_Click(object sender, EventArgs e)
    {
      int month;
      int day;
      int year;

      if (int.TryParse(txtMonth.Text, out month))
      {
        if (int.TryParse(txtDay.Text, out day))
        {
          year = Convert.ToInt32(txtYear.Text);
          int result = month * day;

          if (result == year)
          {
            MessageBox.Show("This is a magic date");
          }
          else
          {
            MessageBox.Show("This is NOT a magic date");
          }
        }
        else
        {
          MessageBox.Show("Invalid Day", "Invalid Input");
        }
      }
      else
      {
        MessageBox.Show("Invalid Month", "Invalid input");
      }

    }
  }
}
