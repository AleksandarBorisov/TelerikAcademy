using System;
using System.Collections.Generic;

namespace FrequentNumber
{
    class Program
    {
        static void Main()
        {
            //Първи вариант
            //short n = short.Parse(Console.ReadLine());
            //short[] numbers = new short[n];
            //short mvp = 0;
            //short count = 1;
            //short counter = 0;//Индекса на елемента, с който ще сравним всички останали
            //short maxCount = 1;
            //for (short index = 0; index < n; index++)
            //{
            //    numbers[index] = short.Parse(Console.ReadLine());
            //}
            //for (int index = 1; index < n; index++)
            //{
            //    if (numbers[index] == numbers[counter])
            //    {
            //        count++;
            //        if (count > maxCount)
            //        {
            //            maxCount = count;
            //            mvp = numbers[counter];
            //        }
            //    }
            //    if (index == n - 1)
            //    {
            //        counter++;
            //        index = counter;
            //        count = 1;
            //    }
            //}
            //Console.WriteLine("{0} ({1} times)", mvp, maxCount);

            //Втори вариант(Най-бърз)
            short n = short.Parse(Console.ReadLine());
            short[] numbers = new short[10001];
            for (int i = 0; i < n; i++)
            {
                numbers[short.Parse(Console.ReadLine())]++;
            }
            short maxCount = numbers[0];
            foreach (short number in numbers)
            {
                if (number > maxCount)
                {
                    maxCount = number;
                }
            }
            Console.WriteLine("{0} ({1} times)", Array.IndexOf(numbers, maxCount), maxCount);

            //Трети вариант
            //short n = short.Parse(Console.ReadLine());
            //short[] numbers = new short[10001];
            //short maxCount = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    short number = ++numbers[short.Parse(Console.ReadLine())];
            //    maxCount = number > maxCount ? number : maxCount;
            //}
            //Console.WriteLine($"{Array.IndexOf(numbers, maxCount)} ({maxCount} times)");

            //Трети вариант с речници
            //int n = int.Parse(Console.ReadLine());
            //Dictionary<int, int> mostFrequent = new Dictionary<int, int>(n);
            //int maxCount = 0;
            //int index = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    if (mostFrequent.ContainsKey(number))
            //    {
            //        mostFrequent[number]++;
            //        if (mostFrequent[number] > maxCount)
            //        {
            //            maxCount = mostFrequent[number];
            //            index = number;
            //        }
            //    }
            //    else
            //    {
            //        mostFrequent.Add(number, 1);
            //    }
            //}
            //Console.WriteLine("{0} ({1} times)", index, maxCount);
        }
    }
}
