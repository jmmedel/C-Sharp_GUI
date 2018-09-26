/*
Hospital Charges Create an application that calculates the total cost of a hospital stay.The daily base charge is $350. The hospital also charges for medication, surgical fees, lab fees, and physical rehab.The application should accept the following input: 
• The number of days spent in the hospital 
• The amount of medication charges 
• The amount of surgical charges 
• The amount of lab fees 
• The amount of physical rehabilitation charges 
Create and use the following value-returning methods in the application: 
• CalcStayCharges—Calculates and returns the base charges for the hospital stay.This is computed as $350 times the number of days in the hospital. 
• CalcMiscCharges—Calculates and returns the total of the medication, surgical, lab, and physical rehabilitation charges.
• CalcTotalCharges—Calculates and returns the total charges.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_06_06_HospitalCharges
{
  public partial class frmHospitalCharges : Form
  {
    public frmHospitalCharges()
    {
      InitializeComponent();
    }

    private void btnCalculateBill_Click(object sender, EventArgs e)
    {
      int days;
      double medication;
      double surgery;
      double labs;
      double rehab;

      if (int.TryParse(txtDays.Text, out days) && double.TryParse(txtMedication.Text, out medication) &&
      double.TryParse(txtSurgical.Text, out surgery) && double.TryParse(txtLabFees.Text, out labs) &&
      double.TryParse(txtRehabilitation.Text, out rehab))
      {
        double stayCharges = CalcStayCharges(days);
        double miscCharges = CalcMiscCharges(medication, surgery, labs, rehab);
        double totalCharges = CalcTotalCharges(stayCharges, miscCharges);

        lstBill.Items.Add("Stay Charges: " + stayCharges.ToString("C"));
        lstBill.Items.Add("Misc Charges: " + miscCharges.ToString("C"));
        lstBill.Items.Add("Total Fees  : " + totalCharges.ToString("C"));
      }
      else
        MessageBox.Show("Please enter valid values", "Invalid Input");
    }

    //Calculates and returns the base charges for the hospital stay.This is computed as $350 times the number of days in 
    //the hospital. 
    private double CalcStayCharges(int days)
    {
      return days * 350;
    }

    //Calculates and returns the total of the medication, surgical, lab, and physical rehabilitation charges.
    private double CalcMiscCharges(double meds, double surgery, double lab, double rehab)
    {
      return meds + surgery + lab + rehab;
    }

    //Calculates and returns the total charges
    private double CalcTotalCharges(double stayCharges, double miscCharges)
    {
      return stayCharges + miscCharges;
    }
  }
}
