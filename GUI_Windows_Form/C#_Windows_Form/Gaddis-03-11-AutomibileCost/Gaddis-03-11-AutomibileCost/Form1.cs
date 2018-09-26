/*
Automobile Costs Create an application that lets the user enter the monthly costs for the following expenses incurred from operating his or her automobile: loan payment, insurance, gas, oil, tires, and maintenance. The program should then display the total monthly cost of these expenses and the total annual cost of these expenses.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_03_11_AutomibileCost
{
  public partial class frmAutomobileCost : Form
  {
    public frmAutomobileCost()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
            double loanPayment;
            double insurance;
            double gas;
            double oil;
            double tires;
            double maintanance;
            try
            {
                 loanPayment = Convert.ToDouble(txtLoanPayment.Text);
                 insurance = Convert.ToDouble(txtInsurance.Text);
                 gas = Convert.ToDouble(txtGas.Text);
                 oil = Convert.ToDouble(txtOil.Text);
                 tires = Convert.ToDouble(txtTires.Text);
                 maintanance = Convert.ToDouble(txtMaintenance.Text);
                double totalMonthlyCost = loanPayment + insurance + gas +
                 oil + tires + maintanance;

                double totalAnnualCost = totalMonthlyCost * 12;

                lstOutput.Items.Clear();
                lstOutput.Items.Add("Total Monthly Cost: " + totalMonthlyCost.ToString("C"));
                lstOutput.Items.Add("Total Annual Cost: " + totalAnnualCost.ToString("C"));
            }
            catch (Exception)
            {

                MessageBox.Show("Please enter a valid value");
            }
     

     
     
    }
  }
}
