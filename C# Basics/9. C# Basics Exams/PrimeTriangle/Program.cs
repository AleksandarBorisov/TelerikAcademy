using System;

namespace PrimeTriangle
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 1; i <= n; i++)
            {
                bool isPrime = true;
                int divisor = 2;
                while (divisor <= Math.Sqrt(i))
                {
                    if (i % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    divisor++;
                }
                result += (isPrime ? "1" : "0");
                if (isPrime)
                {
                    Console.WriteLine(result);
                }
            }
        }
    }
}
