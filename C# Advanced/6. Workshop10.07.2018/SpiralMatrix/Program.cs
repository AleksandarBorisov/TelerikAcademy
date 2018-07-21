using System;

namespace SpiralMatrix
{
    class Program
    {
        static void Main()
        {
            byte n = byte.Parse(Console.ReadLine());
            short[,] matrix = new short[n,n];
            short counter = 1;
            int row = 0;
            int col = 0;
            while (counter <= n * n)
            {
                while (col < n && matrix[row,col] == 0 )
                {
                    matrix[row, col++] = counter++;
                }
                col--;
                row++;
                while (row < n && matrix[row, col] == 0)
                {
                    matrix[row++, col] = counter++;
                }
                row--;
                col--;
                while (col >= 0 && matrix[row,col] == 0)
                {
                    matrix[row, col--] = counter++;
                }
                col++;
                row--;
                while (row > 0 && matrix[row,col] == 0)
                {
                    matrix[row--, col] = counter++;
                }
                row++;
                col++;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
