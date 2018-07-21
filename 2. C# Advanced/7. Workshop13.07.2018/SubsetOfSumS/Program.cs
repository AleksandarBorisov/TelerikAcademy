using System;

namespace SubsetOfSumS
{
    class Program
    {
        static void Main()
        {
            int sum = int.Parse(Console.ReadLine());
            string[] line = Console.ReadLine().Split();
            int[] numbers = new int[line.Length];
            int maxSum = 0;
            for (int i = 0; i < line.Length; i++)
            {
                numbers[i] = int.Parse(line[i]);
                maxSum += numbers[i];
            }
            bool[] oldSums = new bool[maxSum + 1];
            bool[] newSums = new bool[maxSum + 1];
            int startIndex = 0;
            int endIndex = 1;
            int newStartIndex = startIndex;
            int newEndIndex = endIndex;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = startIndex; j <= endIndex; j++)
                {
                    if (oldSums[j])
                    {
                        newSums[j + numbers[i]] = true;
                        if (j + numbers[i] < startIndex)
                        {
                            newStartIndex = j + numbers[i];
                        }
                        if (j + numbers[i] > endIndex)
                        {
                            newEndIndex = j + numbers[i];
                        }
                    }
                }
                newSums[numbers[i]] = true;
                Array.Copy(newSums, oldSums, maxSum);
                startIndex = Math.Min(numbers[i], newStartIndex);
                endIndex = Math.Max(numbers[i], newEndIndex);
            }
            Console.WriteLine($"{(oldSums[sum] ? "yes" : "no")}");
        }
    }
}
