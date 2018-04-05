using System;

namespace Arrow
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int outerDots = n / 2;
            int innerDots = n - 2;
            Console.WriteLine("{0}{1}{0}",
                new string('.', outerDots),
                new string('#', n));
            for (int row = 0; row < n - 2; row++)
            {
                Console.WriteLine("{0}#{1}#{0}",
                    new string('.', outerDots),
                    new string('.', innerDots));
            }
            Console.WriteLine("{0}{1}{0}",
                new string('#', outerDots + 1),
                new string('.', innerDots));
            outerDots = 1;
            innerDots = 2 * n - 5;
            for (int bottom = 0; bottom < n-2; bottom++)
            {
                Console.WriteLine("{0}#{1}#{0}",
                    new string('.', outerDots),
                    new string('.', innerDots));
                outerDots++;
                innerDots -= 2;
            }
            Console.WriteLine("{0}#{0}",
                new string('.',outerDots));
        }
    }
}
