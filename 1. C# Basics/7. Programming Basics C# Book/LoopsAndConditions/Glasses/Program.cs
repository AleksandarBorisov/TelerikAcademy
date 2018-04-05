using System;

namespace Glasses
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(new string('*', 2 * n)); ;
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n)); ;
            for (int i = 0; i < n-2; i++)
            {
                Console.Write("*");
                Console.Write(new string('/',2*(n-1)));
                Console.Write("*");
                if (i==((n-1)/2-1))
                {
                    Console.Write(new string('|', n));
                }
                else
                {
                    Console.Write(new string(' ', n));
                }
                Console.Write("*");
                Console.Write(new string('/', 2 * (n - 1)));
                Console.Write("*");
                Console.WriteLine();
            }
            Console.Write(new string('*', 2 * n)); ;
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n)); ;
        }
    }
}
