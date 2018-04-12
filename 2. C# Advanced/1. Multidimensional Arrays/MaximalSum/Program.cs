using System;

namespace MaximalSumHomework
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int[,] matrix = new int[n, m];
            for (int row = 0; row < n; row++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = int.Parse(line[col]);
                }
            }

            int maxSum = int.MinValue;
            //int bestRow = 0;//Закоментирания вариант а за извеждане на цялата площадка,
            //int bestCol = 0;//а не само максималната сума
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        //bestRow = row;
                        //bestCol = col;
                    }
                }
            }
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write("{0} ", matrix[bestRow + i, bestCol + j]);
            //    }
            //    Console.WriteLine();
            //}
            Console.WriteLine(maxSum);
        }
    }
}
