using System;

namespace ChristmasHat
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(new string('.', 2 * n - 1));
            Console.Write("/|\\");
            Console.WriteLine(new string('.', 2 * n - 1));
            Console.Write(new string('.', 2 * n - 1));
            Console.Write("\\|/");
            Console.WriteLine(new string('.', 2 * n - 1));
            for (int i = 1; i <= 2 * n; i++)
            {
                Console.Write(new string('.', 2 * n - i));
                Console.Write("*");
                Console.Write(new string('-', i - 1));
                Console.Write("*");
                Console.Write(new string('-', i - 1));
                Console.Write("*");
                Console.WriteLine(new string('.', 2 * n - i));
            }
            Console.WriteLine(new string('*', 4 * n + 1));
            for (int i = 1; i <= 2 * n; i++)
            {
                Console.Write("*.");
            }
            Console.WriteLine("*");
            Console.WriteLine(new string('*', 4 * n + 1));
        }
    }
}
