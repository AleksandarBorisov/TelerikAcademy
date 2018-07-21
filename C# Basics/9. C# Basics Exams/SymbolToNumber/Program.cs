using System;

namespace SymbolToNumber
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                double result = 0;
                if (text[i] == '@')
                {
                    break;
                }
                else if (('a' <= text[i] && text[i] <= 'z') || ('A' <= text[i] && text[i] <= 'Z'))
                {
                    result = text[i] * number + 1000;
                }
                else if ('0' <= text[i] && text[i] <= '9')
                {
                    result = text[i] + number + 500;
                }
                else
                {
                    result = text[i] - number;
                }
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0:F2}", result / 100);
                }
                else
                {
                    Console.WriteLine("{0}", result * 100);
                }
            }
        }
    }
}
