/*
E-Mail Address Book Create an application with a class named PersonEntry.The PersonEntry class should have properties for a person’s name, e-mail address, and phone number.Also, create a text file that contains the names, e-mail addresses, and phone numbers for at least five people. When the application starts, it should read the data from the file and create a PersonEntry object for each person’s data. The PersonEntry objects should be added to a List, and each person’s name should be displayed in a list box on the application’s main form.When the user selects a name from the list box, a second form should appear displaying that person’s name, e-mail address, and phone number.
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Gaddis_09_07_EmailAddressBook
{
  public partial class frmInputData : Form
  {
    public frmInputData()
    {
      InitializeComponent();
    }

    public static List<PersonEntry> persons = new List<PersonEntry>();
    public static int selectedPerson;

    private void frmInputData_Load(object sender, EventArgs e)
    {
      try
      {
        StreamReader sr = new StreamReader("Data.txt");
        while (!sr.EndOfStream)
        {
          string[] s = sr.ReadLine().Split(',');
          PersonEntry person = new PersonEntry(s[0], s[1], s[2]);
          persons.Add(person);
        }

        PopulateListBox();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void lstData_SelectedIndexChanged(object sender, EventArgs e)
    {
      //MessageBox.Show(lstData.SelectedIndex.ToString());
      selectedPerson = lstData.SelectedIndex;
      frmDisplayData form2 = new frmDisplayData();
      form2.ShowDialog();
    }

    private void PopulateListBox()
    {
      foreach(PersonEntry p in persons)
      {
        lstData.Items.Add(p.Name);
      }
    }
  }
}
