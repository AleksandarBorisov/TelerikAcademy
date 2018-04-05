using System;

namespace Butterfly
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int halfRowSize = n - 2;
            bool star = true;
            for (int row = 0; row < halfRowSize; row++)
            {
                if (star)
                {
                    Console.WriteLine("{0}\\ /{0}",
                    new string('*', halfRowSize));
                }
                else
                {
                    Console.WriteLine("{0}\\ /{0}",
                    new string('-', halfRowSize));
                }
                star = !star;
            }
            Console.WriteLine("{0} @ {0}",
                new string(' ',halfRowSize));
            for (int row = 0; row < halfRowSize; row++)
            {
                star = !star;
                if (star)
                {
                    Console.WriteLine("{0}/ \\{0}",
                    new string('*', halfRowSize));
                }
                else
                {
                    Console.WriteLine("{0}/ \\{0}",
                    new string('-', halfRowSize));
                }
            }
        }
    }
}
