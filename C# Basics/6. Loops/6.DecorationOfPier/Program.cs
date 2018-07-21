using System;

namespace _6.DecorationOfPier
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()//Тази задача е разновидност на Coin Change Problem
        {
            int n = int.Parse(Console.ReadLine());
            string[] line = Console.ReadLine().Split(' ');
            int[] weights = new int[n];
            int maxSum = 0;
            for (int i = 0; i < n; i++)
            {
                weights[i] = int.Parse(line[i]);
                maxSum += weights[i];
            }
            double minDifference = double.MaxValue;
            for (int i = 1; i < (1 << n); i++)
            {
                int currentSum = 0;
                for (int j = 0; j < n; j++)
                {
                    int bit = ((1 << j) & i) >> j;
                    currentSum += weights[j] * bit;
                }
                double currentDifference = maxSum / 2.0 - currentSum;//Гледаме моментната сума да е най-близо да половината от максималната сума
                if (currentDifference >= 0)
                {//Ако е отрицателно число, значи сме превишили половината и не ни върши работа тази разлика
                    minDifference = Math.Min(minDifference, currentDifference);
                }
            }
            Console.WriteLine(minDifference * 2);
        }
    }
}
