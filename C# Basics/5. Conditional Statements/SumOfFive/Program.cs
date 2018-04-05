using System;
using System.Linq;

namespace SumOfFive
{
    class Program
    {
        static void Main()
        {
            string consoleString = Console.ReadLine();
            string[] numbersLikeString = consoleString.Split(' ');
            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = int.Parse(numbersLikeString[i]);
            }
            if (numbers.Sum() == 0)
            {
                Console.WriteLine("0 + 0 + 0 + 0 + 0 = 0");
                return;
            }
            long sum = 0;
            string result = "";
            bool isZeroSubset = false;
            for (int combination = 1; combination < 32; combination++)
            {
                int bit = 0;
                for (int i = 0; i < 5; i++)
                {
                    bit = (combination >> i) & 1;
                    sum += numbers[i] * bit;
                    if (bit == 1)
                    {
                        result += (numbers[i] >= 0 ? " + " : " - ") + Math.Abs(numbers[i]);
                    }
                }
                result = result.Trim('+', ' ');
                result += " = " + sum;
                if (sum == 0)
                {
                    Console.WriteLine(result);
                    isZeroSubset = true;
                }
                result = "";
                sum = 0;
            }
            if (isZeroSubset == false)
            {
                Console.WriteLine("no zero subset");
            }
        }
    }
}
