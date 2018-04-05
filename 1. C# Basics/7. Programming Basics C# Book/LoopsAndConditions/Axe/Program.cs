using System;

namespace Axe
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int leftDashes = 3 * n;
            int rightDashes = 2 * n - 2;
            int innerDashes = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}",
                    new string('-', leftDashes),
                    new string('-', innerDashes),
                    new string('-', rightDashes));
                rightDashes--;
                innerDashes++;
            }
            rightDashes++;
            innerDashes--;
            for (int handle = 0; handle < n / 2; handle++)
            {
                Console.WriteLine("{0}*{1}*{2}",
                    new string('*', leftDashes),
                    new string('-', innerDashes),
                    new string('-', rightDashes));
            }
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}",
                    new string('-', leftDashes),
                    new string('-', innerDashes),
                    new string('-', rightDashes));
                leftDashes--;
                innerDashes += 2;
                rightDashes--;
            }
            Console.WriteLine("{0}*{1}*{2}",
                    new string('-', leftDashes),
                    new string('*', innerDashes),
                    new string('-', rightDashes));
        }
    }
}
