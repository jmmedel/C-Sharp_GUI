/*
 * Done
Workshop Selector The following table shows a training company’s workshops, the number of days of each, and their registration fees.
Workshop            Number of Days            Registration Fee 
Handling Stress       3                         $1,000 
Time Management       3                         $800 
Supervision Skills    3                         $1,500 
Negotiation           5                         $1,300 
How to Interview      1                         $500 
The training company conducts its workshops in the six locations shown in the following table. The table also shows the lodging fees per day at each location. 
Location                  Lodging Fees per Day 
Austin                      $150 
Chicago                     $225 
Dallas                      $175 
Orlando                     $300 
Phoenix                     $175 
Raleigh                     $150 
When a customer registers for a workshop, he or she must pay the registration fee plus the lodging fees for the selected location.
For example, here are the charges to attend the Supervision Skills workshop in Orlando: 
Registration: $1,500 
Lodging: $300 × 3 days = $900 
Total: $2,400 
Create an application that lets the user select a workshop from one ListBox and a location from another ListBox.When the user clicks a button, the application should calculate and display the registration cost, the lodging cost, and the total cost.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_04_12_WorkshopSelector
{
  public partial class frmWorkshopSelector : Form
  {
    public frmWorkshopSelector()
    {
      InitializeComponent();
    }

    private void btnCalculateCost_Click(object sender, EventArgs e)
    {
      int workshopCost =0;
      int lodgingCost =0;
      int numOfDays = 0;
      int totalCost;

      lstOutput.Items.Clear();

      switch(lstWorkshop.SelectedIndex)
      {
        case 0:
          workshopCost = 1000;
          numOfDays = 3;
          break;
        case 1:
          workshopCost = 800;
          numOfDays = 3;
          break;
        case 2:
          workshopCost = 1500;
          numOfDays = 3;
          break;
        case 3:
          workshopCost = 1300;
          numOfDays = 5;
          break;
        case 4:
          workshopCost = 500;
          numOfDays = 1;
          break;
      }

      if (lstLocation.SelectedIndex == 0)
        lodgingCost = 150 * numOfDays;
      else if (lstLocation.SelectedIndex == 1)
        lodgingCost = 225 * numOfDays;
      else if (lstLocation.SelectedIndex == 2)
        lodgingCost = 175 * numOfDays;
      else if (lstLocation.SelectedIndex == 3)
        lodgingCost = 300 * numOfDays;
      else if (lstLocation.SelectedIndex == 4)
        lodgingCost = 175 * numOfDays;
      else if (lstLocation.SelectedIndex == 5)
        lodgingCost = 150 * numOfDays;

      if (lstLocation.SelectedIndex < 0 || lstWorkshop.SelectedIndex < 0)
        MessageBox.Show("Please select workshop and location", "Invalid Selection");
      else
      {
        totalCost = workshopCost + lodgingCost;
        lstOutput.Items.Add("Registration Fee: " + workshopCost.ToString("C"));
        lstOutput.Items.Add("Lodging Cost: " + lodgingCost.ToString("C"));
        lstOutput.Items.Add("Total Cost: " + totalCost.ToString("C"));
      }

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }

}
