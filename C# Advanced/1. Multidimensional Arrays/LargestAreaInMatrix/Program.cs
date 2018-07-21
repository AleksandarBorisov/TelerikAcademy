using System;

namespace LargestAreaInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] matrix = {
            //    { 1, 3, 2, 2, 2, 4 },
            //    { 3, 3, 3, 2, 4, 4 },
            //    { 4, 3, 1, 2, 3, 3 },
            //    { 4, 3, 1, 3, 3, 1 },
            //    { 4, 3, 3, 3, 1, 1 }
            //};
            string[] matrixSize = Console.ReadLine().Split(' ');
            int rowCount = int.Parse(matrixSize[0]);
            int colCount = int.Parse(matrixSize[1]);
            int[,] matrix = new int[rowCount, colCount];
            for (int i = 0; i < rowCount; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int j = 0; j < colCount; j++)
                {
                    for (int k = 0; k < line[j].Length; k++)
                    {
                        matrix[i, j] = matrix[i, j] * 10 + (line[j][k] - '0');
                    }
                }
            }
            bool[,] nextElement = new bool[matrix.GetLength(0), matrix.GetLength(1)];//Пази ни дали вече сме обходили дадения елемент(клон)
            int[] coordinates = new int[2 * matrix.GetLength(0) * matrix.GetLength(1)];//Пази ни координатите на последното разклонение
            int maxCount = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (nextElement[row, col] == false)
                    {
                        int i = row;
                        int j = col;
                        int count = 1;//Преброяваме първия елемент
                        int indexCoordinate = -1;//Индекса на последните присвоени координати
                        coordinates[++indexCoordinate] = i;//Винаги започваме с координатите на началното число
                        coordinates[++indexCoordinate] = j;
                        while (indexCoordinate >= 0)//Върнали сме се на координатите на първия елемент и можем да излезнем от цикъла
                        {
                            if (i != 0 && matrix[i, j] == matrix[i - 1, j] && nextElement[i - 1, j] == false)//Елемента отгоре равен ли е на настоящия
                            {//Проверка дали не сме на първия ред и дали вече не сме обходили този елемент
                                coordinates[++indexCoordinate] = i;//Запазваме координатите на разклонението
                                coordinates[++indexCoordinate] = j;
                                nextElement[i, j] = true;//Маркираме го като обходено
                                count++;//Преброяваме следващия елемент
                                i--;//Отиваме с една позиция нагоре на следващия елемент
                            }
                            else if (j != matrix.GetLength(1) - 1 && matrix[i, j] == matrix[i, j + 1] && nextElement[i, j + 1] == false)//Елемента вдясно равен ли е на настоящия
                            {//Проверка дали не сме на последната колона и дали вече не сме обходили този елемент
                                coordinates[++indexCoordinate] = i;
                                coordinates[++indexCoordinate] = j;
                                nextElement[i, j] = true;
                                count++;
                                j++;//Отиваме с една позиция надясно
                            }
                            else if (j != 0 && matrix[i, j] == matrix[i, j - 1] && nextElement[i, j - 1] == false)//Елемента вляво равен ли е на настоящия
                            {//Проверка дали не сме на първата колона и дали вече не сме обходили този елемент
                                coordinates[++indexCoordinate] = i;
                                coordinates[++indexCoordinate] = j;
                                nextElement[i, j] = true;
                                count++;
                                j--;//Отиваме с една позиция наляво
                            }
                            else if (i != matrix.GetLength(0) - 1 && matrix[i, j] == matrix[i + 1, j] && nextElement[i + 1, j] == false)//Елемента отдолу равен ли е на настоящия
                            {//Проверка дали не сме на последния ред и дали вече не сме обходили този елемент
                                coordinates[++indexCoordinate] = i;
                                coordinates[++indexCoordinate] = j;
                                nextElement[i, j] = true;
                                count++;
                                i++;//Отиваме с една позиция надолу
                            }
                            else//Връщаме се на последното разклонение
                            {
                                nextElement[i, j] = true;//Маркираме настоящия елемент като обходен
                                j = coordinates[indexCoordinate--];//Взимаме координатите на последното разклонение
                                i = coordinates[indexCoordinate--];
                            }
                        }
                        if (count > maxCount)
                        {
                            maxCount = count;
                        }
                    }
                }
            }
            Console.WriteLine(maxCount);
        }
    }
}
