using System;

namespace MergingAndSquashing
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string merged = "";
            string squashed = "";
            string number = Console.ReadLine();
            char firstNumberFirstDigit = number[0];
            char firstNumberSecondDigit = number[1];
            for (int i = 0; i < n - 1; i++)
            {
                number = Console.ReadLine();
                char secondNumberFirstDigit = number[0];
                char secondNumberSecondDigit = number[1];
                merged += firstNumberSecondDigit + "" + secondNumberFirstDigit + " ";
                int middleNumber = (firstNumberSecondDigit - '0' + secondNumberFirstDigit - '0') % 10;
                squashed += firstNumberFirstDigit + "" + middleNumber + "" + secondNumberSecondDigit + " ";
                firstNumberFirstDigit = secondNumberFirstDigit;
                firstNumberSecondDigit = secondNumberSecondDigit;
            }
            Console.WriteLine(merged.Trim(' '));
            Console.WriteLine(squashed.Trim(' '));
        }
    }
}
