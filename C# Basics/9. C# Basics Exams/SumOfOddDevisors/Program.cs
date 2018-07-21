using System;

namespace SumOfOddDevisors
{
    class Program
    {
        static void Main()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int sumOfOddDevisors = 0;
            for (int i = A; i <= B; i++)
            {
                for (int j = 1; j <= i; j += 2)
                {
                    if (i % j == 0)
                    {
                        sumOfOddDevisors += j;
                    }
                }
            }
            Console.WriteLine(sumOfOddDevisors);
        }
    }
}
