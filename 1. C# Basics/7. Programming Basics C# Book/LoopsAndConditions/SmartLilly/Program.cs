using System;

namespace SmartLilly
{
    class Program
    {
        static void Main()
        {
            //Console.Write("Въведете годините на Лили: ");
            int years = int.Parse(Console.ReadLine());
            int giftMoney = 0;
            int giftToys = 0;
            int moneyForBirthday = 10;
            for (int i = 1; i <= years; i++)
            {
                if (i % 2 != 0)
                {
                    giftToys++;
                }
                else
                {
                    giftMoney += (moneyForBirthday - 1);
                    moneyForBirthday += 10;
                }
            }
            //Console.Write("Моля въведете цена на пералня машина: ");
            double priceOfWashingMachine = double.Parse(Console.ReadLine());
            //Console.Write("Въведете цена на една играчка: ");
            int price = int.Parse(Console.ReadLine());
            giftMoney += price * giftToys;
            //Console.WriteLine("Лили е спестила {0} лева, ", (giftMoney + giftToysMoney));
            Console.WriteLine(giftMoney >= priceOfWashingMachine ? $"което е достатъчно с излишък {(giftMoney - priceOfWashingMachine):0.00} лева." : $"което не е достатъчно с недостиг {(priceOfWashingMachine - giftMoney):0.00} лева.");
        }
    }
}
