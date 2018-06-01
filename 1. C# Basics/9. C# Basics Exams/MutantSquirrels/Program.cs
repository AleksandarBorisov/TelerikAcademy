using System;

namespace MutantSquirrels
{
    class Program
    {
        static void Main()
        {
            int trees = int.Parse(Console.ReadLine());
            int branches = int.Parse(Console.ReadLine());
            int squirrels = int.Parse(Console.ReadLine());
            int tails = int.Parse(Console.ReadLine());
            double totalCount = trees * branches * squirrels * tails;
            if (totalCount % 2 == 0)
            {
                totalCount *= 376439;
            }
            else
            {
                totalCount /= 7;
            }
            Console.WriteLine("{0:F3}", totalCount);
        }
    }
}
