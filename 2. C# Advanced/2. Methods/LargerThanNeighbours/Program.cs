using System;

namespace LargerThanNeighbours
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(' ');
            Console.WriteLine($"{LargerThanNeighbours(numbers)}");
        }

        static int LargerThanNeighbours(string[] numbers)
        {
            int count = 0;
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if ((int.Parse(numbers[i]) > int.Parse(numbers[i - 1])) && (int.Parse(numbers[i]) > int.Parse(numbers[i + 1])))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
