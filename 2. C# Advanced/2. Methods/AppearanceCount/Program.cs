using System;
namespace AppearanceCount
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(' ');
            int search = int.Parse(Console.ReadLine());
            Console.WriteLine(SearchMatrix(numbers, search));
        }

        static int SearchMatrix(string[] numbers, int searchedNumber)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (int.Parse(numbers[i]) == searchedNumber)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
