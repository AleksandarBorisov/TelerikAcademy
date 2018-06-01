using System;

namespace FindBits
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int mask = (1 << 5) - 1;
            int fiveBits = mask & number;
            //Console.WriteLine(Convert.ToString(~(fiveBits), 2));
            int occurrences = 0;
            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                int position = 24;
                while (position >= 0)//По условие трябва да сравняваме само до 28-ия бит, затова преместваме с 24 места
                {//(махаме позиции 0 + (1 - 23)), при което на първите места идват битовете от позиции 24,25,26,27,28
                    int bitsForChecking = (((mask << position) & currentNumber) >> position);
                    if (fiveBits == bitsForChecking)
                    {
                        occurrences++;
                    }
                    position--;
                }
            }
            Console.WriteLine(occurrences);
        }
    }
}
