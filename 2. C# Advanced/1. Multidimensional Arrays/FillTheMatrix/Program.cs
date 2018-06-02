using System;

namespace FillTheMatrix
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char command = char.Parse(Console.ReadLine());
            int[,] array = new int[n, n];
            int counter = 1;
            int row = 0;
            int col = 0;
            if (command == 'c')
            {
                row = n;
            }
            while (counter <= n * n)
            {
                if (command == 'a')
                {
                    if (row == n)
                    {
                        row = 0;
                        col++;
                    }
                    array[row++, col] = counter;
                    counter++;
                }
                else if (command == 'b')
                {
                    if (col % 2 == 0)
                    {
                        array[row++, col] = counter;
                    }
                    else
                    {
                        array[--row, col] = counter;
                    }
                    if (row == n || row == 0)
                    {
                        col++;
                    }
                    counter++;
                }
                else if (command == 'c')
                {
                    if (row > 0)
                    {
                        row--;
                    }
                    else
                    {
                        col++;
                    }
                    int loopRow = row;
                    int loopCol = col;
                    while (loopRow < n && loopCol < n)
                    {
                        array[loopRow++, loopCol++] = counter;
                        counter++;
                    }
                }
                else if (command == 'd')
                {
                    while (row < n && array[row, col] == 0)//Първа вертикала надолу
                    {
                        array[row++, col] = counter;//Слизаме надолу
                        counter++;
                    }
                    row--;//За да се върнем в масива
                    col++;//За да хванем следващия елемент, а не да повтаряме на същата позиция
                    while (col < n && array[row, col] == 0)//Първа хоризонтала надясно
                    {
                        array[row, col++] = counter;//Вървим надясно
                        counter++;
                    }
                    col--;//За да се върнем в масива
                    row--;//За да хванем следващия елемент, а не да повтаряме на същата позиция
                    while (row >= 0 && array[row, col] == 0)//Втора вертикала нагоре
                    {
                        array[row--, col] = counter;//Качваме се нагоре
                        counter++;
                    }
                    row++;//За да се върнем в масива
                    col--;//За да хванем следващия елемент, а не да повтаряме на същата позиция
                    while (col > 0 && array[row, col] == 0)//Втора хоризонтала наляво
                    {
                        array[row, col--] = counter;//Вървим наляво
                        counter++;
                    }
                    col++;//За да се върнем в колоната, която ни трябва
                    row++;//За да отидем на реда, който ни трябва
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j != n - 1)
                    {
                        Console.Write("{0} ", array[i, j]);
                    }
                    else
                    {
                        Console.WriteLine("{0}", array[i, j]);
                    }
                }
            }
        }
    }
}
