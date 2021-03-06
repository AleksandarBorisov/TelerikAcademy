﻿using System;

namespace CrookedWalls
{
    class Program
    {
        static void Main()
        {
            string[] walls = Console.ReadLine().Split(' ');
            long sum = 0;
            int position = 1;
            while (position < walls.Length)
            {
                long distance = Math.Abs(long.Parse(walls[position]) - long.Parse(walls[position - 1]));
                if (distance % 2 == 0)
                {
                    position += 2;
                    sum += distance;
                }
                else
                {
                    position++;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
