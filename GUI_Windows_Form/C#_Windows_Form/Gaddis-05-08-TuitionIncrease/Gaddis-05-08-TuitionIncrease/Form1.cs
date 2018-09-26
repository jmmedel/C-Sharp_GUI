/*
 * Done
Tuition Increase At one college the tuition for a full-time student is $6000 per semester.It has been announced that the tuition will increase by 2 percent each year for the next five years. Create an application with a loop that displays the projected semester tuition amount for the next 5 years in a ListBox control.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_05_08_TuitionIncrease
{
  public partial class frmTuitionIncrease : Form
  {
    public frmTuitionIncrease()
    {
      InitializeComponent();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      const int STARTING_TUITION = 6000;
      const int NUM_OF_YEARS = 5;
      const decimal INCREASE = 0.02m;
      decimal projectedTuition = STARTING_TUITION;

      lstOutput.Items.Add("Year \t\t Projected Tuition");
      for (int i = 1; i <= NUM_OF_YEARS; i++)
      {
        projectedTuition += projectedTuition * INCREASE;
        lstOutput.Items.Add(i + "\t\t" + projectedTuition.ToString("C"));
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
