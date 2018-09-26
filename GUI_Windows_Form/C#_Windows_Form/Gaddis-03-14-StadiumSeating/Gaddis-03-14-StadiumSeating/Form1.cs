/*
Stadium Seating There are three seating categories at an athletic stadium.For a baseball game, Class A seats cost $15 each, Class B seats cost $12 each, and Class C seats cost $9 each.Create an application that allows the user to enter the number of tickets sold for each class. The application should be able to display the amount of income generated from each class of ticket sales and the total revenue generated.The application’s form should resemble the one shown in Figure 3-43.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_03_14_StadiumSeating
{
  public partial class frmStadiumSeating : Form
  {
    public frmStadiumSeating()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnCalculateRevenue_Click(object sender, EventArgs e)
    {
      const int CLASS_A_COST = 15;
      const int CLASS_B_COST = 12;
      const int CLASS_C_COST = 9;

      int classARevenue = Convert.ToInt32(txtClassA.Text) * CLASS_A_COST;
      int classBRevenue = Convert.ToInt32(txtClassB.Text) * CLASS_B_COST;
      int classCRevenue = Convert.ToInt32(txtClassC.Text) * CLASS_C_COST;

      int totalRevenue = classARevenue + classBRevenue + classCRevenue;

      txtClassARevenue.Text = classARevenue.ToString("C");
      txtClassBRevenue.Text = classBRevenue.ToString("C");
      txtClassCRevenue.Text = classCRevenue.ToString("C");
      txtTotalRevenue.Text = totalRevenue.ToString("C");
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      txtClassA.Clear();
      txtClassARevenue.Clear();
      txtClassB.Clear();
      txtClassBRevenue.Clear();
      txtClassC.Clear();
      txtClassCRevenue.Clear();
      txtTotalRevenue.Clear();

      txtClassA.Focus();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}
