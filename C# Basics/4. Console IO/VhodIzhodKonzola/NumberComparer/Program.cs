using System;

namespace NumberComparer
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(((a+b)+Math.Abs(a-b))/2);
        }
    }
}
