using System;

namespace Flowers
{
    class Program
    {
        static void Main()
        {
            //Price list
            decimal chrysanthemumWarm = 2.00m;
            decimal chrysanthemumCold = 3.75m;
            decimal roseWarm = 4.10m;
            decimal roseCold = 4.50m;
            decimal tulipWarm = 2.50m;
            decimal tulipCold = 4.15m;
            decimal arrangePrice = 2m;
            //Price increases
            int priceIncreasePercentage = 15;
            //Price decreases
            int tulipPriceDecreasePercentage = 5;
            int rosePriceDecreasePercentage = 10;
            int totalPriceDecreasePercentage = 20;
            //Price decrease Tresholds
            int tulipPriceDecreaseTreshold = 7;
            int rosePriceDecreaseTreshold = 10;
            int totalPriceDecreaseTreshold = 20;
            //Number of flowers to buy
            int chrysanthemum = int.Parse(Console.ReadLine());
            int rose = int.Parse(Console.ReadLine());
            int tulip = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char holiday = (char)Console.Read();
            decimal bouquet = 0;
            if (season == "Spring" || season == "Summer")
            {
                bouquet = chrysanthemum * chrysanthemumWarm +
                    rose * roseWarm + tulip * tulipWarm;
                if (tulip > tulipPriceDecreaseTreshold && season == "Spring")
                {
                    bouquet -= (decimal)tulipPriceDecreasePercentage / 100 * bouquet;
                }
            }
            else
            {
                bouquet = chrysanthemum * chrysanthemumCold +
                    rose * roseCold + tulip * tulipCold;
                if (rose >= rosePriceDecreaseTreshold && season == "Winter")
                {
                    bouquet -= (decimal)rosePriceDecreasePercentage / 100 * bouquet;
                }
            }
            if (holiday == 'Y')
            {
                bouquet += (decimal)priceIncreasePercentage / 100 * bouquet;
            }
            if (chrysanthemum + rose + tulip > totalPriceDecreaseTreshold)
            {
                bouquet -= (decimal)totalPriceDecreasePercentage / 100 * bouquet;
            }
            Console.WriteLine("{0:F2}", bouquet + arrangePrice);
        }
    }
}
