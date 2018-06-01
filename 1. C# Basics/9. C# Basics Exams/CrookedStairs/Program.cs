using System;

namespace CrookedStairs
{
    class Program
    {
        static void Main()
        {
            int firstBrick = int.Parse(Console.ReadLine());
            int secondBrick = int.Parse(Console.ReadLine());
            int thirdBrick = int.Parse(Console.ReadLine());
            int layersCount = int.Parse(Console.ReadLine());
            Console.WriteLine(firstBrick);
            Console.WriteLine(secondBrick + " " + thirdBrick);
            for (int i = 3; i <= layersCount; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    int fourthBrick = firstBrick + secondBrick + thirdBrick;
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
