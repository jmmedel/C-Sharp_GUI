/*
Person and Customer Classes Design a class named Person with properties for holding a person’s name, address, and telephone number.Next, design a class named Customer, which is derived from the Person class. The Customer class should have a property for a customer number and a Boolean property indicating whether the customer wishes to be on a mailing list.Demonstrate an object of the Customer class in a simple application.
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
      bool onMailingList = chkOnMailingList.Checked ? true : false;

      Customer customer = new Customer(id, name, address, phone, onMailingList);
      txtOutput.Text = customer.ToString();
    }
  }
}
