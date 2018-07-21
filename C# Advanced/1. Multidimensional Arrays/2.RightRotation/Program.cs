using System;

namespace _2.RightRotation
{
    class Program
    {
        static void Main()
        {
            int[] nums = { 1, 2, 3, 4 };
            int numberOfRotations = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfRotations; i++)
            {
                int temp = nums[nums.Length - 1];//Присвояваме последния елемент на променливата
                for (int j = nums.Length - 1; j >= 1; j--)
                {
                    nums[j] = nums[j - 1];//Местим всички елементи с едно надясно
                }
                nums[0] = temp;//На първия елемент присвояваме стойността на променливата
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
