using System;

namespace ChristmasHat
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int countOfDots = 2 * n - 1;
            int hatWidth = 4 * n + 1;
            Console.Write(new string('.', countOfDots));
            Console.Write("/|\\");
            Console.WriteLine(new string('.', countOfDots));
            Console.Write(new string('.', countOfDots));
            Console.Write("\\|/");
            Console.WriteLine(new string('.', countOfDots));
            for (int countOfDashes = 0; countOfDashes < 2 * n; countOfDashes++)
            {
                Console.Write(new string('.', countOfDots - countOfDashes));
                Console.Write("*");
                Console.Write(new string('-', countOfDashes));
                Console.Write("*");
                Console.Write(new string('-', countOfDashes));
                Console.Write("*");
                Console.WriteLine(new string('.', countOfDots - countOfDashes));
            }
            Console.WriteLine(new string('*', hatWidth));
            for (int i = 1; i <= 2 * n; i++)
            {
                Console.Write("*.");
            }
            Console.WriteLine("*");
            Console.WriteLine(new string('*', hatWidth));
        }
    }
}
