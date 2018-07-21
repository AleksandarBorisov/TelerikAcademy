using System;

namespace Batman
{
    class Program
    {
        static void Main()
        {
            int batman = int.Parse(Console.ReadLine());
            char batmanSign = char.Parse(Console.ReadLine());
            string center = batmanSign + " " + batmanSign;
            int whiteSpaces = 0;
            int count = batman;
            for (int i = 1; i <= batman / 2; i++)
            {
                if (i != batman / 2)
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}",
                    new string(' ', whiteSpaces),
                    new string(batmanSign, count),
                    new string(' ', batman));
                    whiteSpaces++;
                    count--;
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{3}{2}{1}{0}",
                    new string(' ', whiteSpaces),
                    new string(batmanSign, count),
                    new string(' ', (batman - 3) / 2),
                    center);
                    whiteSpaces++;
                    count--;
                }
            }
            for (int i = 1; i <= batman / 3; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                    new string(' ', whiteSpaces),
                    new string(batmanSign, count),
                    new string(batmanSign, batman));
            }
            for (int i = 1; i <= batman / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string(' ', whiteSpaces + count + i),
                    new string(batmanSign, batman - 2 * i));
            }
        }
    }
}
