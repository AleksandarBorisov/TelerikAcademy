using System;

namespace FrequentNumber
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int mvp = 0;
            int count = 1;
            int counter = 0;//Индекса на елемента, с който ще сравним всички останали
            int maxCount = 1;
            for (int index = 0; index < n; index++)
            {
                numbers[index] = int.Parse(Console.ReadLine());
            }
            for (int index = 1; index < n; index++)
            {
                if (numbers[index] == numbers[counter])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        mvp = numbers[counter];
                    }
                }
                if (index == n - 1)
                {
                    counter++;
                    index = counter;
                    count = 1;
                }
            }
            Console.WriteLine("{0} ({1} times)", mvp, maxCount);
        }
    }
}
