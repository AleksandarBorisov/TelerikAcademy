using System;

namespace SumOfEvenDevisors
{
    class Program
    {
        static void Main()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int sumOfEvenDevisors = 0;
            for (int i = A; i <= B; i++)
            {
                for (int j = 2; j <= i; j += 2)
                {
                    if (i % j == 0)
                    {
                        sumOfEvenDevisors += j;
                    }
                }
            }
            Console.WriteLine(sumOfEvenDevisors);
        }
    }
}
