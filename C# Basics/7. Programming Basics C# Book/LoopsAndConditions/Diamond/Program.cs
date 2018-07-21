using System;

namespace Diamond
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var leftRight = (n - 1) / 2;
            for (int top = 0; top < (n + 1) / 2; top++)
            {
                Console.Write(new string('-', leftRight));
                Console.Write('*');
                var mid = n - 2 * leftRight - 2;
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid) + '*');
                }
                Console.Write(new string('-', leftRight));
                leftRight--;
                Console.WriteLine();
            }
            leftRight++;//За да започнем от 0
            for (int bottom = 0; bottom < (n - 1) / 2; bottom++)
            {
                leftRight++;
                Console.Write(new string('-', leftRight));
                Console.Write('*');
                var mid = n - 2 * leftRight - 2;
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid) + '*');
                }
                Console.Write(new string('-', leftRight));
                Console.WriteLine();
            }
        }
    }
}
