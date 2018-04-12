using System;
using System.Numerics;

namespace SecretsOfNumbers
{
    class Program
    {
        static void Main()
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            int specialSum = 0;
            int position = 1;
            BigInteger copyNumber = number;
            while (copyNumber > 0)
            {
                int digit = (int)(copyNumber % 10);
                if (position % 2 != 0)
                {
                    specialSum += digit * position * position;
                }
                else
                {
                    specialSum += digit * digit * position;
                }
                position++;
                copyNumber /= 10;
            }
            Console.WriteLine(specialSum);
            int lengthOfAlpha = specialSum % 10;
            if (lengthOfAlpha != 0)
            {
                for (int i = 0; i < lengthOfAlpha; i++)
                {
                    int remainder = specialSum % 26;
                    int symbolCode = (remainder + i) % 26 + 'A';//%26 е за да започнем отначало ако стигнем Z
                    char symbol = (char)symbolCode;
                    Console.Write(symbol);
                }
            }
            else
            {
                Console.Write("{0} has no alpha-sequence", number);

            }
            Console.WriteLine();

        }
    }
}
