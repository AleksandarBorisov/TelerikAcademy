using System;

namespace _3.ReverseArray
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int leftIndex = 0;
            int rightIndex = numbers.Length - 1;
            while (leftIndex <= rightIndex)
            {
                string swap = numbers[leftIndex];
                numbers[leftIndex] = numbers[rightIndex];
                numbers[rightIndex] = swap;
                leftIndex++;
                rightIndex--;
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
