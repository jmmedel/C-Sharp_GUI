using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaddis_10_01_EmployeeProductionWorker
{
  class Employee
  {

    public Employee(string name, int id)
    {
      EmplName = name;
      EmplNumber = id;
    }

    public string EmplName { get; set; }
    public int EmplNumber { get; set; }

    public override string ToString()
    {
      return "Employee Name: " + EmplName + "\r\n" +
             "Employee Id: " + EmplNumber + "\r\n";
    }
  }
}
