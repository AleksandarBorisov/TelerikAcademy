using System;
using System.Numerics;

namespace EncodingSum
{
    class Program
    {
        static void Main()
        {
            int m = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            BigInteger result = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '@')
                {
                    break;
                }
                else if ('0' <= text[i] && text[i] <= '9')
                {
                    result *= text[i] - '0';
                }
                else if (('a' <= text[i] && text[i] <= 'z'))
                {
                    result += text[i] - 'a';
                }
                else if (('A' <= text[i] && text[i] <= 'Z'))
                {
                    result += text[i] - 'A';
                }
                else
                {
                    result %= m;
                }
            }
            Console.WriteLine(result);
        }
    }
}
