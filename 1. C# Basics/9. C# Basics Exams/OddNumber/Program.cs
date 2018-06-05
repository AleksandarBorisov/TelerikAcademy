using System;

namespace OddNumber
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long[] numbers = new long[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = long.Parse(Console.ReadLine());
            }
            Array.Sort(numbers);
            for (int i = 0; i < n; i += 2)
            {
                if (n == 1 || i == n - 1 || numbers[i] != numbers[i + 1])
                {//Ако масивът е с един елемент или сме на последния елемент винаги го взимаме
                    Console.WriteLine(numbers[i]);
                    break;
                }
            }
        }
    }
}
