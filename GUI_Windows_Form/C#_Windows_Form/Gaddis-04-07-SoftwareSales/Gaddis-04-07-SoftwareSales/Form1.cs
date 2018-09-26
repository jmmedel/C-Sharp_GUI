/*
Software Sales A software company sells a package that retails for $99. Quantity discounts are given according to the following table: 
Quantity Discount: 
10–19 20% 
20–49 30% 
50–99 40% 
100 or more 50% 
Create an application that lets the user enter the number of packages purchased.The program should then display the amount of the discount(if any) and the total amount of the purchase after the discount.
*/
using System;
using System.Windows.Forms;

namespace Gaddis_04_07_SoftwareSales
{
  public partial class frmSoftwareSales : Form
  {
    public frmSoftwareSales()
    {
      InitializeComponent();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      lstOutput.Items.Clear();

      const int PRICE = 99;
      const double DISCOUNT_10_19 = 0.20;
      const double DISCOUNT_20_49 = 0.30;
      const double DISCOUNT_50_99 = 0.40;
      const double DISCOUNT_OVER_100 = 0.50;

      int packagesPurchased;
      double totalAmount;
      double discount;

      if (int.TryParse(txtNumOfPurchasedPackages.Text, out packagesPurchased) && packagesPurchased > 0)
      {
        if (packagesPurchased < 10)
        {
          discount = 0;
          totalAmount = PRICE * packagesPurchased;
        }
        else if (packagesPurchased >= 10 && packagesPurchased <= 19)
        {
          discount = PRICE * DISCOUNT_10_19 * packagesPurchased;
          totalAmount = PRICE * packagesPurchased - discount;
        }
        else if (packagesPurchased >=20 && packagesPurchased <= 49)
        {
          discount = PRICE * DISCOUNT_20_49 * packagesPurchased;
          totalAmount = PRICE * packagesPurchased - discount;
        }
        else if (packagesPurchased >= 50 && packagesPurchased <= 99)
        {
          discount = PRICE * DISCOUNT_50_99 * packagesPurchased;
          totalAmount = PRICE * packagesPurchased - discount;
        }
        else
        {
          discount = PRICE * DISCOUNT_OVER_100 * packagesPurchased;
          totalAmount = PRICE * packagesPurchased - discount;
        }

        lstOutput.Items.Add("Total Price: " + (PRICE * packagesPurchased).ToString("C"));
        lstOutput.Items.Add("Total Discount: " + discount.ToString("C"));
        lstOutput.Items.Add("Total Amount Due: " + totalAmount.ToString("C"));
      }
      else
        MessageBox.Show("Please enter a valid number", "Invalid Input");

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
