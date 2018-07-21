using System;

namespace SortingArray
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(' ');
            Console.WriteLine(String.Join(" ", Sort(numbers)));
        }

        static string ReturnMax(string[] numbers, int startIndex)
        {
            string max = numbers[startIndex];
            for (int i = startIndex; i >= 0; i--)
            {
                if (int.Parse(numbers[i]) > int.Parse(max))
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        static string[] Sort(string[] numbers)
        {
            for (int i = numbers.Length - 1; i >= 0; i--)
            {//Започваме от последния елемент
                string temp = numbers[i];//Пазим стойността на настоящия елемент
                int indexMax = Array.IndexOf(numbers, ReturnMax(numbers, i));//Пазим индекса на максималния върнат елемент
                numbers[i] = ReturnMax(numbers, i);//Присвояваме стойността на максималния върнат елемент
                numbers[indexMax] = temp;//Присвояваме стойността на настоящия елемент
            }
            return numbers;
        }
    }
}
