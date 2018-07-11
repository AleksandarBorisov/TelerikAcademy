using System;
using System.Numerics;

namespace BitShiftMatrix
{
    class Program
    {
        static void Main()
        {
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            BigInteger[,] array = new BigInteger[r, c];
            for (int i = r - 1; i >= 0; i--)
            {
                array[i, 0] = (BigInteger)Math.Pow(2, r - 1 - i);
                for (int j = 1; j < c; j++)
                {
                    array[i, j] = array[i, j - 1] * 2;
                }
            }
            bool[,] visited = new bool[r, c];
            int coeff = Math.Max(r, c);
            int row = r - 1;
            int col = 0;
            BigInteger sum = 0;
            string[] positions = Console.ReadLine().Split();
            for (int i = 0; i < positions.Length; i++)
            {
                int code = int.Parse(positions[i]);
                int newRow = code / coeff;
                int newCol = code % coeff;
                int stepRow = newRow < row ? -1 : +1;
                int stepCol = newCol < col ? -1 : +1;
                for (int l = col; l != newCol; l += stepCol)
                {
                    if (!visited[row, l])
                    {
                        sum += array[row, l];
                        visited[row, l] = true;
                    }
                }
                for (int k = row; k != newRow; k += stepRow)
                {
                    if (!visited[k, newCol])
                    {
                        sum += array[k, newCol];
                        visited[k, newCol] = true;
                    }
                }
                if (!visited[newRow, newCol])
                {
                    sum += array[newRow, newCol];
                    visited[newRow, newCol] = true;
                }
                col = newCol;
                row = newRow;
            }
            Console.WriteLine(sum);
        }
    }
}
