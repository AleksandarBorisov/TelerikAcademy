using System;

namespace SortByStringLength
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] random = new string[n];
            for (int i = 0; i < n; i++)
            {
                random[i] = Console.ReadLine();
            }
            Array.Sort(random);//Подрежда лексикографски масиви от string-ове
            Console.WriteLine(String.Join(" ", random));
        }
    }
}
