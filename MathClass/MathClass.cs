using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathClass
{
    public class MathClass
    {
          static void Main(string[] args)
        {

            double x = 3;
            double y = 5;

            double a = Math.Pow(x, 2);
            double b = Math.Sqrt(x);
            double c = Math.Abs(x);
            double d = Math.Round(x);
            double e = Math.Ceiling(x);
            double f = Math.Floor(x);
            double g = Math.Max(x, y);
            double h = Math.Min(x, y);

            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}