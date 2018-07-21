using System;

namespace _6.AboveTheMainDiagonal
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long sum = 0;
            for (int row = 0; row < n; row++)
            {
                long currentSum = (long)Math.Pow(2, row);
                for (int col = 0; col < n; col++)
                {
                    if (col <= row)
                    {
                        sum += currentSum;
                    }
                    currentSum *= 2;
                }
            }
            Console.WriteLine(sum);
            //Решение от упражненията
            long totalSum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i <= j)
                    {
                        totalSum += (long)Math.Pow(2, i + j);
                    }
                }
            }
        }
    }
}
