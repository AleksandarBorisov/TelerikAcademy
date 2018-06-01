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
            int sumSpeed = 0;
            for (int i = 0; i < cars; i++)
            {
                int speed = int.Parse(Console.ReadLine());
                if (speed <= groupSpeed)
                {//Правим нова група
                    groupSpeed = speed;
                    sumSpeed = speed;
                    group = 1;
                }
                else
                {//Добавяме към съществуваща
                    group++;
                    sumSpeed += speed;
                }
                if (group > maxGroup || (group == maxGroup && sumSpeed > maxSumSpeed))
                {//Меродавна ни е най-дългата група или тази с най-голяма сумарна скорост
                    maxGroup = group;
                    maxSumSpeed = sumSpeed;
                }
            }
            Console.WriteLine(maxSumSpeed);
        }
    }
}
