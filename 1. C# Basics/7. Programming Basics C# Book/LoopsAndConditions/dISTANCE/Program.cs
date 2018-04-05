using System;

namespace Distance
{
    class Program
    {
        static void Main()
        {   
            decimal velocity = decimal.Parse(Console.ReadLine());
            decimal timeOne = decimal.Parse(Console.ReadLine());
            decimal timeTwo = decimal.Parse(Console.ReadLine());
            decimal timeThree = decimal.Parse(Console.ReadLine());
            decimal distanceTraveled = 0;
            decimal minutesPerHour = 60;
            distanceTraveled = velocity * (timeOne / minutesPerHour);
            velocity *= (decimal)1.1;
            distanceTraveled += velocity * (timeTwo / minutesPerHour);
            velocity *= (decimal)0.95;
            distanceTraveled += velocity * (timeThree / minutesPerHour);
            Console.WriteLine("{0:F2}",distanceTraveled);
        }
    }
}
