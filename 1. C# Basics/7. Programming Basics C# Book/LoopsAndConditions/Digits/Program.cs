using System;

namespace Digits
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int N = n / 100 + (n / 10) % 10;
            int M = n / 100 + n % 10;
            int num = n;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (num % 5 == 0)
                    {
                        num = num - n / 100;
                    }
                    else if (num % 3 == 0)
                    {
                        num = num - (n / 10) % 10;
                    }
                    else
                    {
                        num = num + n % 10;
                    }
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
