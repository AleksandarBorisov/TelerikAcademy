using System;

namespace SequenceInMatrix
{
    class Program
    {
        static void Main()
        {//При тази задача нямаме случай, в който да имаме елемент с два равни на него съседни елемента
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            string[,] matrix = new string[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = line[j];
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
                    while (col != m - 1 && matrix[row, col + 1] == matrix[row, col])
                    {//Докато !не сме на последната колона! и елемента отдясно е равен на настоящия
                        sequence++;
                        col++;
                    }
                    while (row != n - 1 && col != m - 1 && matrix[row + 1, col + 1] == matrix[row, col])
                    {//Докато !не сме на последния ред и колона! и елемента по диагонал надолу е равен на настоящия
                        sequence++;
                        row++;
                        col++;
                    }
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
