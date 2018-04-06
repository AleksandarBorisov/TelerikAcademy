using System;

namespace SubsetKWithSumS
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int k = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            string subset = " ";
            int counter = 0;
            bool sumFound = false;
            int sum = 0;
            for (int combination = 0; combination < (int)Math.Pow(2, n); combination++)//може да го запишем 1<<n(2 на n-та)
            {//число в двоична чийто битове вземаме
                int bit = 0;
                sum = 0;
                counter = 0;
                subset = " ";
                for (int index = 0; index < n; index++)
                {//индекса едновременно брои позицията от която взимаме бит и е индекс на елемента от масива на тази позиция
                    bit = (combination >> index) & 1;
                    if (bit == 1)
                    {
                        sum += numbers[index];
                        subset = subset + " " + (numbers[index] >= 0 ? '+' : '-') + Math.Abs(numbers[index]);
                        counter++;
                    }

                }
                if (sum == s && counter == k)//със сигурност ще има поне един случай, в който точния брой единици K образуват
                {//сумата S, ако съществуват
                    sumFound = true;
                    break;
                }
            }
            if (sumFound)
            {
                Console.WriteLine(subset.Trim(' ') + " = " + sum);
            }
            else
            {
                Console.WriteLine("Sorry, there is no such sum.");
            }
        }
    }
}
