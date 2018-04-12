using System;

namespace ApplesOrOranges
{
    class Program
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int sumEven = 0;
            int sumOdd = 0;
            while (number > 0)
            {
                int digit = (int)(number % 10);
                if (digit % 2 == 0)
                {
                    sumEven += digit;
                }
                else
                {
                    sumOdd += digit;
                }
                number /= 10;
            }
            if (sumEven > sumOdd)
            {
                Console.WriteLine("apples " + sumEven);
            }
            else if (sumOdd > sumEven)
            {
                Console.WriteLine("oranges " + sumOdd);
            }
            else
            {
                Console.WriteLine("both " + sumEven);
            }
        }
    }
}
