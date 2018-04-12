using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main()
        {
            ulong n = ulong.Parse(Console.ReadLine());
            string binary = "";
            do
            {
                int digit = (int) (n % 2);
                binary = digit + binary;
                n /= 2;
            } while (n!= 0);
            Console.WriteLine(binary);
            Main();
        }
    }
}
