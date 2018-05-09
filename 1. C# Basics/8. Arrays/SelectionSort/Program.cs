using System;

namespace SelectionSort
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] forSorting = new int[n];
            for (int i = 0; i < n; i++)
            {
                forSorting[i] = int.Parse(Console.ReadLine());
            }
            for (int row = 0; row < n; row++)
            {
                for (int j = row + 1; j < n; j++)
                {
                    if (forSorting[j] < forSorting[row])
                    {
                        int minValue = forSorting[j];
                        forSorting[j] = forSorting[row];
                        forSorting[row] = minValue;
                    }
                }
                Console.WriteLine(forSorting[row]);
            }
            //Алгоритъмът работи по следния начин:
            //Намира най-малкия елемент в списъка като сравнява първият елемент с всички останали
            //Разменя го с елемента на първа позиция
            //Повтаря горните две стъпки за всеки следващ елемент
        }
    }
}
