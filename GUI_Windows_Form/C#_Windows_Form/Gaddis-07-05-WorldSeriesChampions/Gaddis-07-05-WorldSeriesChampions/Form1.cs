/*
World Series Champions In the Chap07 folder of the Student Sample Programs, you will find the following files: 
• Teams.txt—This file contains a list of several Major League baseball teams in alphabetical order.Each team listed in the file has won the World Series at least once.
• WorldSeriesWinners.txt—This file contains a chronological list of the World Series’ winning teams from 1903 through 2012. (The first line in the file is the name of the team that won in 1903, and the last line is the name of the team that won in 2012. Note that the World Series was not played in 1904 or 1994.) Create an application that displays the contents of the Teams.txt file in a ListBox control.When the user selects a team in the ListBox, the application should display the number of times that team has won the World Series in the time period from 1903 through 2012.
TIP: Read the contents of the WorldSeriesWinners.txt file into a List or an array. When the user selects a team, an algorithm should step through the list or array counting the number of times the selected team appears.
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Gaddis_07_05_WorldSeriesChampions
{
  public partial class frmWorldSeriesChampions : Form
  {
    public frmWorldSeriesChampions()
    {
      InitializeComponent();
    }

    string[] teams;
    string[] champions;
    private void btnDisplayChampions_Click(object sender, EventArgs e)
    {
      lstChampions.Items.Clear();

      try
      {
        teams = File.ReadAllLines("Teams.txt");
        champions = File.ReadAllLines("WorldSeriesWinners.txt");

        foreach(string value in teams)
        {
          lstChampions.Items.Add(value);
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void lstChampions_SelectedIndexChanged(object sender, EventArgs e)
    {
      int count = 0;
      int i = 0;
      List<int> years = new List<int>();

      foreach (string value in champions)
      {
        if (lstChampions.Text.Equals(value))
        {
          count++;
          years.Add(i + 1903); //we start with 1903 year
        }
        i++;
      }

      string teamName = lstChampions.Text;
      lstChampions.Items.Clear();
      lstChampions.Items.Add("Team " + teamName + " won World Series " + count + " times");
      lstChampions.Items.Add("They won in years: ");
      foreach(int value in years)
      {
        lstChampions.Items.Add(value);
      }
    }
  }
}
