using System;

namespace RectangleWithStars
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('%', 2 * n));
            int numRows = n;
            if (n % 2 == 0)
            {
                numRows--;
            }
            for (int i = 0; i < numRows; i++)
            {
                Console.Write("%");
                if (i == numRows / 2)
                {
                    Console.Write(new string(' ', n - 2));
                    Console.Write("**");
                    Console.Write(new string(' ', n - 2));
                }
                else
                {
                    Console.Write(new string(' ', 2 * n - 2));
                }
                Console.WriteLine("%");
            }
            Console.WriteLine(new string('%', 2 * n));

        }
    }
}
