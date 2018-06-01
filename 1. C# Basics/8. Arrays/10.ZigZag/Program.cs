using System;

namespace _10.ZigZag
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');
            int n = int.Parse(line[0]);
            int m = int.Parse(line[1]);
            long currentSumOfThree = 0;
            long pathSum = 0;
            for (int i = 0; i < n; i++)
            {
                currentSumOfThree = 1 + 3 * i;
                if (i % 2 == 0)
                {
                    pathSum += currentSumOfThree;
                }
                for (int j = 1; j < m; j++)
                {
                    currentSumOfThree += 3;
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        pathSum += currentSumOfThree;
                        if (i != 0 && j != 0 && i != n - 1 && j != m - 1)
                        {
                            pathSum += currentSumOfThree;
                        }
                    }
                    else if (i % 2 != 0 && j % 2 != 0)
                    {
                        pathSum += currentSumOfThree;
                        if (i != 0 && j != 0 && i != n - 1 && j != m - 1)
                        {
                            pathSum += currentSumOfThree;
                        }
                    }
                }
            }
            //int row = 0;//Този алгоритъм работи. но се достига лимита от памет
            //int col = 0;
            //while (row < n - 1)
            //{//Ако m е нечетно ще се получи безкраен loop, затова мисля че m винаги ще бъде четно
            //    bool plusOne = true;
            //    while (col < m - 1)
            //    {
            //        row += plusOne ? +1 : -1;
            //        plusOne = !plusOne;
            //        col++;
            //        pathSum += sumsOfThree[row, col];
            //    }
            //    plusOne = true;
            //    if (row + 1 < n)
            //    {
            //        while (col != 0)
            //        {
            //            row += plusOne ? +1 : -1;
            //            plusOne = !plusOne;
            //            col--;
            //            pathSum += sumsOfThree[row, col];
            //        }
            //    }
            //}
            Console.WriteLine(pathSum);
        }
    }
}
