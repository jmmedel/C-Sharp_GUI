/*
Car Class Create a class named Car that has the following properties: 
• Year—The Year property holds the car’s year model.
• Make—The Make property holds the make of the car.
• Speed—The Speed property holds the car’s current speed.
In addition, the class should have the following constructor and other methods.
• Constructor—The constructor should accept the car’s year and model and make them as arguments.These values should be assigned to the backing fields for the object’s Year and Make properties.The constructor should also assign 0 to the backing field for the Speed property.
• Accelerate—The Accelerate method should add 5 to the Speed property’s backing field each time it is called.
• Brake—The Brake method should subtract 5 from the Speed property’s backing field each time it is called.
Demonstrate the class in an application that creates a Car object. The application’s form should have an Accelerate button that calls the Accelerate method and then displays the car’s current speed each time it is clicked.The application’s form should also have a Brake button that calls the Brake method and then displays the car’s current speed each time it is clicked.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_09_02_CarClass
{
  public partial class frmCarClass : Form
  {
    public frmCarClass()
    {
      InitializeComponent();
    }

    Car car;
    private void btnAddCar_Click(object sender, EventArgs e)
    {
      InputForm frm2 = new InputForm();
      frm2.ShowDialog();
      car = frm2.car;

      DisplayCar();
      btnAccelerate.Enabled = true;
      btnBreak.Enabled = true;
    }

    private void DisplayCar()
    {
      txtMake.Text = car.Make;
      txtYear.Text = car.Year.ToString();
    }

    private void btnAccelerate_Click(object sender, EventArgs e)
    {
      car.Accelarate();
      txtSpeed.Text = car.Speed.ToString();
    }

    private void btnBreak_Click(object sender, EventArgs e)
    {
      if (car.Speed > 0)
        car.Break();

      txtSpeed.Text = car.Speed.ToString();
    }
  }
}
