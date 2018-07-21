using System;

namespace SpiralMatrix
{
    class Program
    {
        static void Main()
        {
            //while (true)
            //{
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int counter = 1;
            int row = 0;
            int col = 0;
            int endIndex = ((n % 2 == 0) ? (n / 2 - 1) : (n / 2));
            //Индекса се определя от броя вписани квадрати във външния
            //Открих зависимостта:  (n)1 2 3 4 5 6 7 8...
            //       (вписани квадрати)0 0 1 1 2 2 3 3...
            for (int index = 0; index <= endIndex; index++)
            {//Индекса служи за нагласяне на координатите на следващия елемент от матрицата
                while (col + index < n - index)
                {
                    matrix[row + index, col + index] = counter;
                    counter++;
                    col++;
                }
                col--;
                counter--;
                while (row + index < n - index)//Само фиксира колко пъти да се изпълни(може да се запипе и row < n - 2 * index)
                {
                    matrix[row + index, col + index] = counter;//Фиксира откъде да започне да се изпълнява
                    counter++;//(винаги по главния диагонал)
                    row++;
                }
                row--;
                counter--;
                while (col >= 0)
                {
                    matrix[row + index, col + index] = counter;
                    counter++;
                    col--;
                }
                col++;
                counter--;
                while (row > 0)
                {
                    matrix[row + index, col + index] = counter;
                    counter++;
                    row--;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" " + matrix[i, j]);
                }
                Console.WriteLine();
            }
            //Console.WriteLine();
            //}

        }
    }
}
