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
                int position = (29 - 5);
                while (position >= 0)//по условие трябва да сравняваме само до 29-ия бит
                {//преместване с 24 места, демек вземаме битовете на позиции 25,26,27,28,29
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
