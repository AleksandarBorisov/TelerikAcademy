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
            int currentAsciiDigit = asciiCode % 10;
            int lastAsciiDigit = currentAsciiDigit;
            string firstEncryption = string.Empty;
            asciiCode = asciiCode / 10;
            while (asciiCode != 0)
            {
                currentAsciiDigit = asciiCode % 10;
                firstEncryption = currentAsciiDigit.ToString() + lastAsciiDigit;
                asciiCode = asciiCode / 10;
            }
            string secondEncryption = (char)(letter + lastAsciiDigit) + firstEncryption;
            string thirdEncryption = secondEncryption + (char)(letter - currentAsciiDigit);
            return thirdEncryption;
        }
    }
}
