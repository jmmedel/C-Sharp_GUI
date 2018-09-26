using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaddis_10_04_PersonAndCustomerClass
{
  public class Customer : Person
  {
    public Customer(int id, string name, string address, string phone, bool mailingList)
      :base(name, address, phone)
    {
      Id = id;
      OnMailingList = mailingList;
    }

    public int Id { get; set; }
    public bool OnMailingList { get; set; }

    public override string ToString()
    {
      return "Customer Id: " + Id + Environment.NewLine +
              base.ToString() +          
             "On Mailing List: " + (OnMailingList ? "Yes" : "No");
    }
  }
}
