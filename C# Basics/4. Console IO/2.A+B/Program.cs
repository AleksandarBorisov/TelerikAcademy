using System;

namespace _2.A_B
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                Console.WriteLine(int.Parse(line[0]) + int.Parse(line[1]));
            }
        }
    }
}
