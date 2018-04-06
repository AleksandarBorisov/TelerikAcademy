using System;

namespace MaximalKSum
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int sum = 0;
            for (int index = 0; index < n; index++)
            {
                numbers[index] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numbers);
            for (int row = n - k; row < n; row++)
            {
                sum += numbers[row];
            }
            Console.WriteLine(sum);
        }
    }
}
