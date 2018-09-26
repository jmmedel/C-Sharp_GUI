using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaddis_10_01_EmployeeProductionWorker
{
  class ProductionWorker : Employee
  {

    public ProductionWorker(string name, int id, int shift, decimal hourlyPay)
                        : base(name, id, shift)
    {
      ShiftNumber = shift;
      HourlyPay = hourlyPay;
    }
    public int ShiftNumber { get; set; }
    public decimal HourlyPay { get; set; }

    public override decimal Pay
    {
      get { return HourlyPay; }
      set { HourlyPay = value; }
    }

    public override int Shift
    {
      get { return ShiftNumber; }
      set { ShiftNumber = value; }
    }

    public override string ToString()
    {
      return base.ToString() +
              "Worker Pay: " + HourlyPay + "\r\n";
    }
  }
}
