using System;

namespace MaximalSequence
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int count = 1;
            int maxCount = 0;
            for (int row = 0; row < n; row++)
            {
                numbers[row] = int.Parse(Console.ReadLine());
            }
            for (int row = 1; row < n; row++)
            {
                if (numbers[row]==numbers[row-1])
                {
                    count++;
                    maxCount = (count > maxCount) ? count : maxCount;
                }
                else
                {
                    count = 1;
                }
            }
            Console.WriteLine(maxCount);
        }
    }
}
