using System;

namespace _19.LuckyNumber
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            string number = Console.ReadLine();
            int product = 1;
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (char.IsDigit(number[i]))
                {
                    product *= number[i] - '0';
                }
                else
                {
                    sum += number[i];
                }
            }
            if (product == sum / 10)
            {
                Console.WriteLine($"Yes {product}");
            }
            else
            {
                Console.WriteLine($"No");
            }
        }
    }
}
