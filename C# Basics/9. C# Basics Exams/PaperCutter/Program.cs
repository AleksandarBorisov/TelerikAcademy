﻿using System;

namespace PaperCutter
{
    class Program
    {
        static void Main()
        {
            int numbersOfSheets = int.Parse(Console.ReadLine());
            for (int i = 10; i >= 0; i--)
            {
                int bit = numbersOfSheets & (1 << i);
                if (bit == 0)
                {//Ако бита на разглежданата позиция е 0, значи този лист не се използва и можем да го отпечатаме
                    Console.WriteLine("A" + (10 - i));
                }
            }
            //Ако приемем лист с размер A10 за единица, то всеки следващ се получава като умножим А10 по 2, т. е. всички листи
            //са някакви степени на двойката. Знаем че бинарното представяне на такива числа е от 1 единица и много нули.
            //Следователно за да получим зададеното по условие число в бинарен вид трябва да съберем тези степени на двойката,
            //чиито единици съвпадат с неговите единици(например 9 = 1001 = 1000 + 0001 = 8 + 1), а останалите да отпечатаме.
        }
    }
}
