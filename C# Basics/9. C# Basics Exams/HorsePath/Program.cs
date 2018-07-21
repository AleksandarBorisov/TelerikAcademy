using System;

namespace HorsePath
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            int[] xCoord = { -2, -2, -1, -1, +1, +1, +2, +2 };//За по-краткото решение
            int[] yCoord = { -1, +1, -2, +2, -2, +2, -1, +1 };//Това са координатите на всички възможни подскоци
            int[,] numbers = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int row = i;
                    int col = j;
                    while (numbers[row, col] == 0)
                    {
                        numbers[row, col] = counter;
                        counter++;
                        for (int k = 0; k < xCoord.Length; k++)
                        {
                            int newRow = row + xCoord[k];
                            int newCol = col + yCoord[k];
                            if (newRow >= 0 && newRow < n &&
                                newCol >= 0 && newCol < n &&
                                numbers[newRow, newCol] == 0)
                            {
                                row = newRow;
                                col = newCol;
                                break;//Много важен, иначе ще изгубим намерените ред и колона
                            }
                        }
                        //if (row - 2 >= 0 && col - 1 >= 0 && numbers[row - 2, col - 1] == 0)
                        //{
                        //    row = row - 2;
                        //    col = col - 1;
                        //}
                        //else if (row - 2 >= 0 && col + 1 < n && numbers[row - 2, col + 1] == 0)
                        //{
                        //    row = row - 2;
                        //    col = col + 1;
                        //}
                        //else if (row - 1 >= 0 && col - 2 >= 0 && numbers[row - 1, col - 2] == 0)
                        //{
                        //    row = row - 1;
                        //    col = col - 2;
                        //}
                        //else if (row - 1 >= 0 && col + 2 < n && numbers[row - 1, col + 2] == 0)
                        //{
                        //    row = row - 1;
                        //    col = col + 2;
                        //}
                        //else if (row + 1 < n && col - 2 >= 0 && numbers[row + 1, col - 2] == 0)
                        //{
                        //    row = row + 1;
                        //    col = col - 2;
                        //}
                        //else if (row + 1 < n && col + 2 < n && numbers[row + 1, col + 2] == 0)
                        //{
                        //    row = row + 1;
                        //    col = col + 2;
                        //}
                        //else if (row + 2 < n && col - 1 >= 0 && numbers[row + 2, col - 1] == 0)
                        //{
                        //    row = row + 2;
                        //    col = col - 1;
                        //}
                        //else if (row + 2 < n && col + 1 < n && numbers[row + 2, col + 1] == 0)
                        //{
                        //    row = row + 2;
                        //    col = col + 1;
                        //}
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
