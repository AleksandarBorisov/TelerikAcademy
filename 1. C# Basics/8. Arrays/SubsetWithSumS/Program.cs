using System;

namespace SubsetWithSumS
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int s = int.Parse(Console.ReadLine());
            for (int combination = 0; combination < (int)Math.Pow(2, n); combination++)
            {
                int bit = 0;
                int sum = 0;
                for (int index = 0; index < n; index++)
                {
                    bit = (combination >> index) & 1;
                    sum += numbers[index] * bit;
                }
                if (sum == s)
                {
                    Console.WriteLine("yes");
                    break;
                }
            }
        }
    }
}
