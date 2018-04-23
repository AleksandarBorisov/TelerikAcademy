using System;

namespace StopNumber
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            //for (int i = m; i >= n; i--)
            //{
            //    if (i % 2 == 0 && i % 3 == 0)
            //    {
            //        if (i == s)
            //        {
            //            break;
            //        }
            //        Console.Write(i + " ");
            //    }

            //}
            int i = m;
            while (i >= n)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    if (i == s)
                    {
                        break;
                    }
                    Console.Write(i + " ");
                }
                i--;
            }
            Console.WriteLine();
        }
    }
}
