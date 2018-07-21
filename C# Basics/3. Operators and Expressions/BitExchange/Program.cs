using System;

namespace BitExchange
{
    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString(n,2));
            long closeMask = 1 << 3;
            closeMask = closeMask - 1 << 3;
            long closeBitValue = n & closeMask;
            closeBitValue = closeBitValue >> 3;
            long farMask = 1 << 3;
            farMask = farMask - 1 << 24;
            long farBitValue = n & farMask;
            farBitValue = farBitValue >> 24;
            n = n & ~closeMask;
            n = n & ~farMask;
            closeBitValue = closeBitValue << 24;
            n = n | (closeBitValue);
            farBitValue = farBitValue << 3;
            n = n | (farBitValue);
            Console.WriteLine(n);
            //Console.WriteLine(Convert.ToString(n, 2));
        }
    }
}
