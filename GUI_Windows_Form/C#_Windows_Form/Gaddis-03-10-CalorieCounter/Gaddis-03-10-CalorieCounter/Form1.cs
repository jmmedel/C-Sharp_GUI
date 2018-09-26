/*
Calorie Counter Create an application with a form that resembles Figure 3-42. The PictureBox controls display the images of four fruits(a banana, an apple, an orange, and a pear) and each fruit’s calories.You can find these images in the Chap03 folder of the Student Sample Programs. When the application starts, the total calories displayed should be zero.Each time the user clicks one of the PictureBoxes, the calories for that fruit should be added to the total calories, and the total calories should be displayed. When the user clicks the Reset button, the total calories should be reset to zero.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_03_10_CalorieCounter
{
  public partial class frmCalorieCounter : Form
  {
    int totalCalories = 0;
    public frmCalorieCounter()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void picBanana_Click(object sender, EventArgs e)
    {
      const int BANANA_CALORIES = 115;
      totalCalories += BANANA_CALORIES;

      txtTotalCalories.Clear();
      txtTotalCalories.Text = totalCalories.ToString();
    }

    private void picApple_Click(object sender, EventArgs e)
    {
      const int APPLE_CALORIES = 80;
      totalCalories += APPLE_CALORIES;

      txtTotalCalories.Clear();
      txtTotalCalories.Text = totalCalories.ToString();
    }

    private void picOrange_Click(object sender, EventArgs e)
    {
      const int ORANGE_CALORIES = 90;
      totalCalories += ORANGE_CALORIES;

      txtTotalCalories.Clear();
      txtTotalCalories.Text = totalCalories.ToString();
    }

    private void picPear_Click(object sender, EventArgs e)
    {
      const int PEAR_CALORIES = 120;
      totalCalories += PEAR_CALORIES;

      txtTotalCalories.Clear();
      txtTotalCalories.Text = totalCalories.ToString();
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
      txtTotalCalories.Text = 0.ToString();
      totalCalories = 0;
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}
