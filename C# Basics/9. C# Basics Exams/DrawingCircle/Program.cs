using System;

namespace DrawingCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Тази задача е от подготовката за изпита (Cube) и ни показва как да рисуваме кръгче с функции
            int n = 17;// int.Parse(Console.ReadLine());
            int radius = 9;// int.Parse(Console.ReadLine());
            char coordinateSystemVertical = '|';
            char coordinateSystemHorizontal = '-';
            char emptySpace = ' ';
            char circle = '$';
            int mid = n - 1;
            for (int row = 0; row < 2 * n - 1; row++)
            {
                for (int col = 0; col < 2 * n - 1; col++)
                {
                    if (row == mid && col == mid)
                    {
                        Console.Write('+');
                    }
                    else if (col == mid)
                    {
                        Console.Write(coordinateSystemVertical);
                    }
                    else if (row == mid)
                    {
                        Console.Write(coordinateSystemHorizontal);
                    }
                    else if ((row - mid) * (row - mid) + (col - mid) * (col - mid) <= radius * radius)
                    {//намаляйки row и col те по-късно ще станат равни на радиуса и затова окръжността се измества
                     //надолу и съответно надясно
                        Console.Write(circle);
                    }
                    else
                    {
                        Console.Write(emptySpace);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
