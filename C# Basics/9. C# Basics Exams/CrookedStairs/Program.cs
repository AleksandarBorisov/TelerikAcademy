using System;

namespace CrookedStairs
{
    class Program
    {
        static void Main()
        {
            long firstBrick = long.Parse(Console.ReadLine());
            long secondBrick = long.Parse(Console.ReadLine());
            long thirdBrick = long.Parse(Console.ReadLine());
            long layersCount = long.Parse(Console.ReadLine());
            Console.WriteLine(firstBrick);
            Console.WriteLine(secondBrick + " " + thirdBrick);
            for (int i = 3; i <= layersCount; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    long fourthBrick = firstBrick + secondBrick + thirdBrick;
                    firstBrick = secondBrick;
                    secondBrick = thirdBrick;
                    thirdBrick = fourthBrick;
                    Console.Write(thirdBrick + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
