using System;

namespace BitsToBits
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            uint countZeroes = 0;
            uint maxZeroeCount = uint.MinValue;
            uint countOnes = 0;
            uint maxOneCount = uint.MinValue;
            //string allNumbers = "";
            //int mask = (1 << 30) - 1;
            //for (int i = 0; i < n; i++)
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    int numberAndMask = number & mask;
            //    allNumbers += Convert.ToString(numberAndMask,2).PadLeft(30, '0');
            //}
            //for (int i = 0; i < allNumbers.Length; i++)
            //{
            //    if (allNumbers[i]=='0')
            //    {
            //        countZeroes++;
            //        countOnes = 0;
            //        if (countZeroes>maxZeroeCount)
            //        {
            //            maxZeroeCount = countZeroes;
            //        }
            //    }
            //    else
            //    {
            //        countZeroes = 0;
            //        countOnes++;
            //        if (countOnes > maxOneCount)
            //        {
            //            maxOneCount=countOnes;
            //        }
            //    }
            //}
            //Console.WriteLine(maxZeroeCount);
            //Console.WriteLine(maxOneCount);
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                for (int j = 29; j >= 0; j--)
                {
                    int bit = ((1 << j) & number) >> j;
                    if (bit == 1)
                    {
                        countOnes++;
                        maxOneCount = Math.Max(maxOneCount, countOnes);
                        countZeroes = 0;
                    }
                    else
                    {
                        countZeroes++;
                        maxZeroeCount = Math.Max(maxZeroeCount, countZeroes);
                        countOnes = 0;
                    }
                }
            }
            Console.WriteLine(maxZeroeCount);
            Console.WriteLine(maxOneCount);
        }
    }
}
