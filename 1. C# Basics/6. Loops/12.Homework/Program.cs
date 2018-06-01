using System;

namespace _12.Homework
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int divisor = 2;
            if (n == 1)
            {
                divisor = 1;
            }
            else
            {
                while (n % divisor != 0)
                {
                    divisor++;
                    if (divisor > Math.Sqrt(n))
                    {//Ако divisor-a стане по-голям от корен от n значи най-големия делител на n е н
                        divisor = n;
                    }
                }
            }
            Console.WriteLine(n - n / divisor);
        }
    }
}
