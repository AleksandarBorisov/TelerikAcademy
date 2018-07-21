using System;

namespace Trip
{
    class Program
    {
        static void Main()
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "Europe";
            decimal budgetSpent = 0.9M * budget;
            string holidayInformation = string.Format("Hotel - {0:F2}", budgetSpent);
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season.Equals("summer"))
                {
                    budgetSpent = 0.3M * budget;
                    holidayInformation = string.Format("Camp - {0:F2}", budgetSpent);
                }
                else
                {
                    budgetSpent = 0.7M * budget;
                    holidayInformation = string.Format("Hotel - {0:F2}", budgetSpent);
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season.Equals("summer"))
                {
                    budgetSpent = 0.4M * budget;
                    holidayInformation = string.Format("Camp - {0:F2}", budgetSpent);
                }
                else
                {
                    budgetSpent = 0.8M * budget;
                    holidayInformation = string.Format("Hotel - {0:F2}", budgetSpent);
                }
            }
            Console.WriteLine("Somewhere in {0}", destination);
            Console.WriteLine(holidayInformation);
            //Main();
        }
    }
}
