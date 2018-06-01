using System;

namespace _9.Bounce
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');
            int n = int.Parse(line[0]);
            int m = int.Parse(line[1]);
            long[,] powerOfTwo = new long[n, m];
            //Попълваме матрицата със степени на числото 2
            for (int i = 0; i < n; i++)
            {
                powerOfTwo[i, 0] = (long)Math.Pow(2, i);
                for (int j = 1; j < m; j++)
                {
                    powerOfTwo[i, j] = 2 * powerOfTwo[i, j - 1];
                }
            }
            //Bounce-ваме
            long pathSum = 0;
            int row = 0;
            int col = 0;
            bool rowIncrease = true;
            bool colIncrease = true;
            while (true)
            {
                pathSum += powerOfTwo[row, col];
                if (row == n - 1 && col == m - 1 ||
                    row == 0 && col == m - 1 ||
                    col == 0 && row == n - 1)
                {
                    break;//Проверяваме дали не сме в някой от ъглите
                }//Изчисляваме координатите на следващото събираемо
                if (rowIncrease)
                {//row < n - 1
                    row++;
                    if (row == n - 1)
                    {
                        rowIncrease = false;//Ако row стане равно на n - 1 затваряме брояча
                    }
                }
                else
                {
                    row--;
                    if (row == 0)
                    {
                        rowIncrease = true;//Ако row стане равно на 0 отваряме брояча
                    }
                }
                if (colIncrease)
                {//col < m - 1
                    col++;
                    if (col == m - 1)
                    {
                        colIncrease = false;
                    }
                }
                else
                {
                    col--;
                    if (col == 0)
                    {
                        colIncrease = true;
                    }
                }
            }
            Console.WriteLine(pathSum);
            //for (int i = 0; i < n; i++)
            //{//Само за визуализиране на матрицата
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write(powerOfTwo[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
