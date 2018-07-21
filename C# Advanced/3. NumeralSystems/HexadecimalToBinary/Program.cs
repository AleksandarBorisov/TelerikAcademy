using System;

namespace HexadecimalToBinary
{
    class Program
    {
        static void Main()
        {
            string[] binDigits =
                { "0000","0001", "0010", "0011", "0100", "0101",
                "0110","0111", "1000", "1001", "1010",
                "1011", "1100","1101","1110","1111", };
            string input = Console.ReadLine();
            string[] result = new string[input.Length];//Писането в масив от стрингове се оказа доста по-бързо от писането
            int index = 0;//на един стринг, важно е запомни го!
            while (index < input.Length)
            {
                switch (input[index])
                {
                    case 'A': result[index] = binDigits[10]; ; break;
                    case 'B': result[index] = binDigits[11]; ; break;
                    case 'C': result[index] = binDigits[12]; ; break;
                    case 'D': result[index] = binDigits[13]; ; break;
                    case 'E': result[index] = binDigits[14]; ; break;
                    case 'F': result[index] = binDigits[15]; ; break;
                    default: result[index] = binDigits[input[index] - '0']; ; break;
                }
                index++;
            }
            Console.WriteLine(string.Join("", result).TrimStart('0'));
            //Main();
        }
    }
}
