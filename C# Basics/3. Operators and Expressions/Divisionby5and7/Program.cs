using System;

namespace Divisionby5and7
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int remainderFive = number % 5;
            int remainderSeven = number % 7;
            Console.WriteLine(remainderFive == 0 && remainderSeven == 0 ? "true " + number : "false " + number);
        }
    }
}
