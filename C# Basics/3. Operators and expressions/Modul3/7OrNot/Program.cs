using System;

namespace SevenOrNot
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            number = number / 100;
            number = number % 10;
            Console.WriteLine(number == 7 ? "true" : "false " + number);
        }
    }
}
