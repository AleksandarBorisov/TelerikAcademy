using System;

namespace GuessTheDate
{
    class Program
    {
        static void Main()
        {
            int year = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            DateTime result = new DateTime(year, month, day);
            Console.WriteLine("{0:d-MMM-yyyy}", result.AddDays(-1));
        }
    }
}
