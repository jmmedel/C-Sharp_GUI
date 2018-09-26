using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaddis_10_01_EmployeeProductionWorker
{
  public class TeamLeader : ProductionWorker
  {
    public TeamLeader(string name, int id, int shift, decimal pay, decimal monthlyBonus, int trainingHours) 
      : base(name, id, shift, pay)
    {
      MonthlyBonus = monthlyBonus;
      TrainingHours = trainingHours;
    }
    public decimal MonthlyBonus { get; set; }
    public int TrainingHours { get; set; }

    public override string ToString()
    {
      return base.ToString() +
              "Monthly Bonus: " + MonthlyBonus + "\r\n" +
              "Required Training Hours: " + TrainingHours + "\r\n";
    }
  }
}
