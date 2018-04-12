using System;

namespace Speeds
{
    class Program
    {
        static void Main()
        {
            int cars = int.Parse(Console.ReadLine());
            int group = 1;
            int groupSpeed = int.MaxValue;
            int maxSumSpeed = 0;
            int maxGroup = 0;
            int maxSpeed = 0;
            for (int i = 0; i < cars; i++)
            {
                int speed = int.Parse(Console.ReadLine());
                if (speed <= groupSpeed)
                {
                    groupSpeed = speed;
                    group = 1;
                    maxSumSpeed = speed;
                }
                else
                {
                    group++;
                    maxSumSpeed += speed;
                }
                if (group > maxGroup || (group == maxGroup && maxSumSpeed > maxSpeed))
                {
                    maxGroup = group;
                    maxSpeed = maxSumSpeed;
                }
            }
            Console.WriteLine(maxSpeed);
        }
    }
}
