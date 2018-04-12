using System;
using System.Collections.Generic;

namespace _1.GroupByDevision
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 0, 1, 4, 113, 55, 3, 1, 2, 66, 557, 124, 2 };
            //int[] sizes = new int[3];
            //int[] offsets = new int[3];
            ////Calculate the sizes of each remainder
            //foreach (var number in numbers)
            //{
            //    int remainder = number % 3;
            //    sizes[remainder]++;
            //}
            ////Calculate the list of numbers or each remainder
            //int[][] numbersByRemainder =
            //{
            //    new int[sizes[0]],
            //    new int[sizes[1]],
            //    new int[sizes[2]]
            //};
            //foreach (var number in numbers)
            //{
            //    int remainder = number % 3;
            //    int index = offsets[remainder];//offsets ни пази индекса на последния добавен елемент
            //    numbersByRemainder[remainder][index] = number;
            //    offsets[remainder]++;
            //}
            List<int>[] jagged = new List<int>[3];
            for (int i = 0; i < jagged.Length; i++)
            {
                jagged[i] = new List<int>();
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                jagged[numbers[i] % 3].Add(numbers[i]);
            }
            //Print the result jagged array
            //for (int row = 0; row < numbersByRemainder.Length; row++)
            //{
            //    //Console.WriteLine(string.Join(", ",numbersByRemainder[row]));
            //    for (int col = 0; col < numbersByRemainder[row].Length; col++)
            //    {
            //        Console.Write("{0}, ",numbersByRemainder[row][col]);
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
