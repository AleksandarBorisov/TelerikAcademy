using System;

namespace DogeCoin
{
    class Program
    {
        static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');
            int n = int.Parse(line[0]);
            int m = int.Parse(line[1]);
            int coinCount = int.Parse(Console.ReadLine());
            int[,] coins = new int[n, m];
            for (int i = 1; i <= coinCount; i++)
            {
                string[] coordinates = Console.ReadLine().Split(' ');
                int x = int.Parse(coordinates[0]);
                int y = int.Parse(coordinates[1]);
                coins[x, y]++;
            }
            int[,] maxCoins = new int[n, m];
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    int up = 0;
                    int left = 0;
                    if (row > 0)
                    {
                        up = maxCoins[row - 1, col];
                    }
                    if (col > 0)
                    {
                        left = maxCoins[row, col - 1];
                    }
                    maxCoins[row, col] = coins[row, col] + Math.Max(left, up);
                }
            }
            Console.WriteLine(maxCoins[n - 1, m - 1]);
        }
    }
}
