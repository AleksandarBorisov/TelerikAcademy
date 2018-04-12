using System;

namespace Garden
{
    class Program
    {
        static void Main()
        {
            int totalArea = 250;
            float totalPrice = 0;
            float tomatoPrice = 0.5f;
            float cucumberPrice = 0.4f;
            float potatoPrice = 0.25f;
            float carrotPrice = 0.6f;
            float cabbagePrice = 0.3f;
            float beansPrice = 0.4f;
            for (int i = 0; i < 5; i++)
            {
                int seedsCount = int.Parse(Console.ReadLine());
                int area = int.Parse(Console.ReadLine());
                totalArea -= area;
                switch (i)
                {
                    case 0: totalPrice += seedsCount * tomatoPrice; break;
                    case 1: totalPrice += seedsCount * cucumberPrice; break;
                    case 2: totalPrice += seedsCount * potatoPrice; break;
                    case 3: totalPrice += seedsCount * carrotPrice; break;
                    case 4: totalPrice += seedsCount * cabbagePrice; break;
                }
            }
            int beansSeed = int.Parse(Console.ReadLine());
            totalPrice += beansSeed * beansPrice;
            Console.WriteLine("Total costs: {0:F2}", totalPrice);
            if (totalArea > 0)
            {
                Console.WriteLine("Beans area: {0}", totalArea);
            }
            else if(totalArea==0)
            {
                Console.WriteLine("No area for beans");
            }
            else
            {
                Console.WriteLine("Insufficient area");
            }
        }
    }
}
