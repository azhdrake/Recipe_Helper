using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeHelper
{
  public static class RecipeCaculations
  {
    public static double CaculateTemp(double degreesC)
    {
      double degreesF = degreesC * (9 / 5) + 32;
      return degreesF;
    }

    public static double CaculateVolume(double mL)
    {
      double cups = mL / 263.59;
      return cups;
    }
  }
}
