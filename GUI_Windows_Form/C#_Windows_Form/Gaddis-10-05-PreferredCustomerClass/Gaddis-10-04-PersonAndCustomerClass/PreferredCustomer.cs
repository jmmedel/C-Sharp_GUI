using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaddis_10_04_PersonAndCustomerClass
{
  public class PreferredCustomer : Customer
  {
    public PreferredCustomer(int id, string name, string address, string phone, bool mailingList, decimal amountSpent)
      :base(id, name, address, phone, mailingList)
    {
      AmountSpent = amountSpent;
      DiscountLevel = CalcDiscountLevel();
    }

    public decimal AmountSpent { get; set; }
    public decimal DiscountLevel { get; set; }

    private decimal CalcDiscountLevel()
    {
      if (AmountSpent >= 2000)
        return 0.1m;
      else if (AmountSpent >= 1500)
        return 0.07m;
      else if (AmountSpent >= 1000)
        return 0.06m;
      else if (AmountSpent >= 500)
        return 0.05m;

      return 0;
    }

    public override string ToString()
    {
      return base.ToString() +
            "Amount Spent: " + AmountSpent.ToString("C") + Environment.NewLine +
            "Discount Level: " + DiscountLevel.ToString("P2") + Environment.NewLine +
            "Total Cost: " + (AmountSpent - (AmountSpent * DiscountLevel)).ToString("C");
    }
  }
}
