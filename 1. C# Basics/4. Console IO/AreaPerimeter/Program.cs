using System;

namespace AreaPerimeter
{
    class Program
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            double perimeter = 2 * Math.PI * r;
            Console.WriteLine("{0:F2} {1:F2}",perimeter,area);
        }
    }
}
