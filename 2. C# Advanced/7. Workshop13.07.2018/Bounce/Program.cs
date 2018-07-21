using System;

namespace Bounce
{
    class Program
    {
        static void Main()
        {
            string[] line = Console.ReadLine().Split();
            int n = int.Parse(line[0]);
            int m = int.Parse(line[1]);
            bool IncrementRow = true;
            bool IncrementCol = true;
            int row = 0;
            int col = 0;
            long sum = 1;
            while (!((row == n - 1 && col == m - 1) || (row == n - 1 && col == 0) || (row == 0 && col == m - 1)))
            {
                if (IncrementRow)
                {
                    row++;
                    if (row == n - 1)
                    {
                        IncrementRow = false;
                    }
                }
                else
                {
                    row--;
                    if (row == 0)
                    {
                        IncrementRow = true;
                    }
                }
                if (IncrementCol)
                {
                    col++;
                    if (col == m - 1)
                    {
                        IncrementCol = false;
                    }
                }
                else
                {
                    col--;
                    if (col == 0)
                    {
                        IncrementCol = true;
                    }
                }
                sum += (long)Math.Pow(2, row + col);
            }
            Console.WriteLine($"{sum}");
        }
    }
}
