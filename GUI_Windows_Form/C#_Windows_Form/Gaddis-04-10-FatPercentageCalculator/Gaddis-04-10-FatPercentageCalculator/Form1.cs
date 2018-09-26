/*
 * Done
Fat Percentage Calculator One gram of fat has 9 calories. If you know the number of fat grams in a particular food, you can use the following formula to calculate the number of calories that come from fat in that food: 
Calories from fat = Fat grams × 9 

If you know the food’s total calories, you can use the following formula to calculate the percentage of calories from fat: 
Percentage of calories from fat = Calories from fat ÷ Total calories 

Create an application that allows the user to enter: 
• The total number of calories for a food item 
• The number of fat grams in that food item 
The application should calculate and display: 
• The number of calories from fat 
• The percentage of calories that come from fat 

Also, the application’s form should have a CheckBox that the user can check if he or she wants to know whether the food is considered low fat. (If the calories from fat are less than 30% of the total calories of the food, the food is considered low fat.) 
Use the following test data to determine if the application is calculating properly: 
Calories and Fat Percentage Fat         Percentage of calories from fat
200 calories, 8 fat grams               36% 
150 calories, 2 fat grams               12% (a low-fat food) 
500 calories, 30 fat grams              54% 
Note: Make sure the number of calories and fat grams are not less than 0. Also, the number of calories from fat cannot be greater than the total number of calories. If that happens, display an error message indicating that either the calories or fat grams were incorrectly entered.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_04_10_FatPercentageCalculator
{
  public partial class frmFatPercentageCalculator : Form
  {
    public frmFatPercentageCalculator()
    {
      InitializeComponent();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      const decimal MAX_PERCENTAGE_FOR_LOW_FAT = 0.3m;
      int totalCalories;
      int numbOfFatGrams;
      decimal caloriesFromFat;
      decimal percentCaloriesFromFat;

      lstOutput.Items.Clear();

      if (int.TryParse(txtNumberOfCalories.Text, out totalCalories) &&
        int.TryParse(txtNumberOfFatGrams.Text, out numbOfFatGrams) &&
        totalCalories >= 0 && numbOfFatGrams >= 0)
      {
        caloriesFromFat = numbOfFatGrams * 9;
        percentCaloriesFromFat = caloriesFromFat / totalCalories;

        lstOutput.Items.Add("Calories from fat: " + caloriesFromFat.ToString("n0"));
        lstOutput.Items.Add("Percentage of calories from fat: " + percentCaloriesFromFat.ToString("P"));

        /*
        if (chcLowFat.Checked)
        {
          if (percentCaloriesFromFat < MAX_PERCENTAGE_FOR_LOW_FAT)
            lstOutput.Items.Add("The food is low fat");
          else
            lstOutput.Items.Add("The food is NOT low fat");
        } */

        if (chcLowFat.Checked)
          lstOutput.Items.Add(percentCaloriesFromFat < MAX_PERCENTAGE_FOR_LOW_FAT ?
            "The food is low fat" : "The food is NOT low fat");
      }
      else
        MessageBox.Show("Either calories or fat grams were entered incorrectly", "Invalid Input");
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }
    
  }
}
