using System;

namespace PointInCircle
{
    class Program
    {
        static void Main()
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double c = (x * x) + (y * y);
            Console.WriteLine((c <= 4 ? "yes {0:0.00} " : "no {0:0.00}"),Math.Sqrt(c));
        }
    }
}
