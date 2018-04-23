using System;

namespace DecToHex
{
    class Program
    {
        static void Main()
        {
            //while (true)
            //{
            long n = long.Parse(Console.ReadLine());
            string hex = " ";
            long value = 0;
            for (long i = n; i > 0; i /= 16)
            {
                value = i % 16;
                switch (value)
                {
                    case 10: hex = 'A' + hex; break;
                    case 11: hex = 'B' + hex; break;
                    case 12: hex = 'C' + hex; break;
                    case 13: hex = 'D' + hex; break;
                    case 14: hex = 'E' + hex; break;
                    case 15: hex = 'F' + hex; break;
                    default: hex = value.ToString() + hex; break;
                }
            }
            hex = hex.Trim(' ');
            Console.WriteLine(hex);
            //    Console.WriteLine();
            //}
        }
    }
}
