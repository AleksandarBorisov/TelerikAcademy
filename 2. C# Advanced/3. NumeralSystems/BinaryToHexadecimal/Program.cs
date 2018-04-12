﻿using System;

namespace BinaryToHexadecimal
{
    class Program
    {
        static void Main()
        {
            string binary = Console.ReadLine();
            string hex = "";
            int supposedLength = (int)Math.Ceiling(binary.Length / 4.0);//Всички числа, които ще преобразуваме трябва да са с по 4 символа
            binary = binary.PadLeft(4 * supposedLength, '0');//Допълнили сме двоичното число до кратна на 4 дължина
            for (int i = 0; i < binary.Length; i += 4)
            {
                string currentNumber = binary.Substring(i, 4);//Взимаме числата отляво надясно
                string hexDigits = "0123456789ABCDEF";
                int digitValue = 0;
                foreach (char digit in currentNumber)
                {
                    digitValue = digitValue * 2 + (digit - '0');
                }
                hex += hexDigits[digitValue];
            }
            Console.WriteLine(hex);
        }
    }
}
