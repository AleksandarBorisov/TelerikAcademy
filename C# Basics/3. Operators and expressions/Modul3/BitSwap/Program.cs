using System;

namespace BitSwap
{
    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int closeMask = 1 << k;
            closeMask = closeMask - 1 << p;
            long closeBitValue = n & closeMask;
            closeBitValue = closeBitValue >> p;
            int farMask = 1 << k;
            farMask = farMask - 1 << q;
            long farBitValue = n & farMask;
            farBitValue = farBitValue >> q;
            n = n & ~closeMask;
            n = n & ~farMask;
            closeBitValue = closeBitValue << q;
            n = n | (closeBitValue);
            farBitValue = farBitValue << p;
            n = n | (farBitValue);
            Console.WriteLine(n);
        }
    }
}
