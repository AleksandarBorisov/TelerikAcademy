using System;
using System.Text;

namespace KaspichanNumbers
{
    class Program
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());
            string[] kaspichanNumbers = new string[256];
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < 256; i++)
            {
                int digit = i;
                kaspichanNumbers[i] = "" + (char)(digit % 26 + 'A');
                digit /= 26;
                if (digit > 0)
                {
                    kaspichanNumbers[i] = (char)(digit % 26 - 1 + 'a') + kaspichanNumbers[i];
                }
            }
            do
            {
                result.Insert(0, kaspichanNumbers[(int)(number % 256)]);
                number /= 256;
            }
            while (number > 0);
            Console.WriteLine(result);
        }
    }
}
