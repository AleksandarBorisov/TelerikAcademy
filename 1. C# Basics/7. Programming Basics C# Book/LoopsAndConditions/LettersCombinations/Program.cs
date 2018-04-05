using System;

namespace LettersCombinations
{
    class Program
    {
        static void Main()
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char lastLetter = char.Parse(Console.ReadLine());
            char skipLetter = char.Parse(Console.ReadLine());
            int count = 0;
            for (char i = firstLetter; i <= lastLetter; i++)
            {
                for (char j = firstLetter; j <= lastLetter; j++)
                {
                    for (char k = firstLetter; k <= lastLetter; k++)
                    {
                        if (i != skipLetter && j != skipLetter && k != skipLetter)
                        {
                            Console.Write("{0}{1}{2} ", i, j, k);
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);

        }
    }
}
