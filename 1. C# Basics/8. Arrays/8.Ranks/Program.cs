using System;

namespace _8.Ranks
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] line = Console.ReadLine().Split(' ');
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(line[i]);
            }
            int[] sortedArray = new int[n];
            Array.Copy(numbers, sortedArray, n);
            Array.Sort(sortedArray);
            Array.Reverse(sortedArray);
            for (int i = 0; i < n; i++)
            {
                Console.Write(Array.IndexOf(sortedArray, numbers[i]) + 1 + " ");
            }//Тук може да се оптимизира с BinarySearch
            Console.WriteLine();
        }
    }
}
