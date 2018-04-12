using System;

namespace BirdsAndFeathers
{
    class Program
    {
        static void Main()
        {
            int birds = int.Parse(Console.ReadLine());
            int feathers = int.Parse(Console.ReadLine());
            double feathersPerBird = (double)feathers / birds;
            if (birds == 0)//Достатъчно е знаменателя да не е 0
            {
                feathersPerBird = 0;
            }
            else if (birds % 2 == 0)
            {
                feathersPerBird *= 123123123123;
            }
            else
            {
                feathersPerBird /= 317;
            }
            Console.WriteLine("{0:F4}", feathersPerBird);
        }
    }
}
