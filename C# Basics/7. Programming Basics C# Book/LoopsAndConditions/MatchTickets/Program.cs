using System;

namespace MatchTickets
{
    class Program
    {
        static void Main()
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string ticketType = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            decimal ticketPrice = 249.99m;
            if (ticketType == "VIP")
            {
                ticketPrice = 499.99m;
            }
            decimal moneyNeedForTickets = people * ticketPrice;
            decimal transport = 0.25m * budget;
            if (people <= 4)
            {
                transport = 0.75m * budget;
            }
            else if (people <= 9)
            {
                transport = 0.60m * budget;
            }
            else if (people <= 24)
            {
                transport = 0.50m * budget;
            }
            else if (people <= 49)
            {
                transport = 0.40m * budget;
            }
            decimal moneyLeftForTickets = budget - transport;
            string result = string.Format("Yes! You have {0:F2} leva left.", moneyLeftForTickets - moneyNeedForTickets);
            if (moneyLeftForTickets < moneyNeedForTickets)
            {
                result = string.Format("Not enough money! You need {0:F2} leva.", moneyNeedForTickets - moneyLeftForTickets);
            }
            Console.WriteLine(result);
            //Main();
        }
    }
}
