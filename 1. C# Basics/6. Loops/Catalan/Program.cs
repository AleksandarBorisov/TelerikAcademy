using System;
using System.Numerics;

namespace Catalan
{
    class Program
    {
        static void Main()
        {
            //while (true)
            //{
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger catalan = 1;
            BigInteger divisor = 1;
            for (BigInteger i = n + 2; i <= 2 * n; i++)
            {//Числата до n-1 се съкращават и пресмятаме каквото остане в числителя и знаменателя
                catalan *= i;
                divisor *= i - n;
            }
            Console.WriteLine(catalan / divisor);
            Console.WriteLine();
            //}
        }
    }
}
