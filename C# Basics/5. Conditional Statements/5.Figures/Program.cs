using System;

namespace _5.Figures
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int a = int.Parse(line[0]);
            int b = int.Parse(line[1]);
            int c = int.Parse(line[2]);
            int d = int.Parse(line[3]);
            int h = int.Parse(line[4]);
            int minLength = a + b + c + d + h + d + h - Math.Max(d, h) - Math.Max(a, Math.Max(b, c)) + Math.Abs(Math.Max(d, h) - Math.Max(a, Math.Max(b, c)));
            //Логиката е следната: Събираме всички страни, след това вадим двете най-дълги, защото те ще са долепени, и прибаваме
            //разликата им, защото и тя трябва да се покрие
            Console.WriteLine(minLength);
        }
    }
}
