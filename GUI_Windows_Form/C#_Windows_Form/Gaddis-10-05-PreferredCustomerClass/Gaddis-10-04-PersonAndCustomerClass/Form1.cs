/*
PreferredCustomer Class A retail store has a preferred customer plan where customers can earn discounts on all their purchases. The amount of a customer’s discount is determined by the amount of the customer’s cumulative purchases in the store as follows: 
• When a preferred customer spends $500, he or she gets a 5 percent discount on all future purchases. 
• When a preferred customer spends $1,000, he or she gets a 6 percent discount on all future purchases.
• When a preferred customer spends $1,500, he or she gets a 7 percent discount on all future purchases.
• When a preferred customer spends $2,000 or more, he or she gets a 10 percent discount on all future purchases. 
Design a class named PreferredCustomer, which is derived from the Customer class you created in Programming Problem 4. The PreferredCustomer class should have properties for the amount of the customer’s purchases and the customer’s discount level. Demonstrate the class in a simple application.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_10_04_PersonAndCustomerClass
{
  public partial class frmCustomers : Form
  {
    public frmCustomers()
    {
      InitializeComponent();
    }

    private void btnDisplay_Click(object sender, EventArgs e)
    {
      int id = Convert.ToInt32(txtId.Text);
      string name = txtName.Text;
      string address = txtAddress.Text;
      string phone = txtPhone.Text;
      decimal amountSpent = Convert.ToDecimal(txtAmountSpent.Text);
      bool onMailingList = chkOnMailingList.Checked ? true : false;

      PreferredCustomer customer = new PreferredCustomer(id, name, address, phone, onMailingList, amountSpent);

      txtOutput.Text = customer.ToString();
    }
  }
}
