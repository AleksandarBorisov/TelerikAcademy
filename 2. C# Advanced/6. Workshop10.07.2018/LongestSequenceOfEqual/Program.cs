using System;

namespace LongestSequenceOfEqual
{
    class Program
    {
        static void Main()
        {
            short n = short.Parse(Console.ReadLine());
            int currentMaxCount = 1;
            int maxCount = 0;
            int firstNumber = int.Parse(Console.ReadLine());
            for (short i = 1; i < n; i++)
            {
                int secondNumber = int.Parse(Console.ReadLine());
                if (secondNumber == firstNumber)
                {
                    currentMaxCount++;
                    maxCount = currentMaxCount > maxCount ? currentMaxCount : maxCount;
                }
                else
                {
                    currentMaxCount = 1;
                }
                firstNumber = secondNumber;
            }
            Console.WriteLine(maxCount);
        }
    }
}
