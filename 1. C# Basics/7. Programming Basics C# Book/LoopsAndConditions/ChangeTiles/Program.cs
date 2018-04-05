using System;

namespace ChangeTiles
{
    class Program
    {
        static void Main()
        {
            decimal savedMoney = decimal.Parse(Console.ReadLine());
            decimal floorSideA = decimal.Parse(Console.ReadLine());
            decimal floorSideB = decimal.Parse(Console.ReadLine());
            decimal tileBase = decimal.Parse(Console.ReadLine());
            decimal tileHeight = decimal.Parse(Console.ReadLine());
            decimal tileCost = decimal.Parse(Console.ReadLine());
            decimal workerWage = decimal.Parse(Console.ReadLine());
            decimal floorArea = (decimal)(floorSideA * floorSideB);
            decimal tileArea = (decimal)(tileBase * tileHeight / 2);
            decimal tileCount = Math.Ceiling(floorArea / tileArea) + 5;
            decimal totalCost = (decimal)(tileCount * tileCost + workerWage);
            if (savedMoney-totalCost>=0)
            {
                Console.WriteLine("{0:F2} lv left.",savedMoney-totalCost);
            }
            else
            {
                Console.WriteLine("You'll need {0:F2} lv more.", totalCost-savedMoney);
            }

        }
    }
}
