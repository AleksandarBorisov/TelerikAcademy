using System;

namespace IntegerToBase
{
    class Program
    {
        static void Main()
        {
            int numberInDex = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());
            string convertedNumber = IntegerToBase(numberInDex, toBase);
            Console.WriteLine(convertedNumber);
        }
        static string IntegerToBase(int numberInDec, int toBase)
        {
            string convertedNumber = "";
            while (numberInDec != 0)
            {
                int remainder = numberInDec % toBase;
                convertedNumber = remainder + convertedNumber;
                numberInDec /= toBase;
            }
            return convertedNumber;
        }
    }
}
