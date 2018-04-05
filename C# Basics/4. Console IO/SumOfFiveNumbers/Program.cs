using System;

namespace SumOfFiveNumbers
{
    class Program
    {
        static void Main()
        {
            int sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
