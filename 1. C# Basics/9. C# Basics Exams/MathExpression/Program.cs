using System;

namespace MathExpression
{
    class Program
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            double numerator = n * n + 1 / (m * p) + 1337;
            double denominator = n - 128.523123123 * p;
            int angle = (int)m % 180;
            Console.WriteLine("{0:F6}", numerator / denominator + Math.Sin(angle));
        }
    }
}
