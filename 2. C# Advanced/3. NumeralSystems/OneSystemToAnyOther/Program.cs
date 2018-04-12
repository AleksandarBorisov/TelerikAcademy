using System;

namespace OneSystemToAnyOther
{
    class Program
    {
        static void Main()
        {
            ulong startBase = ulong.Parse(Console.ReadLine());
            string number = Console.ReadLine();
            ulong newBase = ulong.Parse(Console.ReadLine());
            ulong numberInDecimal = ConvertToDecimal(number, startBase);
            Console.WriteLine(ConvertToAny(numberInDecimal, newBase));
        }

        static ulong ConvertToDecimal(string number, ulong oldBase)
        {
            ulong numberInDecimal = 0;
            foreach (char symbol in number)
            {
                ulong digitValue;
                if (char.IsDigit(symbol))
                {
                    digitValue = (ulong)(symbol - '0');
                }
                else
                {
                    digitValue = (ulong)(symbol - 'A' + 10);
                }
                numberInDecimal = numberInDecimal * oldBase + digitValue;//Умножаваме по основата и прибавяме остатъците
            }
            return numberInDecimal;
        }

        static string ConvertToAny(ulong numberInDecimal, ulong newBase)
        {
            string newNumber = "";
            string digits = "0123456789ABCDEF";
            do
            {
                int digitValue = (int)(numberInDecimal % newBase);//Делим на основата и записваме остатъците като цифри
                numberInDecimal /= newBase;
                newNumber = digits[digitValue] + newNumber;
            } while (numberInDecimal != 0);
            return newNumber;
        }
    }
}
