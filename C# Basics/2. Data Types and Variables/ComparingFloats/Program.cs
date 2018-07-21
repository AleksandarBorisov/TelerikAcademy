using System;

namespace ComparingFloats
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double eps = a - b;
            Console.WriteLine(Math.Abs(eps) < 0.000001 ? "true" : "false");
        }
    }
}
