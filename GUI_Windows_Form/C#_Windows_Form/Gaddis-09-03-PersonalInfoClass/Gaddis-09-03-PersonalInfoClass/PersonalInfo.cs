using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaddis_09_03_PersonalInfoClass
{
  public class PersonalInfo
  {
    public PersonalInfo(string name, string address, int age, string phone)
    {
      Name = name;
      Address = address;
      Age = age;
      Phone = phone;
    }

    public string Name { get; set; }
    public string Address { get; set; }
    public int Age { get; set; }
    public string Phone { get; set; }

    public override string ToString()
    {
      string s = String.Format(
                        "Name: {0}" +Environment.NewLine +
                        "Address: {1}" + Environment.NewLine +
                        "Age: {2}" + Environment.NewLine +
                        "Phone: {3}" + Environment.NewLine,
                        Name, Address, Age, Phone);

      return s;
    }
  }
}
