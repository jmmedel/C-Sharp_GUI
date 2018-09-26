/*
Cookie Calories A bag of cookies holds 40 cookies.The calorie information on the bag claims that there are 10 servings in the bag and that a serving equals 300 calories. Create an application that lets the user enter the number of cookies he or she actually ate and then reports the number of total calories consumed.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_03_09_CookieCalories
{
  public partial class frmCalories : Form
  {
    public frmCalories()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      const int COOKIES_IN_BAG = 40;
      const int CALORIES_PER_SERVING = 300;
      const int SERVINGS_PER_BAG = 10;

      int servingSize = COOKIES_IN_BAG / SERVINGS_PER_BAG;
      int caloriesPerCookie = CALORIES_PER_SERVING / servingSize;

      int numOfCookiesEaten = Convert.ToInt32(txtNumberOfCookies.Text);

      txtCaloriesEaten.Text = (numOfCookiesEaten * caloriesPerCookie).ToString();
    }
  }
}
