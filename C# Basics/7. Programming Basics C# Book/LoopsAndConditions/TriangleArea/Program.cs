using System;

namespace TriangleArea
{
    class Program
    {
        static void Main()
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());
            double area = (double)(Math.Abs(x3 - x2) * Math.Abs(y3 - y1))/2;//Конвертираме и дясната страна, защото сме
            Console.WriteLine(area);//подали цели параметри и резултатът ще е цяло число
        }
    }
}
