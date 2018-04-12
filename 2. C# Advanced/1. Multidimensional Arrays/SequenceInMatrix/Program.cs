using System;

namespace SequenceInMatrix
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(line[j]);
                }
            }

            int maxSequence = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int sequence = 1;
                    int row = i;
                    int col = j;
                    while (row != n - 1 && matrix[row + 1, col] == matrix[row, col])
                    {//Докато !не сме на последния ред! и елемента отдолу е равен на настоящия
                        sequence++;
                        row++;
                    }
                    maxSequence = Math.Max(sequence, maxSequence);
                    sequence = 1;
                    row = i;
                    col = j;
                    while (col != m - 1 && matrix[row, col + 1] == matrix[row, col])
                    {//Докато !не сме на последната колона! и елемента отдясно е равен на настоящия
                        sequence++;
                        col++;
                    }
                    maxSequence = Math.Max(sequence, maxSequence);
                    sequence = 1;
                    row = i;
                    col = j;
                    while (row != n - 1 && col != m - 1 && matrix[row + 1, col + 1] == matrix[row, col])
                    {//Докато !не сме на последния ред и колона! и елемента по диагонал надолу е равен на настоящия
                        sequence++;
                        row++;
                        col++;
                    }
                    maxSequence = Math.Max(sequence, maxSequence);
                    sequence = 1;
                    row = i;
                    col = j;
                    while (row != 0 && col != m - 1 && matrix[row - 1, col + 1] == matrix[row, col])
                    {//Докато !не сме на първия ред и последната колона! и елемента по диагонал нагоре е равен на настоящия
                        sequence++;
                        row--;
                        col++;
                    }
                    maxSequence = Math.Max(sequence, maxSequence);
                }
            }
            Console.WriteLine(maxSequence);
        }
    }
}
