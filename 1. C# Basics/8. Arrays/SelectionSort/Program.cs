using System;

namespace SelectionSort
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] forSorting = new int[n];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                forSorting[i] = int.Parse(Console.ReadLine());
            }
            for (int row = 0; row < n; row++)
            {
                int minValue = forSorting[row];
                for (int j = row + 1; j < n; j++)
                {
                    if (forSorting[j] < minValue)
                    {
                        minValue = forSorting[j];
                        index = j;
                    }
                }
                if (minValue!=forSorting[row])
                {
                    forSorting[index] = forSorting[row];
                    forSorting[row] = minValue;
                }
                Console.WriteLine(forSorting[row]);
            }
        }
    }
}
