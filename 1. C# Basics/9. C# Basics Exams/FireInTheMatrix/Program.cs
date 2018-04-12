using System;

namespace FireInTheMatrix
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            //Top flame
            for (int row = 0; row <= n - 2; row += 2)//Ориентър ни е броя на точките в центъра
            {
                Console.WriteLine("{0}#{1}#{0}",
                    new string('.', (n - 2 - row) / 2),
                    new string('.', row));
            }
            //Bottom flame
            for (int row = 0; row < n / 4; row++)//Ориентир са ни броя редова от долната част
            {
                Console.WriteLine("{0}#{1}#{0}",
                    new string('.', row),
                    new string('.', n - 2 - 2 * row));
            }
            //Middle torch
            Console.WriteLine(new string('-', n));
            //Bottom torch
            for (int row = n / 2; row >= 1; row--)//Ориентир брой наклонени черти
            {
                Console.WriteLine("{0}{1}{2}{0}",
                    new string('.', n / 2 - row),
                    new string('\\', row),
                    new string('/', row));
            }
        }
    }
}
