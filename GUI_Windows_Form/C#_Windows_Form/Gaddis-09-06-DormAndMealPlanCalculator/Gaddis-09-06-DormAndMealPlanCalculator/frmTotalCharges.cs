using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaddis_09_06_DormAndMealPlanCalculator
{
  public partial class frmTotalCharges : Form
  {
    public frmTotalCharges()
    {
      InitializeComponent();

    }
    private void btnReturnToMain_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void Display()
    {
      txtOutput.Text += frmDormAndMealCost.dorms[Dorm.ChosenDormIndex].ToString();
      txtOutput.Text += frmDormAndMealCost.meals[MealPlan.ChosenMealIndex].ToString();
      txtOutput.Text += "total Cost: " + Calctotal().ToString("C");
    }

    private int Calctotal()
    {
      int dormCost = frmDormAndMealCost.dorms[Dorm.ChosenDormIndex].DormCost;
      int mealCost = frmDormAndMealCost.meals[MealPlan.ChosenMealIndex].MealCost;

      return dormCost + mealCost;
    }

    private void frmTotalCharges_Load(object sender, EventArgs e)
    {
      Display();
    }
  }
}
