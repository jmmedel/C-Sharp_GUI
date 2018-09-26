using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaddis_09_04_EmployeeClass
{
  class Employee
  {

    public Employee(string name, int id, string dept, string position)
    {
      Name = name;
      Id = id;
      Department = dept;
      Position = position;
    }

    public Employee(string name, int id)
    {
      Name = name;
      Id = id;
      Department = "";
      Position = "";
    }

    public Employee()
    {
      Name = "";
      Id = 0;
      Department = "";
      Position = "";
    }

    public string Name { get; set; }
    public int Id { get; set; }
    public string Department { get; set; }
    public string Position { get; set; }

    public override string ToString()
    {
      return String.Format("Name: {0}" + Environment.NewLine +
                           "Id: {1}" + Environment.NewLine +
                           "Dept: {2}" + Environment.NewLine +
                           "Position: {3}" + Environment.NewLine,
                           Name, Id, Department, Position);
    }   
  }  
}
