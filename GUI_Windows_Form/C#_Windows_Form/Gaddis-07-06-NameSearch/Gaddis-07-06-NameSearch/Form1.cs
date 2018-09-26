/*
Name Search In the Chap07 folder of the Student Sample Programs, you will find the following files: 
• GirlNames.txt—This file contains a list of the 200 most popular names given to girls born in the United States from 2000 through 2009. 
• BoyNames.txt—This file contains a list of the 200 most popular names given to boys born in the United States from 2000 through 2009. 
Create an application that reads the contents of the two files into two separate arrays or Lists. The user should be able to enter a boy’s name, a girl’s name, or both, and the application should display messages indicating whether the names were among the most popular.
*/
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Gaddis_07_06_NameSearch
{
  public partial class frmNameSearch : Form
  {
    public frmNameSearch()
    {
      InitializeComponent();
    }

    private void btnFind_Click(object sender, EventArgs e)
    {
      string searchForBoyName = txtBoyName.Text;
      string searchForGirlName = txtGirlName.Text;
      int counter = 0;
      string message = "";
      bool found = false;

      try
      {
        string[] boyNames = File.ReadAllLines("BoyNames.txt");
        List<string> girlNames = new List<string>();

        foreach (string value in boyNames)
        {
          if (boyNames[counter].ToUpper() == searchForBoyName.ToUpper() && searchForBoyName != "")
          {
            message += searchForBoyName + " was the #" + (counter + 1) + " boy's name\n";
            found = true;
            break;
          }

          counter++;
        }

        if (!found && searchForBoyName != "")
          message += searchForBoyName + " was NOT found in boys names!\n";

        StreamReader sr = new StreamReader("GirlNames.txt");
        string line;
        while (!sr.EndOfStream)
        {
          line = sr.ReadLine();
          girlNames.Add(line);
        }

        if (girlNames.Contains(searchForGirlName, StringComparer.OrdinalIgnoreCase))
        {
          string name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(searchForGirlName);
          counter = girlNames.IndexOf(name);
          message += searchForGirlName + " was the #" + (counter + 1) + " girl's name\n";
          found = true;
        }
        else if (searchForGirlName != "")
          message += searchForGirlName + " was NOT found in girls names!\n";


        MessageBox.Show(message);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}
