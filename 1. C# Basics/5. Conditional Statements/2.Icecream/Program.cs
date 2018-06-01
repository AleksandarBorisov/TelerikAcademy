using System;

namespace _2.Icecream
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            long n = long.Parse(line[0]);
            long number = long.Parse(line[1]);
            while (number > 0)
            {
                int digit = (int)(number % 10);
                if (digit != 0)
                {
                    n--;
                }
                number /= 10;
            }
            if (n >= 0)
            {//В условието не е казано, че броя за цифрите на k неможе да е по-голям от n, затова аз го проверявам
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
