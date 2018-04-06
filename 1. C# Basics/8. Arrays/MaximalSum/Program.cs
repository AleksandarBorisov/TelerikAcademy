using System;

namespace MaximalSum
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxSum = 0;
            int counter = 0;
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }//Brute-Force is a Slow and inefficient when the problem size is large
            for (int i = 0; i < n; i++)
            {
                sum += numbers[i];
                maxSum = (sum > maxSum) ? sum : maxSum;
                if (i == n - 1)
                {
                    i = counter;
                    counter++;
                    sum = 0;
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
