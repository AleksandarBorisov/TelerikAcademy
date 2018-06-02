using System;

namespace FromBookDoubleMatrixC
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[n, n];
            int i = 1;
            int row = n - 1;
            int col = n;
            while (i <= n * n)
            {
                if (col != 0)
                {
                    array[row, --col] = i++;
                }
                else if (row > col && col == 0)
                {
                    array[--row, col] = i++;
                }
                int rightIndex = col;
                int leftIndex = row;
                while (rightIndex < n - 1 && leftIndex != 0)
                {
                    array[--leftIndex, ++rightIndex] = i++;
                }
            }
            for (int k = 0; k < n; k++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{array[k, j],3}{((j != n - 1) ? " " : "\n")}");
                }
            }
            col = 0;
            row = n;
            i = 1;
            while (i <= n * n)
            {
                if (row > col)
                {
                    array[--row, col] = i++;
                }
                else
                {
                    array[row, ++col] = i++;
                }
                int rightIndex = col;
                int leftIndex = row;
                while (rightIndex < n - 1 && leftIndex < n - 1)
                {
                    array[++leftIndex, ++rightIndex] = i++;
                }
            }
            for (int k = 0; k < n; k++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{array[k, j],3}{((j != n - 1) ? " " : "\n")}");
                }
            }
        }
    }
}
