/*
Pet Class Create a class named Pet which has the following properties: 
• Name—The Name property holds the name of a pet.
• Type—The Type property holds the type of animal that a pet is. Example values are “Dog”, “Cat”, and “Bird”. 
• Age—The Age property holds the pet’s age.
Demonstrate the class in an application that creates an object of the class and lets the user enter the name, type, and age of his or her pet. This data should be stored in the object. Retrieve the pet’s Name, Type, and Age properties and display their values on the screen. 
*/
using System;
using System.Windows.Forms;

namespace Gaddis_09_01_PetClass
{
  public partial class frmPetClass : Form
  {
    public frmPetClass()
    {
      InitializeComponent();
    }

    Pet pet;
    private void btnEnterData_Click(object sender, EventArgs e)
    {
      string name = txtName.Text;
      string type = txtType.Text;
      decimal age = 0.0m;

      if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(type) && decimal.TryParse(txtAge.Text, out age))
      {
        pet = new Pet(name, type, age);
      }
      else
        MessageBox.Show("Please correct your input", "Invalid Input");
    }

    private void btnDisplayData_Click(object sender, EventArgs e)
    {
      try
      {
        lstOutput.Items.Add("Pet's name: " + pet.Name);
        lstOutput.Items.Add("Pet's type: " + pet.Type);
        lstOutput.Items.Add("Pet's age: " + pet.Age);
      }
      catch (NullReferenceException)
      {
        MessageBox.Show("Please enter the pet data first!");
      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}
