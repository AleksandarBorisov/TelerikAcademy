using System;

namespace MockExamPrimeTriangle
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
                int divider = 2;
                while (divider <= Math.Sqrt(i))
                {
                    if (i % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    divider++;
                }
                result += isPrime ? "1" : "0";
                if (isPrime)
                {
                    Console.WriteLine(result);
                }
            }
        }
    }
}
