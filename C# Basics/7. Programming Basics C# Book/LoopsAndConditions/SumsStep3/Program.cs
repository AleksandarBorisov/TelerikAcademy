using System;

namespace SumsStep3
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 3 == 0)
                {
                    sum1 += int.Parse(Console.ReadLine());
                }
                if (i % 3 == 1)
                {
                    sum2 += int.Parse(Console.ReadLine());
                }
                if (i % 3 == 2)
                {
                    sum3 += int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("sum1 = " + sum1);
            Console.WriteLine("sum2 = " + sum2);
            Console.WriteLine("sum3 = " + sum3);
        }
    }
}
