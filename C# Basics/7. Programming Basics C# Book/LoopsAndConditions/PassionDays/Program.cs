using System;

namespace PassionDays
{
    class Program
    {
        static void Main()
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int purchases = 0;
            while (command != "mall.Enter")
            {
                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while (command != "mall.Exit")
            {
                foreach (char action in command)
                {
                    if ('A' <= action && action <= 'Z')
                    {
                        decimal price = action * 0.5M;
                        if (budget < price)
                        {
                            continue;
                        }
                        budget -= price;
                        purchases++;
                    }
                    else if ('a' <= action && action <= 'z')
                    {
                        decimal price = action * 0.3M;
                        if (budget < price)
                        {
                            continue;
                        }
                        budget -= price;
                        purchases++;
                    }
                    else if (action == '%' && budget > 0)
                    {
                        budget /= 2M;
                        purchases++;
                    }
                    else if (action == '*')
                    {
                        budget += 10M;
                    }
                    else
                    {
                        if (budget < action)
                        {
                            continue;
                        }
                        budget -= action;
                        purchases++;
                    }
                }
                command = Console.ReadLine();
            }
            if (purchases == 0)
            {
                Console.Write("No purchases.");
                Console.WriteLine(" Money left: {0:F2} lv.", budget);
            }
            else
            {
                Console.Write("{0} purchases.", purchases);
                Console.WriteLine(" Money left: {0:F2} lv.", budget);
            }
        }
    }
}
