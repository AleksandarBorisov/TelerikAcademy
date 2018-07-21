using System;

namespace DateDifference
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the first date: ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter the second date: ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Distance: {(secondDate - firstDate).Days} days");
        }
    }
}
