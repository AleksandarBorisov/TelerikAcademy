using System;

namespace AllocateArray
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int row = 0; row < n; row++)
            {
                numbers[row] = row * 5;
                Console.WriteLine(numbers[row]);
            }
        }
    }
}
