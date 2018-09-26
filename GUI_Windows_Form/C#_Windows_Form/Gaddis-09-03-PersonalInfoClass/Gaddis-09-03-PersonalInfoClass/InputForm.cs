using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gaddis_09_03_PersonalInfoClass
{
  public partial class InputForm : Form
  {
    public InputForm()
    {
      InitializeComponent();
    }

    public List<PersonalInfo> infoList = new List<PersonalInfo>();
    string name;
    string address;
    string phone;
    int age;

    private void btnSubmit_Click(object sender, EventArgs e)
    {
      if (ValidateInput())
      {
        PersonalInfo info = new PersonalInfo(name, address, age, phone);
        infoList.Add(info);
        MessageBox.Show("Info Submitted");
      }
      else
        MessageBox.Show("Please enter valid input", "Invalid input");
    }

    private bool ValidateInput()
    {
      name = txtName.Text;
      address = txtAddress.Text;
      phone = txtPhone.Text;

      if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(address) &&
        !string.IsNullOrWhiteSpace(phone) && int.TryParse(txtAge.Text, out age))
      {
        return true;
      }
      else
        return false;
    }

    private void btnDisplay_Click(object sender, EventArgs e)
    {
      if (infoList.Count > 0)
        this.Close();
      else
        MessageBox.Show("No info was submitted yet!");
    }
  }
}
