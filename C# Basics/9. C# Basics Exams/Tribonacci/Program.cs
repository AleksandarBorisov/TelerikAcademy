using System;
using System.Numerics;

namespace Tribonacci
{
    class Program
    {
        static void Main()
        {
            BigInteger t1 = BigInteger.Parse(Console.ReadLine());
            BigInteger t2 = BigInteger.Parse(Console.ReadLine());
            BigInteger t3 = BigInteger.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (int i = 4; i <= n; i++)
            {
                BigInteger t4 = t1 + t2 + t3;
                t1 = t2;
                t2 = t3;
                t3 = t4;
            }
            Console.WriteLine(t3);
        }
    }
}
