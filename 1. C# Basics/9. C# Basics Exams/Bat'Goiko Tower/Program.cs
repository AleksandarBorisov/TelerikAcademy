using System;

namespace Bat_Goiko_Tower
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sides = n - 1;
            int width = 2 * n;
            char symbol;
            int nextCrossbeamRow = 2;//Определя ни следващия ред на напречна греда
            int step = 2;//Определя ни по-следващия ред на напречна греда
            for (int row = 1; row <= n; row++)
            {
                if (row % nextCrossbeamRow == 0)
                {
                    symbol = '-';
                    nextCrossbeamRow += step;
                    step++;
                }
                else
                {
                    symbol = '.';
                }
                Console.WriteLine("{0}/{1}\\{0}",
                    new string('.', sides),
                    new string(symbol, width - 2 - 2 * sides));
                sides--;
            }
        }
    }
}
