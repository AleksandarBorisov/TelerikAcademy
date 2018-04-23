using System;

namespace HotelRoom
{
    class Program
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            decimal studio = 0;
            decimal apartment = 0;
            if (month == "May" || month == "October")
            {
                studio = 50m;
                if (nights > 14)
                {
                    studio -= 0.3m * studio;
                }
                else if (nights > 7)
                {
                    studio -= 0.05m * studio;
                }
                apartment = 65m;
            }
            if (month == "June" || month == "September")
            {
                studio = 75.20m;
                if (nights > 14)
                {
                    studio -= 0.2m * studio;
                }
                apartment = 68.70m;
            }
            else if (month == "July" || month == "August")
            {
                studio = 76m;
                apartment = 77m;
            }
            if (nights > 14)
            {
                apartment -= 0.1m * apartment;
            }
            string apartmentInfo = string.Format("Apartment: {0:F2} lv.", nights * apartment);
            string studioInfo = string.Format("Studio: {0:F2} lv.", nights * studio);
            Console.WriteLine(apartmentInfo);
            Console.WriteLine(studioInfo);
            //Main();
        }
    }
}
