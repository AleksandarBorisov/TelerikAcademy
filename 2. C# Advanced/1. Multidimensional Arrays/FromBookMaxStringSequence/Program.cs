using System;

namespace FromBookMaxStringSequence
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            string[,] strings = new string[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    strings[i, j] = Console.ReadLine();
                }
            }
            int sequence = 1;
            int maxSequence = 0;
            string longestString = " ";
            string bestString = " ";
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    sequence = 1;
                    int row = i;
                    int col = j;
                    while (((row != n - 1) && strings[row, col] == strings[row + 1, col]) ||
                        ((row != n - 1) && (col != m - 1) && strings[row, col] == strings[row + 1, col + 1]) ||
                        ((col != m - 1) && strings[row, col] == strings[row, col + 1]))
                    {//Трябва да разцепя while-a като в задачата Sequence in matrix
                        sequence++;
                        bestString = strings[row, col];
                        if (strings[row, col] == strings[row + 1, col])
                        {
                            row++;
                        }
                        else if (strings[row, col] == strings[row + 1, col + 1])
                        {
                            row++;
                            col++;
                        }
                        else if (strings[row, col] == strings[row, col + 1])
                        {
                            col++;
                        }
                        if (sequence > maxSequence)
                        {
                            maxSequence = sequence;
                            longestString = bestString;
                        }
                    }
                }
            }
            for (int i = 0; i < maxSequence; i++)
            {
                Console.Write(longestString + " ");

            }
            Console.WriteLine();

        }
    }
}
