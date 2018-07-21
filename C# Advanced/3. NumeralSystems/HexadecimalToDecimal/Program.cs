using System;

namespace HexadecimalToDecimal
{
    class Program
    {
        static void Main()
        {
            string hex = Console.ReadLine();
            long dec = 0;
            foreach (char symbol in hex)
            {
                long digitValue = 0;
                if (char.IsDigit(symbol))
                {
                    digitValue = (symbol - '0');
                }
                else
                {
                    digitValue = (symbol - 'A' + 10);
                }
                dec = dec * 16 + digitValue;
            }
            Console.WriteLine(dec);

            //Втори вариант
            //string digits = "0123456789ABCDEF";
            //foreach (char symbol in hex)
            //{
            //    dec = dec * 16 + digits.IndexOf(symbol);
            //}
            //Console.WriteLine(dec);
            //Main();
        }
    }
}
