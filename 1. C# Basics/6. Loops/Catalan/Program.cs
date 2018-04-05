using System;
using System.Numerics;

namespace Catalan
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                BigInteger n = BigInteger.Parse(Console.ReadLine());
                BigInteger catalan = 1;
                BigInteger divisor = 1;
                for (BigInteger i = 1; i <= 2*n; i++)
                {
                    if (i>=n+2)
                    {
                        catalan *= i;
                    }
                    if (i<=n)
                    {
                        divisor *= i;
                    }
                }
                Console.WriteLine(catalan/divisor);
                Console.WriteLine();
            }
        }
    }
}
