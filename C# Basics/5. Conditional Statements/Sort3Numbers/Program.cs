using System;

namespace Sort3Numbers
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a < b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }
            if (a < c)
            {
                a = a + c;
                c = a - c;
                a = a - c;
            }
            if (b < c)
            {
                b = b + c;
                c = b - c;
                b = b - c;
            }
            Console.WriteLine("{0} {1} {2}", a, b, c);
        }
    }
}
