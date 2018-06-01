using System;

namespace _13.Crossword
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            string[] dimensions = Console.ReadLine().Split(' ');
            int n = int.Parse(dimensions[0]);
            int m = int.Parse(dimensions[1]);
            string smallestWord = "|";//Този знам стои след всички букви (малки и големи) в ASCII таблицата
            string[] vertical = new string[m];
            for (int i = 0; i < n; i++)
            {
                string horizontal = "";//На всеки ред ще започваме хоризонталата от празен стринг
                string line = Console.ReadLine();//Прочитаме съответния ред
                for (int j = 0; j < m; j++)
                {//Обхождаме прочетения ред
                    if (line[j] != '#')
                    {//Ако е буква я записваме
                        horizontal += line[j];
                        vertical[j] += line[j];
                    }
                    else
                    {//Ако не е, ще изтрием натрупания стринг на съответната позиция, но преди това ще проверим лексикографската му подредба
                        if (string.CompareOrdinal(smallestWord, horizontal) >= 0 && horizontal.Length >= 2)
                        {
                            smallestWord = horizontal;
                        }
                        if (vertical[j] != null && string.CompareOrdinal(smallestWord, vertical[j]) >= 0 && vertical[j].Length >= 2)
                        {//Тъй като в началото масивът vertical  е празен трябва да се уверим, че на позицията има елемент преди да го проверим
                            smallestWord = vertical[j];
                        }
                        vertical[j] = "";
                        horizontal = "";
                    }
                    if ((j == m - 1) && (string.CompareOrdinal(smallestWord, horizontal) >= 0) && (horizontal.Length >= 2))
                    {
                        smallestWord = horizontal;
                    }//Ако сме стигнали края на реда или края на колоната трябва да проверим натрупаните до момента стрингове преди да излзезем от масива
                    if ((i == n - 1) && (string.CompareOrdinal(smallestWord, vertical[j]) >= 0) && (vertical[j].Length >= 2))
                    {
                        smallestWord = vertical[j];
                    }
                }
            }
            Console.WriteLine(smallestWord);
        }
    }
}
