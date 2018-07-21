using System;

namespace _3.GoodNumbers
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int a = int.Parse(line[0]);
            int b = int.Parse(line[1]);
            int goodNumbersCount = 0;
            for (int i = a; i <= b; i++)
            {
                bool good = true;
                int number = i;
                while (good && number > 0)
                {
                    int digit = number % 10;
                    if (digit != 0 && i % digit != 0)
                    {
                        good = false;
                    }
                    number /= 10;
                }
                if (good)
                {
                    goodNumbersCount++;
                }
            }
            Console.WriteLine(goodNumbersCount);
        }
    }
}
