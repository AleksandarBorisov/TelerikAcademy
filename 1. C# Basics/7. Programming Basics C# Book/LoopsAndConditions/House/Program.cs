using System;

namespace House
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var stars = 1;
            if (n % 2 == 0)
            {
                stars++;
            }
            var roofLength = (int)Math.Ceiling(n / 2f);
            for (int top = 0; top < roofLength; top++)
            {
                var padding = (n - stars) / 2;
                var line = new string('-', padding) +
                     new string('*', stars) +
                     new string('-', padding);
                Console.WriteLine(line);
                stars += 2;
            }
            for (int i = 0; i < n / 2; i++)
            {
                string line = '|' + new string('*', n - 2) + '|';
                Console.WriteLine(line);
            }
        }
    }
}
