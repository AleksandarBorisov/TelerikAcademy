using System;

namespace Hops
{
    class Program
    {
        static void Main()
        {
            string[] line = Console.ReadLine().Replace(",", "").Split(' ');
            int[] carrots = new int[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                carrots[i] = int.Parse(line[i]);
            }
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.MinValue;
            for (int i = 0; i < m; i++)
            {
                int start = 0;
                int sequenceIndex = 0;
                int currentSum = 0;
                bool[] visitedCarrots = new bool[carrots.Length];
                line = Console.ReadLine().Replace(" ", "").Split(',');
                int[] sequence = new int[line.Length];
                for (int j = 0; j < sequence.Length; j++)
                {
                    sequence[j] = int.Parse(line[j]);
                }
                while (start >= 0 && start < carrots.Length && visitedCarrots[start] == false)
                {
                    currentSum += carrots[start];
                    visitedCarrots[start] = true;
                    start += sequence[sequenceIndex];
                    sequenceIndex = ++sequenceIndex % sequence.Length;
                }
                maxSum = Math.Max(maxSum, currentSum);
            }
            Console.WriteLine(maxSum);
        }
    }
}
