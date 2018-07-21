using System;

namespace _7.Windows
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');
            int windows = int.Parse(line[0]);
            int price = int.Parse(line[1]);
            int sum = 0;
            for (int i = 0; i < windows; i++)
            {
                line = Console.ReadLine().Split(' ');
                if (line[2] == "1")
                {
                    sum += int.Parse(line[0]) * int.Parse(line[1]) * price;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
