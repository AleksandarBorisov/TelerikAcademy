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
        }
    }
}
