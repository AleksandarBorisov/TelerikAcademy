using System;

namespace ShipDamage
{
    class Program
    {
        static void Main()
        {
            int shipFirstCornerX = int.Parse(Console.ReadLine());
            int shipFirstCornerY = int.Parse(Console.ReadLine());
            int shipThirdCornerX = int.Parse(Console.ReadLine());
            int shipThirdCornerY = int.Parse(Console.ReadLine());
            //int shipSecondCornerX = shipFirstCornerX;
            //int shipSecondCornerY = shipThirdCornerY;
            //int shipForthCornerX = shipThirdCornerX;
            //int shipForthCornerY = shipFirstCornerY;
            int horizonOffset = int.Parse(Console.ReadLine());
            int firstCatapultX = int.Parse(Console.ReadLine());
            int firstCatapultY = int.Parse(Console.ReadLine());
            int secondCatapultX = int.Parse(Console.ReadLine());
            int secondCatapultY = int.Parse(Console.ReadLine());
            int thirdCatapultX = int.Parse(Console.ReadLine());
            int thirdCatapultY = int.Parse(Console.ReadLine());
            int firstHitY = firstCatapultY + 2 * (horizonOffset - firstCatapultY);
            int secondHitY = secondCatapultY + 2 * (horizonOffset - secondCatapultY);
            int thirdHitY = thirdCatapultY + 2 * (horizonOffset - thirdCatapultY);
            int totalDamage = 0;
            int top = Math.Max(shipFirstCornerY, shipThirdCornerY);
            int left = Math.Min(shipFirstCornerX, shipThirdCornerX);
            int right = Math.Max(shipFirstCornerX, shipThirdCornerX);
            int bottom = Math.Min(shipFirstCornerY, shipThirdCornerY);
            totalDamage += CalculateDamage(firstCatapultX, firstHitY, top, left, right, bottom);
            totalDamage += CalculateDamage(secondCatapultX, secondHitY, top, left, right, bottom);
            totalDamage += CalculateDamage(thirdCatapultX, thirdHitY, top, left, right, bottom);
            ////Дългото решение
            //if (firstCatapultX == shipFirstCornerX && firstHitY == shipFirstCornerY ||
            //    firstCatapultX == shipSecondCornerX && firstHitY == shipSecondCornerY ||
            //    firstCatapultX == shipThirdCornerX && firstHitY == shipThirdCornerY ||
            //    firstCatapultX == shipForthCornerX && firstHitY == shipForthCornerY)
            //{
            //    totalDamage += 25;
            //}
            //else if (firstCatapultX > Math.Min(shipFirstCornerX, shipThirdCornerX) && firstCatapultX < Math.Max(shipFirstCornerX, shipThirdCornerX) && firstHitY == shipFirstCornerY ||
            //    firstCatapultX > Math.Min(shipFirstCornerX, shipThirdCornerX) && firstCatapultX < Math.Max(shipFirstCornerX, shipThirdCornerX) && firstHitY == shipSecondCornerY ||
            //    firstCatapultX == shipFirstCornerX && firstHitY > Math.Min(shipFirstCornerY, shipThirdCornerY) && firstHitY < Math.Max(shipFirstCornerY, shipThirdCornerY) ||
            //    firstCatapultX == shipThirdCornerX && firstHitY > Math.Min(shipFirstCornerY, shipThirdCornerY) && firstHitY < Math.Max(shipFirstCornerY, shipThirdCornerY))
            //{
            //    totalDamage += 50;
            //}
            //else if (firstCatapultX < Math.Max(shipFirstCornerX, shipThirdCornerX) && firstCatapultX > Math.Min(shipFirstCornerX, shipThirdCornerX)
            //    && firstHitY > Math.Min(shipFirstCornerY, shipThirdCornerY) && firstHitY < Math.Max(shipFirstCornerY, shipThirdCornerY))
            //{
            //    totalDamage += 100;
            //}
            //if (secondCatapultX == shipFirstCornerX && secondHitY == shipFirstCornerY ||
            //    secondCatapultX == shipSecondCornerX && secondHitY == shipSecondCornerY ||
            //    secondCatapultX == shipThirdCornerX && secondHitY == shipThirdCornerY ||
            //    secondCatapultX == shipForthCornerX && secondHitY == shipForthCornerY)
            //{
            //    totalDamage += 25;
            //}
            //else if (secondCatapultX > Math.Min(shipFirstCornerX, shipThirdCornerX) && secondCatapultX < Math.Max(shipFirstCornerX, shipThirdCornerX) && secondHitY == shipFirstCornerY ||
            //         secondCatapultX > Math.Min(shipFirstCornerX, shipThirdCornerX) && secondCatapultX < Math.Max(shipFirstCornerX, shipThirdCornerX) && secondHitY == shipSecondCornerY ||
            //         secondCatapultX == shipFirstCornerX && secondHitY > Math.Min(shipFirstCornerY, shipThirdCornerY) && secondHitY < Math.Max(shipFirstCornerY, shipThirdCornerY) ||
            //         secondCatapultX == shipThirdCornerX && secondHitY > Math.Min(shipFirstCornerY, shipThirdCornerY) && secondHitY < Math.Max(shipFirstCornerY, shipThirdCornerY))
            //{
            //    totalDamage += 50;
            //}
            //else if (secondCatapultX < Math.Max(shipFirstCornerX, shipThirdCornerX) && secondCatapultX > Math.Min(shipFirstCornerX, shipThirdCornerX)
            //    && secondHitY > Math.Min(shipFirstCornerY, shipThirdCornerY) && secondHitY < Math.Max(shipFirstCornerY, shipThirdCornerY))
            //{
            //    totalDamage += 100;
            //}
            //if (thirdCatapultX == shipFirstCornerX && thirdHitY == shipFirstCornerY ||
            //   thirdCatapultX == shipSecondCornerX && thirdHitY == shipSecondCornerY ||
            //    thirdCatapultX == shipThirdCornerX && thirdHitY == shipThirdCornerY ||
            //    thirdCatapultX == shipForthCornerX && thirdHitY == shipForthCornerY)
            //{
            //    totalDamage += 25;
            //}
            //else if (thirdCatapultX > Math.Min(shipFirstCornerX, shipThirdCornerX) && thirdCatapultX < Math.Max(shipFirstCornerX, shipThirdCornerX) && thirdHitY == shipFirstCornerY ||
            //         thirdCatapultX > Math.Min(shipFirstCornerX, shipThirdCornerX) && thirdCatapultX < Math.Max(shipFirstCornerX, shipThirdCornerX) && thirdHitY == shipSecondCornerY ||
            //         thirdCatapultX == shipFirstCornerX && firstHitY > Math.Min(shipFirstCornerY, shipThirdCornerY) && thirdHitY < Math.Max(shipFirstCornerY, shipThirdCornerY) ||
            //         thirdCatapultX == shipThirdCornerX && firstHitY > Math.Min(shipFirstCornerY, shipThirdCornerY) && thirdHitY < Math.Max(shipFirstCornerY, shipThirdCornerY))
            //{
            //    totalDamage += 50;
            //}
            //else if (thirdCatapultX < Math.Max(shipFirstCornerX, shipThirdCornerX) && thirdCatapultX > Math.Min(shipFirstCornerX, shipThirdCornerX)
            //    && thirdHitY > Math.Min(shipFirstCornerY, shipThirdCornerY) && thirdHitY < Math.Max(shipFirstCornerY, shipThirdCornerY))
            //{
            //    totalDamage += 100;
            //}
            Console.WriteLine(totalDamage + "%");
        }

        static int CalculateDamage(int hitX, int hitY, int top, int left, int right, int bottom)
        {
            int damage = 0;
            if (bottom < hitY && hitY < top)
            {
                if (left < hitX && hitX < right)
                {
                    damage += 100;
                }
                else if (left == hitX || hitX == right)
                {
                    damage += 50;
                }
            }
            else if (hitY == bottom || hitY == top)
            {
                if (left < hitX && hitX < right)
                {
                    damage += 50;
                }
                else if (left == hitX || hitX == right)
                {
                    damage += 25;
                }
            }
            return damage;
        }
    }
}
