using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaddis_10_01_EmployeeProductionWorker
{
  public abstract class Employee
  {

    public Employee(string name, int id, int shift)
    {
      EmplName = name;
      EmplNumber = id;
      Shift = shift;
    }

    public string EmplName { get; set; }
    public int EmplNumber { get; set; }
    public abstract int Shift { get; set; }
    public abstract decimal Pay { get; set; }

    public override string ToString()
    {
      return "Employee Name: " + EmplName + "\r\n" +
             "Employee Id: " + EmplNumber + "\r\n" +
             "Employee Shift: " + Shift + "\r\n";
    }
  }
}
