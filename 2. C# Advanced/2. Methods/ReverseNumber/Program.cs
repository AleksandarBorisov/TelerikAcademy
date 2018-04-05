using System;

namespace ReverseNumber
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            Console.WriteLine(Reverse(number));
        }

        static string Reverse(string number)
        {
            string reversed = "";
            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversed += number[i];
            }
            return reversed;
        }
    }
}
