using System;

namespace SignOfIntegerNumber
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }
        static void PrintSign(int n)
        {
            if (n > 0)
            {
                Console.WriteLine("The number {0} is positive.", n);
            }
            if (n < 0)
            {
                Console.WriteLine("The number {0} is negative.", n);
            }
            if (n == 0)
            {
                Console.WriteLine("The number {0} is zero.", n);
            }
        }
    }
}
