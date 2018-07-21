using System;

namespace _7.Order
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');
            int h1 = int.Parse(line[0]);
            int h2 = int.Parse(line[1]);
            int h3 = int.Parse(line[2]);
            int h4 = int.Parse(line[3]);
            if ((h1 < h2) && ( h2 < h3) && (h3 < h4))
            {
                Console.WriteLine("Ascending");
            }
            else if ((h1 > h2) && (h2 > h3) && (h3 > h4))
            {
                Console.WriteLine("Descending");
            }
            else
            {
                Console.WriteLine("Mixed");
            }
        }
    }
}
