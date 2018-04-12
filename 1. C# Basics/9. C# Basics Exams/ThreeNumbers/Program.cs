using System;

namespace ThreeNumbers
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(Math.Max(a,b),c));
            Console.WriteLine(Math.Min(Math.Min(a, b), c));
            int sum = a + b + c;
            double count = 3;
            Console.WriteLine("{0:F2}",sum/count);
        }
    }
}
