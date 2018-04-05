using System;


namespace Trapezoid
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:0.0000000}", ((a + b)/2) * h);
        }
    }
}
