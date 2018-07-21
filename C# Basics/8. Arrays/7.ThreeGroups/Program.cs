using System;

namespace _7.ThreeGroups
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');
            string[] remainderCount = new string[3];
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = int.Parse(numbers[i]);
                remainderCount[number % 3] += numbers[i] + " ";
            }
            foreach (var count in remainderCount)
            {
                Console.WriteLine(count);
            }
        }
    }
}
