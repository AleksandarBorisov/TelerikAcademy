using System;

namespace FindSumInArray
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int currentSum = 0;
            int startIndex = 0;
            int endIndex = 0;
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int sum = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                currentSum += numbers[i];
                if (sum == currentSum)
                {
                    startIndex = counter;
                    endIndex = i;
                }
                if (i == n - 1)
                {
                    i = counter;
                    counter++;
                    currentSum = 0;
                }
            }
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write(numbers[i]);
                Console.Write(i == endIndex ? "\n" : ", ");
            }
            //string[] forPrinting = new string[n];//ако използваме масив от стрингове можем да си
            //for (int i = 0; i < n; i++)//избираме кои елементи от масива да джоинваме
            //{
            //    forPrinting[i] = numbers[i].ToString();
            //}
            //Console.WriteLine(String.Join(" ", forPrinting, startIndex, endIndex - startIndex + 1));
        }
    }
}
