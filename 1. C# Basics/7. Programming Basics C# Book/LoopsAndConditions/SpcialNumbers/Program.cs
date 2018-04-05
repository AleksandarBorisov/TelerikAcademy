using System;

namespace SpcialNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            if (n % i == 0 && n % j == 0 && n % k == 0 && n % l == 0)
                            {
                                Console.Write("{0}{1}{2}{3} ", i, j, k, l);
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            //int i = 1;
            //while (i <= 9)
            //{
            //    int j = 1;
            //    while (j <= 9)
            //    {
            //        int k = 1;
            //        while (k <= 9)
            //        {
            //            int l = 1;
            //            while (l <= 9)
            //            {
            //                if (n % i == 0 && n % j == 0 && n % k == 0 && n % l == 0)
            //                {
            //                    Console.Write("{0}{1}{2}{3} ", i, j, k, l);
            //                }
            //                l++;
            //            }
            //            k++;
            //        }
            //        j++;
            //    }
            //    i++;
            //}
            //Console.WriteLine();
        }
    }
}
