using System;

namespace FromBookDecimalToRoman
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine().PadLeft(4,'0');
            string romanNumber = "";
            string[] digits = { "MMM","CDM", "XLC", "IVX" };//Римските цифри, които ще използваме в дадената десетична цифра
            for (int i = 0; i < digits.Length; i++)
            {
                string currentDigits = digits[i];
                char lowDigit = currentDigits[0];
                char midDigit = currentDigits[1];
                char highDigit = currentDigits[2];
                if (number[i] - '0' <= 3)//Логиката е идентична за всяка цифра от десетичното число, само римските цифри
                {//които се използват се сменят
                    romanNumber += new string(lowDigit, number[i] - '0');
                }
                else if (number[i] - '0' == 4)
                {
                    romanNumber = romanNumber + lowDigit + midDigit;
                }
                else if (number[i] - '0' <= 8)
                {
                    romanNumber += midDigit + new string(lowDigit, number[i] - '0' - 5);
                }
                else
                {
                    romanNumber = romanNumber + lowDigit + highDigit;
                }
            }
            Console.WriteLine(romanNumber);
            Main();
        }
    }
}
