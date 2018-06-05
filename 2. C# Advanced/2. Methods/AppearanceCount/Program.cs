using System;
namespace AppearanceCount
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(' ');
            string search = Console.ReadLine();
            Console.WriteLine(SearchMatrix(numbers, search));
        }

        static int SearchMatrix(string[] numbers, string searchedNumber)
        {
            int count = 0;
            foreach (string number in numbers)
            {
                if (number == searchedNumber)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
