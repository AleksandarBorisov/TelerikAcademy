using System;

namespace StringEncryption
{
    class Program
    {
        static void Main()
        {
            string Encryption = string.Empty;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                Encryption += Encrypt(letter);
            }
            Console.WriteLine(Encryption);
        }
        static string Encrypt(char letter)
        {
            int asciiCode = letter;
            int lastAsciiDigit = asciiCode % 10;
            int firstAsciiDigit = lastAsciiDigit;
            string firstEncryption = firstAsciiDigit.ToString() + lastAsciiDigit;
            while (asciiCode > 9)
            {//Проверяваме дали числото е поне с две цифри
                asciiCode = asciiCode / 10;//Махаме последната цифра
                firstAsciiDigit = asciiCode % 10;
                firstEncryption = firstAsciiDigit.ToString() + lastAsciiDigit;
            }
            string secondEncryption = (char)(letter + lastAsciiDigit) + firstEncryption;
            string thirdEncryption = secondEncryption + (char)(letter - firstAsciiDigit);
            return thirdEncryption;
        }
    }
}
