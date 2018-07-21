using System;

namespace EasterMister
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int heightEgg = 2 * n;
            int widthEgg = 3 * n - 1;
            int width = 3 * n + 1;
            int sideDots = (width - (n - 1)) / 2;
            //Top
            Console.WriteLine("{0}{1}{0}",
                new string('.', sideDots),
                new string('*', n - 1));
            //Top half
            for (int i = 0; i < n - 2; i++)
            {
                if (sideDots > 1)
                {
                    sideDots -= 2;
                }
                Console.WriteLine("{0}*{1}*{0}",
                    new string('.', sideDots),
                    new string('.', width - 2 - 2 * sideDots));
            }
            //Middle
            bool dot = true;
            for (int i = 0; i < 2; i++)
            {
                Console.Write(".*");
                for (int j = 0; j < width - 4; j++)
                {
                    if (dot)
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                    dot = !dot;
                }
                Console.WriteLine("*.");
            }
            //Bottom half
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string('.', sideDots),
                    new string('.', width - 2 - 2 * sideDots));
                if (i >= (n - 2) / 2 - 1)//Ако сме на реда преди половината от долната част
                {
                    sideDots += 2;
                }
            }
            //Bottom
            Console.WriteLine("{0}{1}{0}",
                new string('.', sideDots),
                new string('*', n - 1));
        }
    }
}
