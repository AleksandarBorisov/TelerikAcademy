using System;

namespace ConsoleApp2
{
    class HelloCSharp
    {
        static void Main()
        {
            DateTime birthDay;
            while (!DateTime.TryParse(Console.ReadLine(), out birthDay))
            {
                Console.WriteLine("Моля въведете коректна дата: ");
            }
            int difference = (birthDay.DayOfYear > DateTime.Now.DayOfYear) ? (-birthDay.Year - 1) : (-birthDay.Year);
            DateTime age = DateTime.Now.AddYears(difference);
            Console.WriteLine(age.Year);
            Console.WriteLine(age.AddYears(10).Year);
        }
    }
}
