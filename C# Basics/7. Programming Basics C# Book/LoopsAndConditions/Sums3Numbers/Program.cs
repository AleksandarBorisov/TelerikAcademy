using System;

namespace Sums3Numbers
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a + b == c)
            {
                Console.WriteLine("{0} + {1} = {2}", Math.Min(a,b), Math.Max(a,b), c);
            }
            else if (a + c == b)
            {
                Console.WriteLine("{0} + {1} = {2}", Math.Min(a, c), Math.Max(a, c), b);
            }
            else if (b + c == a)
            {
                Console.WriteLine("{0} + {1} = {2}", Math.Min(b, c), Math.Max(b, c), a);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
