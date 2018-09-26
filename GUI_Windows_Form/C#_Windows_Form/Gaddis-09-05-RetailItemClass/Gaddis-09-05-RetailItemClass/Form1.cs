/*
Retail Item Class Write a class named RetailItem that holds data about an item in a retail store.The class should have the following properties: 
• Description—The Description property should hold a brief description of the item.
• UnitsOnHand—The UnitsOnHand property should hold the number of units currently in inventory.
• Price—The Price property should hold the item’s retail price.
Write a constructor that accepts arguments for each property.The application should create an array of three RetailItem objects containing the following data: 

           Description Units on Hand    Price
Item 1       Jacket            12          59.95 
Item 2        Jeans            40          34.95 
Item 3        Shirt            20          24.95 
The application should have a loop that steps through the array, displaying each element’s properties.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_09_05_RetailItemClass
{
  public partial class frmRetailItems : Form
  {
    public frmRetailItems()
    {
      InitializeComponent();
    }

    Input inputForm;
    private void btnAddItems_Click(object sender, EventArgs e)
    {
      inputForm = new Input();
      inputForm.ShowDialog();
      DisplayItems();
    }

    private void DisplayItems()
    {
      foreach(RetailItem item in inputForm.items)
      {
        txtOutput.Text += item.ToString();
        txtOutput.Text += Environment.NewLine;
      }
    }
  }
}
