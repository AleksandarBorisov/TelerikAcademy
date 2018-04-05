using System;
using System.Numerics;

namespace Calculate3_
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                BigInteger n = BigInteger.Parse(Console.ReadLine());
                BigInteger k = BigInteger.Parse(Console.ReadLine());
                BigInteger divisor = 1;
                BigInteger faktorial = 1;
                for (int i = 1; i <= n; i++)
                {
                    if (i <= (n - k))
                    {
                        divisor *= i;
                    }
                    if (i > k)
                    {
                        faktorial *= i;
                    }
                }
                Console.WriteLine(faktorial / divisor);
                Console.WriteLine();
            }
        }
    }
}
