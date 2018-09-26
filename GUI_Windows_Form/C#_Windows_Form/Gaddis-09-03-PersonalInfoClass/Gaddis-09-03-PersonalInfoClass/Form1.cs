/*
Personal Information Class Create a class that holds the following personal data in properties: name, address, age, and phone number.Demonstrate the class in an application that creates three instances of the class. One instance should hold your information, and the other two should hold your friends’ or family members’ information.Display each object’s properties on the application’s form.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_09_03_PersonalInfoClass
{
  public partial class frmPersonalInfo : Form
  {
    public frmPersonalInfo()
    {
      InitializeComponent();
    }

    InputForm inputForm;
    private void btnAddPerson_Click(object sender, EventArgs e)
    {
      inputForm = new InputForm();
      inputForm.ShowDialog();
      DisplayInfo();
    }

    private void DisplayInfo()
    {
      foreach(PersonalInfo p in inputForm.infoList)
      {
        txtOutput.Text += p.ToString();
        txtOutput.Text += Environment.NewLine;
      }
    }
  }
}
