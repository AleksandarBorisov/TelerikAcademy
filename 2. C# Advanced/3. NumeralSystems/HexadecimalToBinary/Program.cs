using System;

namespace HexadecimalToBinary
{
    class Program
    {
        static void Main()
        {
            string hex = Console.ReadLine();
            string binary = "";
            foreach (char symbol in hex)
            {
                int digitValue = 0;
                if (char.IsDigit(symbol))
                {
                    digitValue = symbol - '0';
                }
                else
                {
                    digitValue = symbol - 'A' + 10;
                }
                string currentBinary = "";
                do
                {
                    int remainder = digitValue % 2;//Десетината стойност на цифрата делим на 2 с остатък
                    digitValue /= 2;
                    currentBinary = remainder + currentBinary;
                } while (digitValue != 0);
                binary += currentBinary.ToString().PadLeft(4, '0');
            }
            Console.WriteLine(binary.TrimStart('0'));
            Main();
        }
    }
}
