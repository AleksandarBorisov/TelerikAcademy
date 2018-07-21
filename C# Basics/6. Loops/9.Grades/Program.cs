using System;

namespace _9.Grades
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] line = Console.ReadLine().Split(' ');
            int sum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int grade = int.Parse(line[i]);
                if (grade > max)
                {
                    max = grade;
                }
                if (grade < min)
                {
                    min = grade;
                }
                sum += grade;
            }
            Console.WriteLine(Math.Round((double)(sum - max - min) / (n - 2)));
        }
    }
}
