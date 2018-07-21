using System;
using System.Numerics;

namespace CalculateAgain_
{
    class Program
    {
        static void Main()
        {
                BigInteger n = ulong.Parse(Console.ReadLine());
                BigInteger k = ulong.Parse(Console.ReadLine());
                BigInteger faktorial = 1;
                for (BigInteger i = (k + 1); i <= n; i++)
                {
                    faktorial *= i;
                }
                Console.WriteLine(faktorial);
        }
    }
}
