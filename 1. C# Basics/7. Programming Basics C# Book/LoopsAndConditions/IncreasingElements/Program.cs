using System;

namespace IncreasingElements
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int number = 0;
            int previousNumber = 0;
            int count = 0;
            int maxCount = 0;
            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (previousNumber < number)
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                }
                else
                {
                    count = 1;
                }
                previousNumber = number;
            }
            Console.WriteLine(maxCount);
        }
    }
}
