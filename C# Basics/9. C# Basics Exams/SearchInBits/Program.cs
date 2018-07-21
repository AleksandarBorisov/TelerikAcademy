using System;

namespace SearchInBits
{
    class Program
    {
        static void Main()
        {
            int numberForSearching = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int occurrences = 0;
            int mask = (1 << 4) - 1;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                for (int bitPos = 26; bitPos >= 0; bitPos--)
                {
                    int bits = (number >> bitPos) & mask;
                    if (bits == numberForSearching)
                    {
                        occurrences++;
                    }
                }
            }
            Console.WriteLine(occurrences);

            //Само информативно решение
            //for (int i = 0; i < n; i++)
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    for (int pos = 0; pos <= 26; pos++)
            //    {
            //        //for (int j = pos; j <= pos+3; j++)
            //        bool match = true;
            //        for (int j = 0; j <= 3; j++)
            //        {
            //            int positionInNum = pos + j;
            //            int positionInNFS = j;

            //            int bitInNumber = ((1 << positionInNum) & number) >> positionInNum;
            //            int bitInNFS = ((1 << positionInNFS) & numberForSearching) >> positionInNFS;

            //            if (bitInNumber != bitInNFS)
            //            {
            //                match = false;
            //                break;
            //            }
            //        }
            //        if (match)
            //        {
            //            occurrences++;
            //        }
            //    }
            //}
            //Console.WriteLine(occurrences);
        }
    }
}
