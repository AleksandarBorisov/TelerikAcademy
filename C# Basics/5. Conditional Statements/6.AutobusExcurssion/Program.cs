using System;

namespace _6.AutobusExcurssion
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');
            int width = int.Parse(line[0]);
            int height = int.Parse(line[1]);
            int n = int.Parse(Console.ReadLine());
            int indexCantGoThrough = 0;
            bool cantGoThrough = false;
            for (int i = 1; i <= n; i++)
            {
                line = Console.ReadLine().Split(' ');
                int a = int.Parse(line[0]);
                int b = int.Parse(line[1]);
                if (a < width || b < height)
                {
                    cantGoThrough = true;
                    indexCantGoThrough = i;
                    break;
                }
            }
            if (!cantGoThrough)
            {
                Console.WriteLine("No crash");
            }
            else
            {
                Console.WriteLine(indexCantGoThrough);
            }
        }
    }
}
