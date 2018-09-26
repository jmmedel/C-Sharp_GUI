/*
Charge Account Validation In the Chap07 folder of the Student Sample Programs, you will find a file named ChargeAccounts.txt.The file contains a list of a company’s valid charge account numbers.There are a total of 18 charge account numbers in the file, and each one is a 7-digit number, such as 5658845. Create an application that reads the contents of the file into an array or a List. The application should then let the user enter a charge account number. The program should determine whether the number is valid by searching for it in the array or List that contains the valid charge account numbers.If the number is in the array or List, the program should display a message indicating the number is valid.If the number is not in the array or List, the program should display a message indicating the number is invalid.
*/
using System;
using System.IO;
using System.Windows.Forms;

namespace Gaddis_07_03_ChargeAccount
{
  public partial class frmChargeAccount : Form
  {
    public frmChargeAccount()
    {
      InitializeComponent();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
      string searchedAccount = txtSearch.Text;

      try
      {
        string[] accounts = File.ReadAllLines("ChargeAccounts.txt");
        bool found = false;

        for (int i = 0; i < accounts.Length; i++)
        {
          if (searchedAccount.Equals(accounts[i]))
          {
            found = true;
            break;
          }
        }

        if (found)
          MessageBox.Show(searchedAccount + " account number found");
        else
          MessageBox.Show(searchedAccount + " account NOT found");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}
