using System;

namespace PersianRugs
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int xSize = int.Parse(Console.ReadLine());
            int width = 2 * n + 1;
            char sides = '#';
            char whiteSpace = ' ';
            for (int row = 0; row < n; row++)
            {
                int spacesLeft = width - row - row - 1 - 1- xSize - xSize;
                if (spacesLeft >= 3)//Проверяваме в самия for цикъл дали оставащото място е достатъчно
                {// да събере малкия триъгълник
                    Console.WriteLine("{0}\\{1}\\{2}/{1}/{0}",
                    new string(sides, row),
                    new string(whiteSpace, xSize),
                    new string('.',spacesLeft-2));
                }
                else
                {
                    Console.WriteLine("{0}\\{1}/{0}",
                    new string(sides, row),
                    new string(whiteSpace, width - 2 - 2 * row));
                }
            }
            Console.WriteLine("{0}X{0}",
                new string(sides, n));
            for (int row = n-1; row >= 0; row--)
            {
                int spacesLeft = width - row - row - 1 - 1 - xSize - xSize;
                if (spacesLeft >= 3)//Проверяваме в самия for цикъл дали оставащото място е достатъчно
                {// да събере малкия триъгълник
                    Console.WriteLine("{0}/{1}/{2}\\{1}\\{0}",
                    new string(sides, row),
                    new string(whiteSpace, xSize),
                    new string('.', spacesLeft - 2));
                }
                else
                {
                    Console.WriteLine("{0}/{1}\\{0}",
                    new string(sides, row),
                    new string(whiteSpace, width - 2 - 2 * row));
                }
            }
        }
    }
}
