/*
Employee and ProductionWorker Classes Create an Employee class that has properties for the following data: 
• Employee name 
• Employee number 
Next, create a class named ProductionWorker that is derived from the Employee class. The ProductionWorker class should have properties to hold the following data: 
• Shift number(an integer, such as 1, 2, or 3) 
• Hourly pay rate 
The workday is divided into two shifts: day and night. The Shift property will hold an integer value representing the shift that the employee works.The day shift is shift 1 and the night shift is shift 2. Create an application that creates an object of the ProductionWorker class and lets the user enter data for each of the object’s properties.Retrieve the object’s properties and display their values.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaddis_10_01_EmployeeProductionWorker
{
  public partial class frmEmployee : Form
  {
    public frmEmployee()
    {
      InitializeComponent();
    }

    private void btnDisplay_Click(object sender, EventArgs e)
    {
      string name = txtName.Text;
      int id = Convert.ToInt32(txtId.Text);
      int shift = Convert.ToInt32(txtShift.Text);
      decimal pay = Convert.ToDecimal(txtPay.Text);

      ProductionWorker worker = new ProductionWorker(name, id, shift, pay);

      txtOutput.Text = worker.ToString();
    }
  }
}
