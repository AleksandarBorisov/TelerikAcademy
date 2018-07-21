using System;

namespace _10.SimilarArrays
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] line = Console.ReadLine().Split(' ');
            bool[] firstArray = new bool[1001];
            int firstArrayCount = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(line[i]);
                if (firstArray[number] == false)
                {
                    firstArray[number] = true;
                    firstArrayCount++;
                }
            }
            int m = int.Parse(Console.ReadLine());
            line = Console.ReadLine().Split(' ');
            int commonElements = 0;
            for (int i = 0; i < m; i++)
            {
                if (firstArray[int.Parse(line[i])] == true)
                {
                    commonElements++;
                    firstArray[int.Parse(line[i])] = false;
                    firstArrayCount--;
                }
            }
            if (firstArrayCount == 0)
            {//Ако е вярно, значи всички елементи от първия масив се съдържат във втория
                Console.WriteLine(commonElements);
            }
            else
            {
                for (int i = 0; i < 1001; i++)
                {
                    if (firstArray[i] == true)
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
