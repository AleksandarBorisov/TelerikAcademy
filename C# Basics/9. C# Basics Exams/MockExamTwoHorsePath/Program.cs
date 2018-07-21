using System;

namespace MockExamTwoHorsePath
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int counter = 1;
            int[] xCheck = { -2, -2, -1, -1, +1, +1, +2, +2 };
            int[] yCheck = { -1, +1, -2, +2, -2, +2, -1, +1 };
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int row = i;
                    int col = j;
                    while (matrix[row, col] == 0)
                    {
                        matrix[row, col] = counter;
                        counter++;
                        for (int k = 0; k < xCheck.Length; k++)
                        {
                            if (row + xCheck[k] >= 0 && row + xCheck[k] < n &&
                                col + yCheck[k] >= 0 && col + yCheck[k] < n &&
                                matrix[row + xCheck[k], col + yCheck[k]] == 0)
                            {
                                row += xCheck[k];
                                col += yCheck[k];
                                break;
                            }
                        }
                        //if ((row - 2 >= 0) && (col - 1 >= 0) && matrix[row - 2, col - 1] == 0)
                        //{
                        //    row -= 2;
                        //    col--;
                        //}
                        //else if ((row - 2 >= 0) && (col + 1 < n) && matrix[row - 2, col + 1] == 0)
                        //{
                        //    row -= 2;
                        //    col++;
                        //}
                        //else if ((row - 1 >= 0) && (col - 2 >= 0) && matrix[row - 1, col - 2] == 0)
                        //{
                        //    row--;
                        //    col -= 2;
                        //}
                        //else if ((row - 1 >= 0) && (col + 2 < n) && matrix[row - 1, col + 2] == 0)
                        //{
                        //    row--;
                        //    col += 2;
                        //}
                        //else if ((row + 1 < n) && (col - 2 >= 0) && matrix[row + 1, col - 2] == 0)
                        //{
                        //    row++;
                        //    col -= 2;
                        //}
                        //else if ((row + 1 < n) && (col + 2 < n) && matrix[row + 1, col + 2] == 0)
                        //{
                        //    row++;
                        //    col += 2;
                        //}
                        //else if ((row + 2 < n) && (col - 1 >= 0) && matrix[row + 2, col - 1] == 0)
                        //{
                        //    row += 2;
                        //    col--;
                        //}
                        //else if ((row + 2 < n) && (col + 1 < n) && matrix[row + 2, col + 1] == 0)
                        //{
                        //    row += 2;
                        //    col++;
                        //}
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
