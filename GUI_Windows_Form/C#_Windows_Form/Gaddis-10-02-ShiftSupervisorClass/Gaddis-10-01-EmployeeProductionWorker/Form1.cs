/*
ShiftSupervisor Class In a particular factory, a shift supervisor is a salaried employee who supervises a shift. In addition to a salary, the shift supervisor earns a yearly bonus when his or her shift meets production goals. Create a ShiftSupervisor class that is derived from the Employee class you created in Programming Problem 1. The ShiftSupervisor class should have a property that holds the annual salary and a property that holds the annual production bonus that a shift supervisor has earned. Demonstrate the class in an application.
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
      decimal bonus = radSupervisor.Checked ? Convert.ToDecimal(txtBonus.Text) : 0m;

      if (radWorker.Checked)
      {
        ProductionWorker worker = new ProductionWorker(name, id, shift, pay);
        txtOutput.Text = worker.ToString();
      } 
      else
      {
        ShiftSupervisor supervisor = new ShiftSupervisor(name, id, shift, pay, bonus);
        txtOutput.Text = supervisor.ToString();
      }
    }

    private void radWorker_CheckedChanged(object sender, EventArgs e)
    {
      txtBonus.Text = "";
      txtBonus.Enabled = false;
    }

    private void radSupervisor_CheckedChanged(object sender, EventArgs e)
    {
      txtBonus.Enabled = true;
    }
  }
}
