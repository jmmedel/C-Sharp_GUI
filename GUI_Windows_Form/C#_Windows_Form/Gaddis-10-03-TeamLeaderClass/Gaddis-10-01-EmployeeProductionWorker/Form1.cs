/*
TeamLeader Class In a particular factory, a team leader is an hourly paid productionworker that leads a small team. In addition to hourly pay, team leaders earn a fixed monthly bonus. Team leaders are required to attend a minimum number of hours of training per year. Design a TeamLeader class that is derived from the ProductionWorker class you created in Programming Problem 1. The TeamLeader class should have properties for the monthly bonus amount, the required number of training hours, and the number of training hours that the team leader has attended. Demonstrate the class in an application.
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
      decimal bonus = radSupervisor.Checked || radTeamLeader.Checked ? Convert.ToDecimal(txtBonus.Text) : 0m;
      int trainingHours = radTeamLeader.Checked ? Convert.ToInt32(txtTrainingHours.Text) : 0;

      if (radWorker.Checked)
      {
        ProductionWorker worker = new ProductionWorker(name, id, shift, pay);
        txtOutput.Text = worker.ToString();
      } 
      else if (radSupervisor.Checked)
      {
        ShiftSupervisor supervisor = new ShiftSupervisor(name, id, shift, pay, bonus);
        txtOutput.Text = supervisor.ToString();
      }
      else
      {
        TeamLeader teamLeader = new TeamLeader(name, id, shift, pay, bonus, trainingHours);
        txtOutput.Text = teamLeader.ToString();
      }
    }

    private void radWorker_CheckedChanged(object sender, EventArgs e)
    {
      txtBonus.Text = "";
      txtTrainingHours.Text = "";
      txtBonus.Enabled = false;
      txtTrainingHours.Enabled = false;
    }

    private void radSupervisor_CheckedChanged(object sender, EventArgs e)
    {
      txtBonus.Enabled = true;
      txtTrainingHours.Text = "";
      txtTrainingHours.Enabled = false;
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
      txtTrainingHours.Enabled = true;
      txtBonus.Enabled = true;
    }
  }
}
