using System;

namespace Buses
{
    class Program
    {
        static void Main()
        {
            int buses = int.Parse(Console.ReadLine());
            int groups = 0;
            int groupLeader = int.MaxValue;
            for (int bus = 0; bus < buses; bus++)
            {
                int speed = int.Parse(Console.ReadLine());
                if (speed <= groupLeader)
                {
                    groups++;
                    groupLeader = speed;
                }
            }
            Console.WriteLine(groups);
        }
    }
}
