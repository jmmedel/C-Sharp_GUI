/*
Name Formatter Create an application that lets the user enter the following pieces of data: 
• The user’s first name 
• The user’s middle name 
• The user’s last name 
• The user’s preferred title(Mr., Mrs., Ms., Dr., etc.) 

Assume the user has entered the following data: • First name: Kelly • Middle name: Jane • Last name: Smith • Title: Ms.
The application should have buttons that display the user’s name formatted in the following ways: 
Ms.Kelly Jane Smith 
Kelly Jane Smith 
Kelly Smith 
Smith, Kelly Jane, Ms. 
Smith, Kelly Jane 
Smith, Kelly
*/
using System;
using System.Windows.Forms;

namespace Gaddis_03_01_NameFormatter
{
  public partial class frmNameFormatter : Form
  {
    public frmNameFormatter()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnFormatName_Click(object sender, EventArgs e)
    {
      string firstName;
      string middleName;
      string lastName;
      string title;

      firstName = txtFirstName.Text;
      middleName = txtMiddleName.Text;
      lastName = txtLastName.Text;
      title = txtTitle.Text;

      lstOutput.Items.Add(title + " " + firstName + " " + middleName + " " + lastName);//Ms.Kelly Jane Smith 
      lstOutput.Items.Add(firstName + " " + middleName + " " + lastName);//Kelly Jane Smith 
      lstOutput.Items.Add(firstName + " " + lastName); //Kelly Smith 
      lstOutput.Items.Add(lastName + ", " + firstName + " " + middleName + ", " + title); //Smith, Kelly Jane, Ms. 
      lstOutput.Items.Add(lastName + ", " + firstName + " " + middleName); //Smith, Kelly Jane 
      lstOutput.Items.Add(lastName + ", " + firstName);//Smith, Kelly
    }
  }
}
