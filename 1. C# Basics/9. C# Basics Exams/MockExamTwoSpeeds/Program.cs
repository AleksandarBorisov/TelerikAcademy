using System;

namespace MockExamTwoSpeeds
{
    class Program
    {
        static void Main()
        {
            int cars = int.Parse(Console.ReadLine());
            int maxGroupSpeed = int.MaxValue;
            int groupSpeed = int.MaxValue;
            int sumOfSpeedsInGroup = 0;
            int maxGroup = 0;
            int group = 0;
            for (int car = 1; car <= cars; car++)
            {
                int speed = int.Parse(Console.ReadLine());
                if (speed <= groupSpeed)
                {
                    groupSpeed = speed;
                    sumOfSpeedsInGroup = speed;
                    group = 1;
                }
                else
                {
                    sumOfSpeedsInGroup += speed;
                    group++;
                }
                if (group > maxGroup || (group == maxGroup && sumOfSpeedsInGroup > maxGroupSpeed))
                {
                    maxGroup = group;
                    maxGroupSpeed = sumOfSpeedsInGroup;
                }
            }
            Console.WriteLine(maxGroupSpeed);
        }
    }
}
