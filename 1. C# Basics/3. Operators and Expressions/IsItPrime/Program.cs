using System;

namespace IsItPrime
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Boolean nIsPrime = true;
            if (n < 0)
            {
                nIsPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        nIsPrime = false;
                    }
                }
            }
            
            Console.WriteLine(nIsPrime?"true":"false");
        }
    }
}
