using System;

namespace SequenceOfBits
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            uint countOnes = 0;
            uint maxCountOnes = uint.MinValue;
            uint countZeroes = 0;
            uint maxCountZeroes = uint.MinValue;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                for (int j = 29; j >= 0; j--)
                {
                    int bit = ((1 << j) & number) >> j;
                    if (bit == 1)
                    {
                        countOnes++;
                        countZeroes = 0;
                        if (countOnes > maxCountOnes)
                        {
                            maxCountOnes = countOnes;
                        }
                    }
                    else
                    {
                        countZeroes++;
                        countOnes = 0;
                        if (countZeroes > maxCountZeroes)
                        {
                            maxCountZeroes = countZeroes;
                        }
                    }
                }
            }
            Console.WriteLine(maxCountOnes);
            Console.WriteLine(maxCountZeroes);
        }
    }
}
