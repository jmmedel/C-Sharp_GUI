using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaddis_09_05_RetailItemClass
{
  public partial class Input : Form
  {
    public Input()
    {
      InitializeComponent();
    }

    public RetailItem[] items = new RetailItem[3];
    int counter = 0;

    private void btnSubmit_Click(object sender, EventArgs e)
    {
      string desc = txtDescription.Text;
      int qty = 0;
      decimal price = 0.0m;

      if (!String.IsNullOrWhiteSpace(desc) && int.TryParse(txtQuantity.Text, out qty) &&
        decimal.TryParse(txtPrice.Text, out price) && qty > 0 && price > 0)
      {
        items[counter] = new RetailItem(desc, qty, price);
        counter++;

        txtDescription.Text = "";
        txtPrice.Text = "";
        txtQuantity.Text = "";
        txtDescription.Focus();
      }
      else
        MessageBox.Show("Please enter valid values", "Invalid Input");

      if (counter > 2)
        this.Close();
    }
  }
}
