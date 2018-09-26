using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaddis_10_01_EmployeeProductionWorker
{
  class ProductionWorker : Employee
  {

    public ProductionWorker(string name, int id, int shift, decimal pay)
                        : base(name, id)
    {
      ShiftNumber = shift;
      HourlyPay = pay;
    }
    public int ShiftNumber { get; set; }
    public decimal HourlyPay { get; set; }

    public override string ToString()
    {
      return base.ToString() +
              "Worker shift: " + ShiftNumber + "\r\n" +
              "Worker Pay: " + HourlyPay + "\r\n";
    }
  }
}
