using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaddis_10_01_EmployeeProductionWorker
{
  public class ShiftSupervisor : Employee
  {

    public ShiftSupervisor(string name, int id, int shift, decimal annualSalary, decimal annualBonus)
        : base (name, id, shift)
    {
      AnnualSalary = annualSalary;
      AnnualBonus = annualBonus;
    }

    public decimal AnnualSalary { get; set; }
    public decimal AnnualBonus { get; set; }
    public int ShiftNumber { get; set; }

    public override decimal Pay
    {
      get { return AnnualSalary; }
      set { AnnualSalary = value; }
    }

    public override int Shift
    {
      get
      {
        return ShiftNumber;
      }

      set
      {
        ShiftNumber = value;
      }
    }

    public override string ToString()
    {
      return base.ToString() +
            "Supervisor Annual Salary: " + AnnualSalary + "\r\n" +
            "Supervisor Annual Bonus: " + AnnualBonus + "\r\n";
    }
  }


}
