using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaddis_09_01_PetClass
{
  class Pet
  {

    public Pet(string name, string type, decimal age)
    {
      Name = name;
      Type = type;
      Age = age;
    }

    public string Name { get; set; }
    public string Type { get; set; }
    public decimal Age { get; set; }
  }
}
