using System;

namespace TribonacciTriangle
{
    class Program
    {
        static void Main()
        {
            long t1 = long.Parse(Console.ReadLine());
            long t2 = long.Parse(Console.ReadLine());
            long t3 = long.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine(t1);
            Console.WriteLine(t2 + " " + t3);
            for (int i = 3; i <= l; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    long t4 = t1 + t2 + t3;
                    t1 = t2;
                    t2 = t3;
                    t3 = t4;
                    Console.Write(t3);
                    char whitespace = j != i ? ' ' : '\n';
                    Console.Write(whitespace);
                }
            }
        }
    }
}
