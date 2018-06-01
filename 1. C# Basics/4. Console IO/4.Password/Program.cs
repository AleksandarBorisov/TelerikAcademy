using System;

namespace _4.Password
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');
            string number = "";
            for (int i = 0; i < line[0].Length; i++)
            {
                number = line[0][i] + number;
            }
            int divisor = int.Parse(line[1]);
            int divident = int.Parse(number);
            Console.WriteLine(divident / divisor + divident % divisor);
        }
    }
}
