using System;

namespace BiggestOf3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double max = (a > b ? (a > c ? a : c) : (b > c ? b : c));
            Console.WriteLine(max);
        }
    }
}
