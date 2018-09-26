/*
Dorm and Meal Plan Calculator A university has the following dormitories: 
Allen Hall         $1,500 per semester
Pike Hall          $1,600 per semester
Farthing Hall      $1,800 per semester
University Suites  $2,500 per semester
The university also offers the following meal plans: 
7 meals per week   $600 per semester
14 meals per week  $1,200 per semester
Unlimited meals    $1,700 per semester
Create an application with two forms.The main form should allow the user to select a dormitory and a meal plan. The application should show the total charges on the second form.
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Gaddis_09_06_DormAndMealPlanCalculator
{
  public partial class frmDormAndMealCost : Form
  {
    public frmDormAndMealCost()
    {
      InitializeComponent();
      Initialize();
    }

    public static List<Dorm> dorms = new List<Dorm>();
    public static List<MealPlan> meals = new List<MealPlan>();

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      frmTotalCharges form2 = new frmTotalCharges();
      Dorm.ChosenDormIndex = cmbDorm.SelectedIndex;

      if (rad7Meals.Checked)
        MealPlan.ChosenMealIndex = 0;
      else if (rad14Meals.Checked)
        MealPlan.ChosenMealIndex = 1;
      else
        MealPlan.ChosenMealIndex = 2;

      form2.ShowDialog();
    }

    private void Initialize()
    {
      try
      {
        PopulateDorm();
        PopulateMeals();
        PopulateDropDownDorm();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void PopulateDropDownDorm()
    {
      cmbDorm.Text = "Select Dorm";
      foreach(Dorm d in dorms)
      {
        cmbDorm.Items.Add(d.DormType);
      }
    }

    private void PopulateDorm()
    {
      StreamReader sr = new StreamReader("Dorm.txt");
      while (!sr.EndOfStream)
      {
        string[] data = sr.ReadLine().Split(',');
        dorms.Add(new Dorm(data[0], Convert.ToInt32(data[1])));
      }

      sr.Close();
    }

    private void PopulateMeals()
    {
      StreamReader sr = new StreamReader("Meals.txt");
      while (!sr.EndOfStream)
      {
        string[] data = sr.ReadLine().Split(',');
        meals.Add(new MealPlan(data[0], Convert.ToInt32(data[1])));
      }

      sr.Close();
    }
  }
}
