using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise;

public static class TempConverter
{
    public static double FahrToCel(double Fahr)
    {
        var result = (Fahr - 32) / 1.8;
        return result;
    }
    public static double CelToFahr(double Cel)
    {
        double result = ((9 / 5) * Cel) + 32;
        return result;
    }
}
