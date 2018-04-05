using System;

namespace TrailingZeroes
{
    class Program
    {
        static void Main()
        {

                int n = int.Parse(Console.ReadLine());
                int counter = 0;
                for (int i = 1; i <= n; i++)
                {
                    int k = i;
                    while (k % 5 == 0)
                    {
                        k /= 5;
                        counter++;
                    }
                }
                Console.WriteLine(counter);

        }
    }
}
