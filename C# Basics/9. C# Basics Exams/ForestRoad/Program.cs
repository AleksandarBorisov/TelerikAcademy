using System;

namespace ForestRoad
{
    class Program
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int height = 2 * width - 1;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j == i)
                    {
                        Console.Write('*');
                    }
                    else if (j == 2 * (width - 1) - i)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }

            //Решение с побитови, което работи вярно до ширина 63
            //for (int i = width - 1; i >= 0; i--)
            //{
            //    long path = ((long)1 << i);
            //    Console.WriteLine(Convert.ToString(path, 2).PadLeft(width, '.').Replace('1', '*').Replace('0', '.'));
            //}
            //for (int i = 1; i <= width - 1; i++)
            //{
            //    long path = ((long)1 << i);
            //    Console.WriteLine(Convert.ToString(path, 2).PadLeft(width, '.').Replace('1', '*').Replace('0', '.'));
            //}
            //Main();
        }
    }
}
