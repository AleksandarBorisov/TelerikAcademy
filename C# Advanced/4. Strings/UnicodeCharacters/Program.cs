using System;
using UnicodeCharacters;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main()
        {
            string text = "Hi!";
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write("\\u" + Convert.ToString(text[i], 16).PadLeft(4, '0'));
            }
            Console.WriteLine();
        }
    }
}
