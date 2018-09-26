/*
Joe’s Automotive Joe’s Automotive performs the following routine maintenance services: 
• Oil change—$26.00 
• Lube job—$18.00 
• Radiator flush—$30.00 
• Transmission flush—$80.00 
• Inspection—$15.00 
• Muffler replacement—$100.00 
• Tire rotation—$20.00 
Joe also performs other nonroutine services and charges for parts and labor($20 per hour). Create an application that displays the total for a customer’s visit to Joe’s.

The application should have the following value-returning methods: 
• OilLubeCharges—Returns the total charges for an oil change and/or a lube job, if any. 
• FlushCharges—Returns the total charges for a radiator flush and/or a transmission flush, if any. 
• MiscCharges—Returns the total charges for an inspection, muffler replacement, and/or a tire rotation, if any. 
• OtherCharges—Returns the total charges for other services(parts and labor), if any. 
• TaxCharges—Returns the amount of sales tax, if any.Sales tax is 6% and is charged only on parts.If the customer purchases services only, no sales tax is charged. 
• TotalCharges—Returns the total charges. 

The application should have the following void methods, called when the user clicks the Clear button: 
• ClearOilLube—Clears the check boxes for oil change and lube job. 
• ClearFlushes—Clears the check boxes for radiator flush and transmission flush. 
• ClearMisc—Clears the check boxes for inspection, muffler replacement, and tire rotation. 
• ClearOther—Clears the text boxes for parts and labor. 
• ClearFees—Clears the text boxes in the section marked Summary.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_06_05_JoeAutomotive
{
  public partial class frmJoeAutomotive : Form
  {
    public frmJoeAutomotive()
    {
      InitializeComponent();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      txtOutputLabor.Text = (TotalCharges() - OtherChargesParts() - TaxCharges()).ToString("C");
      txtOutputParts.Text = OtherChargesParts().ToString("C");
      txtOutputTax.Text = TaxCharges().ToString("C");
      txtOutputTotalFees.Text = TotalCharges().ToString("C");
    }

    //Returns the total charges for an oil change and/or a lube job, if any. 
    private double OilLubeCharges()
    {
      int sum = 0;
      if (chkOilChange.Checked)
        sum += Convert.ToInt32(chkOilChange.Tag);

      if (chkLubeJob.Checked)
        sum += Convert.ToInt32(chkLubeJob.Tag);

      return sum;
    }

    //Returns the total charges for a radiator flush and/or a transmission flush, if any. 
    private double FlushCharges()
    {
      int sum = 0;
      if (chkRadiatorFlush.Checked)
        sum += Convert.ToInt32(chkRadiatorFlush.Tag);

      if (chkTransmissionFlush.Checked)
        sum += Convert.ToInt32(chkTransmissionFlush.Tag);

      return sum;
    }

    //Returns the total charges for an inspection, muffler replacement, and/or a tire rotation, if any. 
    private double MiscCharges()
    {
      int sum = 0;
      if (chkInspection.Checked)
        sum += Convert.ToInt32(chkInspection.Tag);

      if (chkMufflerReplace.Checked)
        sum += Convert.ToInt32(chkMufflerReplace.Tag);

      if (chkTireRotation.Checked)
        sum += Convert.ToInt32(chkTireRotation.Tag);

      return sum;
    }

    //Returns the total charges for other services(labor), if any. $20/hour 
    private double OtherChargesLabor()
    {
      double labor;
      if (double.TryParse(txtLabor.Text, out labor))
      {
        return labor * 20;
      }
      else
      {
        MessageBox.Show("Value for labor cost is invalid - setting labor cost to zero", "Invalid Input");
        txtLabor.Text = "0";
      }

      return 0;  

    }

    //Returns the total charges for other services(parts), if any. 
    private double OtherChargesParts()
    {
      double parts;
      if (double.TryParse(txtParts.Text, out parts))
      {
        return parts;
      }
      else
      {
        MessageBox.Show("Value for parts cost is invalid - setting parts to zero", "Invalid Input");
        txtParts.Text = "0";
      }

      return 0;
    }

    //Returns the amount of sales tax, if any.Sales tax is 6% and is charged only on parts.If the customer purchases services only, no sales tax is charged. 
    private double TaxCharges()
    {
      double parts;
      if (double.TryParse(txtParts.Text, out parts))
      {
        return parts * 0.06;
      }
      else
      {
        MessageBox.Show("Tax cannot be calculated because charges for Parts are not valid", "Invalid Input");
      }

      return 0;
    }

    //Returns the total charges.
    private double TotalCharges()
    {
      double total = 0;
      total += OilLubeCharges();
      total += FlushCharges();
      total += MiscCharges();
      total += OtherChargesLabor();
      total += OtherChargesParts();
      total += TaxCharges();

      return total;
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      ClearOilLube();
      ClearFlushes();
      ClearMisc();
      ClearOther();
      ClearFees();
    }

    //Clears the check boxes for oil change and lube job. 
    private void ClearOilLube()
    {
      chkOilChange.Checked = false;
      chkLubeJob.Checked = false;
    }

    //Clears the check boxes for radiator flush and transmission flush. 
    private void ClearFlushes()
    {
      chkRadiatorFlush.Checked = false;
      chkTransmissionFlush.Checked = false;
    }

    //Clears the check boxes for inspection, muffler replacement, and tire rotation. 
    private void ClearMisc()
    {
      chkInspection.Checked = false;
      chkMufflerReplace.Checked = false;
      chkTireRotation.Checked = false;
    }

    //Clears the text boxes for parts and labor. 
    private void ClearOther()
    {
      txtParts.Clear();
      txtLabor.Clear();
    }

    //Clears the text boxes in the section marked Summary.
    private void ClearFees()
    {
      txtOutputLabor.Clear();
      txtOutputParts.Clear();
      txtOutputTax.Clear();
      txtOutputTotalFees.Clear();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}
