using System;

namespace _1.Print
{
    class Program
    {
        static void Print(string text, int repeat)
        {
            for (int i = 0; i < repeat; i++)
            {
                Console.WriteLine(text);
            }
        }

        static void Main()
        {
            Print("Hello", 10);
            Print("Te tva e bace", 5);
        }
    }
}
