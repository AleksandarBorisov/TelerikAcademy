using System;

namespace GetLargestNumber
{
    class Program
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');//Добавих това
            int first = int.Parse(numbers[0]);
            int second = int.Parse(numbers[1]);
            int third = int.Parse(numbers[2]);//х това
            int max = GetMax(GetMax(first, second), third);
            Console.WriteLine(max);
        }
        static int GetMax(int first, int second)
        {
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
