using System;

namespace DiamondTrolls
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int width = n * 2 + 1;
            int height = (6 + ((n - 3) / 2) * 3);
            char lines = '*';
            char font = '.';
            //Top
            Console.WriteLine("{0}{1}{0}",
                new string(font, (width - n) / 2),
                new string(lines, n));
            //Top-Mid
            for (int i = 0; i < height - n - 2; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}",
                    new string(font, (width - 3) / 4 - i),
                     new string(font, (width - 3) / 4 + i));
            }
            //Mid
            Console.WriteLine(new string(lines, width));
            //Bottom
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}",
                    new string(font, i),
                     new string(font, (width - 3 - 2 * i) / 2));
            }
            Console.WriteLine("{0}*{0}",
                new string(font,n));
        }
    }
}
