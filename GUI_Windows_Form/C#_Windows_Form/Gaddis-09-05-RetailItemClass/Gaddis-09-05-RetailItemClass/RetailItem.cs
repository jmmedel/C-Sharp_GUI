using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaddis_09_05_RetailItemClass
{
  public class RetailItem
  {
    public RetailItem(string desc, int qty, decimal price)
    {
      Desc = desc;
      Qty = qty;
      Price = price;
    } 

    public string Desc { get; set; }
    public int Qty { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
      return String.Format("Desciption: {0}" + Environment.NewLine +
                           "Quantity: {1}" + Environment.NewLine +
                           "Price: {2}" + Environment.NewLine,
                           Desc, Qty, Price);
    }

  }
}
