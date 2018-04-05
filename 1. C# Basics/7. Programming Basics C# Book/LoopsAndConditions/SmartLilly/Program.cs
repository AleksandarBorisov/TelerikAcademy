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
            int bonus = 1;
            for (int i = 1; i <= years; i++)
            {
                if (i % 2 != 0)
                {
                    giftToys++;
                }
                else
                {
                    giftMoney += bonus * 10;
                    bonus++;
                    giftMoney--;
                }
            }
            //Console.Write("Моля въведете цена на пералня машина: ");
            double price = double.Parse(Console.ReadLine());
            //Console.Write("Въведете цена на една играчка: ");
            int p = int.Parse(Console.ReadLine());
            int giftToysMoney = p * giftToys;
            //Console.WriteLine("Лили е спестила {0} лева, ", (giftMoney + giftToysMoney));
            Console.WriteLine((giftMoney + giftToysMoney) >= price ? $"което е достатъчно с излишък {((giftMoney + giftToysMoney) - price):0.00} лева." : $"което не е достатъчно с недостиг {(price - (giftMoney + giftToysMoney)):0.00} лева.");
        }
    }
}
