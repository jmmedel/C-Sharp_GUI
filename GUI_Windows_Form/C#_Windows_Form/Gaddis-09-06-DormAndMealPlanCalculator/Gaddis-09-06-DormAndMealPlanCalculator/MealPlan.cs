using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaddis_09_06_DormAndMealPlanCalculator
{
  public class MealPlan
  {

    public MealPlan(string type, int cost)
    {
      MealPlanType = type;
      MealCost = cost;
    }

    public string MealPlanType { get; set; }
    public int MealCost { get; set; }
    public static int ChosenMealIndex { get; set; }

    public override string ToString()
    {
      return String.Format("Meal Type: {0}" + Environment.NewLine +
                           "Meal Cost: {1:C}" + Environment.NewLine,
                           MealPlanType, MealCost);
    }

  }
}
