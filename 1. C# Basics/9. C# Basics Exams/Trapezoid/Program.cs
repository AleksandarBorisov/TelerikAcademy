using System;

namespace Trapezoid
{
    class Program
    {
        static void Main()
        {
            int topWidth = int.Parse(Console.ReadLine());
            int bottomWidth = 2 * topWidth;
            Console.WriteLine("{0}{1}",
                new string('.', topWidth),
                new string('*', topWidth));
            for (int i = topWidth - 1; i >= 1; i--)
            {
                Console.WriteLine("{0}*{1}*",
                    new string('.', i),
                    new string('.', bottomWidth - i - 2));
            }
            Console.WriteLine("{0}",
                new string('*', bottomWidth));
        }
    }
}
