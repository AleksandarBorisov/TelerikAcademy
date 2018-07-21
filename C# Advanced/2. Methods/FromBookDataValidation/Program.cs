using System;

namespace FromBookDataValidation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What time is it?");
            Console.Write("Hours: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Minutes: ");
            int minutes = int.Parse(Console.ReadLine());
            bool isValidTime = ValidateHours(hours) && ValidateMinutes(minutes);
            if (isValidTime)
            {
                //DateTime time = new DateTime(2018, 03, 18, hours, minutes, 0);//Като вариант ако използваме тип DateTime
                Console.WriteLine("The time is {0}:{1} now.", hours, minutes);
            }
            else
            {
                Console.WriteLine("Incorect time!");
            }
        }
        static bool ValidateHours(int hours)
        {
            bool result = (hours >= 0) && (hours < 24);
            return result;
        }
        static bool ValidateMinutes(int minutes)
        {
            bool result = (minutes >= 0) && (minutes <= 59);
            return result;
        }

    }
}
