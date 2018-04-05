using System;

namespace CalculateTriangleArea
{
    class Program
    {
        static void Main()
        {
            double l = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = GetTriangleArea(l, h);
            Console.WriteLine(area);
        }
        static double GetTriangleArea(double length, 
            double height)
        {
            return (length * height) / 2;
        }
    }
}
