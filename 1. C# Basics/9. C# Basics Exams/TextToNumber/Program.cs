using System;

namespace TextToNumber
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            int position = 0;
            long result = 0;
            while (position < text.Length)
            {
                if (text[position] == '@')
                {
                    Console.WriteLine(result);
                    break;
                }
                else if ('0' <= text[position] && text[position] <= '9')
                {
                    result *= text[position] - '0';
                }
                else if ('a' <= text[position] && text[position] <= 'z')
                {
                    result += text[position] - 'a';
                }
                else if ('A' <= text[position] && text[position] <= 'Z')
                {
                    result += text[position] - 'A';
                }
                else
                {
                    result %= number;
                }
                position++;
            }
        }
    }
}
