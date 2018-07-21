using System;

namespace DrunkenNumbers
{
    class Program
    {
        static void Main()
        {
            int match = int.Parse(Console.ReadLine());
            int mitkoSoFar = 0;
            int vladkoSoFar = 0;
            for (int round = 0; round < match; round++)
            {
                int drunkenNumber = int.Parse(Console.ReadLine());
                int numberLength = (int)Math.Floor(Math.Log10(drunkenNumber) + 1);
                int mitkoRound = 0;
                int vladkoRound = 0;
                int digitPos = 0;
                while (drunkenNumber > 0)
                {
                    int digit = drunkenNumber % 10;
                    if ((numberLength % 2 != 0) && (digitPos == numberLength / 2))//Посредата сме на нечетно число
                    {
                        vladkoRound += digit;
                        mitkoRound += digit;
                    }
                    else if (digitPos < numberLength / 2)//В дясната половина сме, защото делим отдясно наляво
                    {
                        vladkoRound += digit;
                    }
                    else if (digitPos >= numberLength / 2)//В лявата половина сме
                    {
                        mitkoRound += digit;
                    }
                    drunkenNumber /= 10;
                    digitPos++;
                }
                mitkoSoFar += mitkoRound;
                vladkoSoFar += vladkoRound;
            }
            if (mitkoSoFar > vladkoSoFar)
            {
                Console.WriteLine("M {0}", mitkoSoFar - vladkoSoFar);
            }
            else if (vladkoSoFar > mitkoSoFar)
            {
                Console.WriteLine("V {0}", vladkoSoFar - mitkoSoFar);
            }
            else
            {
                Console.WriteLine("No {0}", mitkoSoFar + vladkoSoFar);
            }
        }
    }
}
