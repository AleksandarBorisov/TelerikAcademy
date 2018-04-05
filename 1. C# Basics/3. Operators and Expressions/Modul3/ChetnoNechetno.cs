using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Моля въведете число: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Двоичното му представяе е: {0}", Convert.ToString(n, 2));
            Console.Write("Моля въведете позиция за начало на първия интервал: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Моля въведете позиция за начало на втория интервал: ");
            int q = int.Parse(Console.ReadLine());
            Console.Write("Моля въведете брой позиции за размяна: ");
            int k = int.Parse(Console.ReadLine());
            int closeMask = 1 << k;
            closeMask = closeMask - 1 << (p - 1) ;
            int closeBitValue = n & closeMask;
            closeBitValue = closeBitValue>> (p - 1);
            int farMask = 1 << k;
            farMask = farMask - 1 << (q - 1);
            int farBitValue = n & farMask;
            farBitValue = farBitValue >> (q - 1);
            n = n & ~closeMask;
            n = n & ~farMask;
            closeBitValue = closeBitValue << (q - 1);
            n = n | (closeBitValue);
            farBitValue = farBitValue << (p - 1);
            n = n | (closeBitValue);
            Console.WriteLine("Новото число е: " + n);
            Console.WriteLine("Двоичното му представяе е: {0}", Convert.ToString(n, 2));
        }
    }
}
