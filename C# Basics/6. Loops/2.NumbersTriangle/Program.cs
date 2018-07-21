using System;

namespace _2.NumbersTriangle
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 2 * n - 1; i++)
            {
                int max = i;
                if (i > n)
                {
                    max = 2 * n - i;
                }
                for (int j = 1; j <= max; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
