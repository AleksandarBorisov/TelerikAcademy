using System;

namespace PointCircleRectangle
{
    class Program
    {
        static void Main()
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double isInCircle = Math.Sqrt(Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2));
            bool isInRectangle = ((x >= -1) && (x <= 5)) && ((y >= -1) && (y <= 1));
            Console.Write(isInCircle <= 1.5 ? "inside circle " : "outside circle ");
            Console.WriteLine(isInRectangle ? "inside rectangle" : "outside rectangle");
        }
    }
}
