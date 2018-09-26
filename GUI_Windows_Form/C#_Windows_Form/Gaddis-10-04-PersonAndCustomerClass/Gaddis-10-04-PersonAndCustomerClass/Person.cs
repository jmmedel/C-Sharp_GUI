using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaddis_10_04_PersonAndCustomerClass
{
  public abstract class Person
  {
    public Person(string name, string address, string phone)
    {
      Name = name;
      Address = address;
      Phone = phone;
    }

    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }

    public override string ToString()
    {
      return "Name: " + Name + Environment.NewLine +
             "Address: " + Address + Environment.NewLine +
             "Phone: " + Phone + Environment.NewLine;
    }
  }
}
