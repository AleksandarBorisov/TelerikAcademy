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
            foreach (var digit in number)
            {
                reversed = digit + reversed;
            }
            return reversed;
        }
    }
}
