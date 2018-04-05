﻿using System;

namespace FirstLargerThanNeighbours
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(' ');
            Console.WriteLine(ReturnIndex(numbers));
        }
        static int ReturnIndex(string[] numbers)
        {
            for (int i = 1; i < numbers.Length - 2; i++)
            {
                if (int.Parse(numbers[i]) > int.Parse(numbers[i - 1]) && int.Parse(numbers[i]) > int.Parse(numbers[i + 1]))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
