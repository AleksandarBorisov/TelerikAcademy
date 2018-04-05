using System;

namespace DrawFilledSquare
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeaderFooter(n);
            for (int i = 1; i <= n-2; i++)
            {
                PrintMiddleRow(n);
            }
            PrintHeaderFooter(n);
        }
        static void PrintHeaderFooter(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
        static void PrintMiddleRow(int n)
        {
            Console.Write("-");
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
    }
}
