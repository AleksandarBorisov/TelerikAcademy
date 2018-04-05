using System;

namespace MagicNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int d1 = 1; d1 <= 9; d1++)
            {
                for (int d2 = 1; d2 <= 9; d2++)
                {
                    for (int d3 = 1; d3 <= 9; d3++)
                    {
                        for (int d4 = 1; d4 <= 9; d4++)
                        {
                            for (int d5 = 1; d5 <= 9; d5++)
                            {
                                for (int d6 = 1; d6 <= 9; d6++)
                                {
                                    if (d1 * d2 * d3 * d4 * d5 * d6 == n)
                                    {
                                        Console.Write("{0}{1}{2}{3}{4}{5} ", d1, d2, d3, d4, d5, d6);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            //int d1 = 0;
            //int d2;
            //int d3;
            //int d4;
            //int d5;
            //int d6;
            //while (d1 <= 9)
            //{
            //    d2 = 0;
            //    while (d2 <= 9)
            //    {
            //        d3 = 0;
            //        while (d3 <= 9)
            //        {
            //            d4 = 0;
            //            while (d4 <= 9)
            //            {
            //                d5 = 0;
            //                while (d5 <= 9)
            //                {
            //                    d6 = 0;
            //                    while (d6 <= 9)
            //                    {
            //                        if (d1 * d2 * d3 * d4 * d5 * d6 == n)
            //                        {
            //                            Console.Write("{0}{1}{2}{3}{4}{5} ", d1, d2, d3, d4, d5, d6);
            //                        }
            //                        d6++;
            //                    }
            //                    d5++;
            //                }
            //                d4++;
            //            }
            //            d3++;
            //        }
            //        d2++;
            //    }
            //    d1++;
            //}
            //Console.WriteLine();
        }
    }
}
