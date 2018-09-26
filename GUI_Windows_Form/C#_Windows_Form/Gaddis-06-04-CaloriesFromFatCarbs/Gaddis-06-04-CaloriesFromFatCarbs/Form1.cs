/*
 * Done
Calories from Fat and Carbohydrates A nutritionist who works for a fitness club helps members by evaluating their diets.As part of her evaluation, she asks members for the number of fat grams and carbohydrate grams that they consume in a day.Then, she calculates the number of calories that result from the fat using the following formula: 
Calories from fat = Fat grams × 9 
Next, she calculates the number of calories that result from the carbohydrates using the following formula: 
Calories from carbs = Carbs grams × 4 
Create an application that will make these calculations.In the application, you should have the following methods: 
• FatCalories–This method should accept a number of fat grams as an argument and return the number of calories from that amount of fat. 
• CarbCalories–This method should accept a number of carbohydrate grams as an argument and return the number of calories from that amount of carbohydrates.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_06_04_CaloriesFromFatCarbs
{
  public partial class Form1 : Form
  {
    const int FAT_GRAMS = 9;
    const int CARBS_GRAMS = 4;
    public Form1()
    {
      InitializeComponent();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      int gramsOfFat;
      int gramsOfCarbs;

      if (int.TryParse(txtFat.Text, out gramsOfFat) && int.TryParse(txtCarbs.Text, out gramsOfCarbs))
      {
        int caloriesFromFat = FatCalories(gramsOfFat);
        int caloriesFromCarbs = CarbCalories(gramsOfCarbs);

        lstOutput.Items.Add("Calories from Fat: " + caloriesFromFat.ToString("n"));
        lstOutput.Items.Add("Calories from Carbs: " + caloriesFromCarbs.ToString("n"));
      }
      else
        MessageBox.Show("Please enter valid numbers", "Invalid Input");
    }

    private int FatCalories(int gramsOfFat)
    {
      return gramsOfFat * FAT_GRAMS;
    }

    private int CarbCalories(int gramsOfCarbs)
    {
      return gramsOfCarbs * CARBS_GRAMS;
    }
  }
}
