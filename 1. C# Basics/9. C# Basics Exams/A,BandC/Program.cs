using System;

namespace A_BandC
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(a, Math.Max(b, c)));
            Console.WriteLine(Math.Min(a, Math.Min(b, c)));
            Console.WriteLine("{0:F3}", (a + b + c) / 3.0);
        }
    }
}
