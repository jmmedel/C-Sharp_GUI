/*
Drink Vending Machine Simulator Create an application that simulates a soft-drink vending machine.The application should let the user select one of the following soft drinks: 
• Cola($1.00 each) 
• Root Beer($1.00 each) 
• Lemon Lime Soda($1.00 each) 
• Grape Soda($1.50 each) 
• Cream Soda($1.50 each) 
When the application starts, the vending machine will have 20 of each type of soft drink. Each time the user selects a drink, the application should subtract 1 from the quantity of the selected drink. It should also update and display the total amount of sales. If the user selects a drink that is sold out, a message should be displayed indicating so. In the application’s code, create a structure that has fields for the following data: 
Drink name 
Drink cost 
Number of drinks in machine 
The program should create an array of five structure objects. Each element of the array should keep data for a specific type of soft drink.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_08_11_DrinkVendingMachine
{
  public partial class frmVendingMachine : Form
  {
    public frmVendingMachine()
    {
      InitializeComponent();
    }

    const decimal COLA_COST = 1.00m;
    const decimal ROOT_BEER_COST = 1.00m;
    const decimal LEMON_LIME_COST = 1.0m;
    const decimal GRAPE_SODA_COST = 1.5m;
    const decimal CREAM_SODA_COST = 1.5m;

    private struct Soda
    {
      public string drinkName;
      public decimal drinkCost;
      public int qty;
    }

    private Soda[] soda = new Soda[5];
    private decimal totalSales = 0.00m;

    private void frmVendingMachine_Load(object sender, EventArgs e)
    {
      PopulateArray("Cola", COLA_COST, 0);
      PopulateArray("Root Beer", ROOT_BEER_COST, 1);
      PopulateArray("Lemon Lime", LEMON_LIME_COST, 2);
      PopulateArray("Grape Soda", GRAPE_SODA_COST, 3);
      PopulateArray("Cream Soda", CREAM_SODA_COST, 4);
    }
    
    private void PopulateArray (string name, decimal cost, int index)
    {
      soda[index].drinkName = name;
      soda[index].drinkCost = cost;
      soda[index].qty = 20;
    }

    private bool QtyOK(int index)
    {
      if (soda[index].qty > 0)
        return true;

      return false;
    }

    private void DisplayMessage(int index)
    {
      MessageBox.Show(soda[index].drinkName + " is sold out");
    }

    private void picCola_Click(object sender, EventArgs e)
    {
      if (QtyOK(0))
      {
        totalSales += soda[0].drinkCost;
        soda[0].qty -= 1;
        txtColaLeft.Text = soda[0].qty.ToString();
        txtTotalSales.Text = totalSales.ToString("C");
      }
      else
        DisplayMessage(0);
    }

    private void picRootBeer_Click(object sender, EventArgs e)
    {
      if (QtyOK(1))
      {
        totalSales += soda[1].drinkCost;
        soda[1].qty -= 1;
        txtRootBeerLeft.Text = soda[1].qty.ToString();
        txtTotalSales.Text = totalSales.ToString("C");
      }
      else
        DisplayMessage(1);
    }

    private void picLemonLime_Click(object sender, EventArgs e)
    {
      if (QtyOK(2))
      {
        totalSales += soda[2].drinkCost;
        soda[2].qty -= 1;
        txtLemonLimeLeft.Text = soda[2].qty.ToString();
        txtTotalSales.Text = totalSales.ToString("C");
      }
      else
        DisplayMessage(2);
    }

    private void picGrapeSoda_Click(object sender, EventArgs e)
    {
      if (QtyOK(3))
      {
        totalSales += soda[3].drinkCost;
        soda[3].qty -= 1;
        txtGrapeSodaLeft.Text = soda[3].qty.ToString();
        txtTotalSales.Text = totalSales.ToString("C");
      }
      else
        DisplayMessage(3);
    }

    private void picCreamSoda_Click(object sender, EventArgs e)
    {
      if (QtyOK(4))
      {
        totalSales += soda[4].drinkCost;
        soda[4].qty -= 1;
        txtCreamSodaLeft.Text = soda[4].qty.ToString();
        txtTotalSales.Text = totalSales.ToString("C");
      }
      else
        DisplayMessage(4);
    }

    private void btnNewCustomer_Click(object sender, EventArgs e)
    {
      totalSales = 0;
      txtTotalSales.Text = totalSales.ToString("C");
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}
