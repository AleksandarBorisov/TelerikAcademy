using System;
using System.Text;

namespace ReverseNumber
{
    class Program
    {
        private static object stringBuilder;

        static void Main()
        {
            string number = Console.ReadLine();
            Console.WriteLine(Reverse(number));
        }

        static string Reverse(string number)
        {
            StringBuilder sb = new StringBuilder();
            //string reversed = "";
            //foreach (var digit in number)
            //{
            //    reversed = digit + reversed;
            //}
            //return reversed;
            for (int i = number.Length - 1 ; i >= 0; i--)
            {
                sb.Append(number[i]);
            }
            return sb.ToString();
        }
    }
}
