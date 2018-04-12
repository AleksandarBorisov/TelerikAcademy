using System;

namespace Cube
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());//Този вариант е доста по-бърз от долния
            int whiteSpaces = n - 1;
            int xCount = 0;
            Console.WriteLine("{0}{1}",
                new string(' ', whiteSpaces),
                new string(':', n));
            for (int i = 0; i < n - 2; i++)
            {
                whiteSpaces--;
                Console.WriteLine("{0}:{1}:{2}:",
                    new string(' ', whiteSpaces),
                    new string('/', n - 2),
                    new string('X', xCount));
                xCount++;
            }
            Console.WriteLine("{0}{1}:",
                new string(':', n),
                new string('X', n - 2));
            for (int i = 0; i < n - 2; i++)
            {
                xCount--;
                Console.WriteLine(":{0}:{1}:",
                    new string(' ', n - 2),
                    new string('X', xCount));
            }
            Console.WriteLine("{0}",
                new string(':', n));
            //int fieldSize = 2 * n - 1;
            //int middle = n - 1;
            //char whiteSpace = ' ';
            //char top = '/';
            //char side = 'X';
            //char edge = ':';
            //for (int row = 0; row < fieldSize; row++)
            //{
            //    for (int col = 0; col < fieldSize; col++)
            //    {
            //        if (col == 0 && row >= middle ||
            //            col == middle && row >= middle ||
            //            col == fieldSize - 1 && row <= middle)
            //        {//Vertical edges
            //            Console.Write(edge);
            //        }
            //        else if (row == 0 && col >= middle ||
            //            row == middle && col <= middle ||
            //            row == fieldSize - 1 && col <= middle)
            //        {//Horizontal edges
            //            Console.Write(edge);
            //        }
            //        else if (row + col == middle ||
            //            row + col == fieldSize - 1 + middle ||
            //            row + col == fieldSize - 1 && row < middle)
            //        {//Diagonal edges
            //            Console.Write(edge);
            //        }
            //        else if (col > middle &&
            //            row + col < fieldSize - 1 + middle &&
            //            row + col > fieldSize - 1)
            //        {//Side
            //            Console.Write(side);
            //        }
            //        else if (row < middle &&
            //            row + col > middle)//Нямаме нужда от проверката за третия диагонал row + col < fieldSize - 1 && (row < middle))
            //        //защото ако горния if е изпълнен въобще няма да влезнем в този else
            //        {//Top
            //            Console.Write(top);
            //        }
            //        else
            //        {
            //            Console.Write(whiteSpace);
            //        }
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
