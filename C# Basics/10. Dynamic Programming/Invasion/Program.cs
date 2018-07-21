using System;

namespace Invasion
{
    class Program
    {
        static void Main()
        {
            string[] inputLine = Console.ReadLine().Split(' ');
            int n = int.Parse(inputLine[0]);
            int k = int.Parse(inputLine[1]);
            int module = 300481;
            int[,] groups = new int[n + 1, k + 1];
            groups[1, 1] = 1;
            for (int row = 2; row <= n; row++)
            {
                for (int col = 1; col <= k; col++)
                {
                    groups[row, col] = (row - 1) * groups[row - 1, col] +
                                                    1 * groups[row - 1, col - 1];
                    groups[row, col] %= module;
                }
            }
            Console.WriteLine(groups[n, k]);
        }
    }
}
