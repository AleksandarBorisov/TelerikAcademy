using System;

namespace HexadecimalToDecimal
{
    class Program
    {
        static void Main()
        {
            string hex = Console.ReadLine();
            ulong dec = 0;
            foreach (char symbol in hex)
            {
                ulong digitValue = 0;
                if (char.IsDigit(symbol))
                {
                    digitValue = (ulong)(symbol - '0');
                }
                else
                {
                    digitValue = (ulong)(symbol - 'A' + 10);
                }
                dec = dec * 16 + digitValue;
            }
            Console.WriteLine(dec);
            Main();
        }
    }
}
