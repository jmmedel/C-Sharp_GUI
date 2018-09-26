using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaddis_09_06_DormAndMealPlanCalculator
{
  public class Dorm
  {
    public Dorm(string type, int cost)
    {
      DormType = type;
      DormCost = cost;
    }

    public string DormType { get; set; }
    public int DormCost { get; set; }
    public static int ChosenDormIndex { get; set; }

    public override string ToString()
    {
      return String.Format("Dorm type: {0}" + Environment.NewLine +
                           "Dorm Cost: {1:C}" + Environment.NewLine,
                           DormType, DormCost);
    }
  }
}
