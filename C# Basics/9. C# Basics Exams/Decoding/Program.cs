using System;

namespace Decoding
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            //string text = Console.ReadLine();
            //for (int i = 0; i < text.Length; i++)
            //{
            //    double result = 0;
            //    if (text[i] == '@')
            //    {
            //        break;
            //    }
            //    else if ('a' <= text[i] && text[i] <= 'z')
            //    {
            //        result = text[i] * number + 1000;
            //    }
            //    else if ('A' <= text[i] && text[i] <= 'Z')
            //    {
            //        result = text[i] * number  + 1000;
            //    }
            //    else if ('0' <= text[i] && text[i] <= '9')
            //    {
            //        result = text[i] + number + 500;
            //    }
            //    else
            //    {
            //        result = text[i] - number;
            //    }
            //    if (i % 2 == 0)
            //    {
            //        result /= 100;
            //        Console.WriteLine("{0:F2}", result);
            //    }
            //    else
            //    {
            //        result *= 100;
            //        Console.WriteLine("{0}", result);
            //    }
            //}
            int position = 0;
            while (true)
            {
                int charCode = Console.Read();
                char ch = (char)charCode;
                int result = 0;
                if (ch == '@')
                {
                    break;
                }
                else if ('a' <= ch && ch <= 'z')//char.IsLetter(ch)
                {
                    result = charCode * number + 1000;//тук може да използваме и ch
                }
                else if ('A' <= ch && ch <= 'Z')
                {
                    result = charCode * number + 1000;
                }
                else if ('0' <= ch && ch <= '9')
                {
                    result = charCode + number + 500;
                }
                else
                {
                    result = charCode - number;
                }
                if (position % 2 == 0)
                {
                    Console.WriteLine("{0:F2}", result / 100.0);
                }
                else
                {
                    Console.WriteLine("{0}", result * 100);
                }
                position++;
            }
        }
    }
}
