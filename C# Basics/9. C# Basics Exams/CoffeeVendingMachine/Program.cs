using System;

namespace CoffeeVendingMachine
{
    class Program
    {
        static void Main()
        {
            int countFive = int.Parse(Console.ReadLine());
            int countTen = int.Parse(Console.ReadLine());
            int countTwenty = int.Parse(Console.ReadLine());
            int countFifty = int.Parse(Console.ReadLine());
            int countHundred = int.Parse(Console.ReadLine());
            float valueFive = 0.05f;
            float valueTen = 0.10f;
            float valueTwenty = 0.20f;
            float valueFifty = 0.50f;
            float valueHundred = 1.00f;
            float moneyInMachine = countFive * valueFive + countTen * valueTen + countTwenty * valueTwenty
                + countFifty * valueFifty + countHundred * valueHundred;
            float insertedMoney = float.Parse(Console.ReadLine());
            float priceOFDrink = float.Parse(Console.ReadLine());
            float change = insertedMoney - priceOFDrink;
            if (change >= 0 && moneyInMachine >= change)
            {
                Console.WriteLine("Yes {0:F2}", moneyInMachine - change);
                //TODO "Yes" + amount left in the machine
            }
            else if (change < 0)
            {
                Console.WriteLine("More {0:F2}", Math.Abs(change));
                //TODO "More" + amount needed
            }
            else if (change >= 0 && moneyInMachine < change)
            {
                Console.WriteLine("No {0:F2}", change - moneyInMachine);
                //TODO "No" + insufficient money in the machine
            }
        }
    }
}
