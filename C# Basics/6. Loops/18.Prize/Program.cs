using System;

namespace _18.Prize
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            string[] line = Console.ReadLine().Split();
            bool deserves = true;
            byte countOfStars = 0;
            for (int i = 0; i < 7; i++)
            {
                if (line[i] == "6")
                {
                    countOfStars++;
                }
                if (line[i] == "2")
                {
                    deserves = false;
                    break;
                }
            }
            if (deserves && countOfStars != 0)
            {
                Console.WriteLine($"{new string('*', countOfStars)}");
            }
            else
            {
                Console.WriteLine($"No");
            }
        }
    }
}
