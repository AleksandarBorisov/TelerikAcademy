using System;

namespace Logistics
{
    class Program
    {
        static void Main()
        {
            //Console.Write("Колко товара ще превозвате: ");
            int count = int.Parse(Console.ReadLine());
            double cargoBus = 0;
            double cargoTruck = 0;
            double cargoTrain = 0;
            double load = 0;
            for (int i = 1; i <= count; i++)
            {
                //Console.Write("Въведете тонаж на товара: ");
                int cargo = int.Parse(Console.ReadLine());
                if (cargo <= 3)
                {
                    cargoBus += cargo;
                }
                else if (cargo > 3 && cargo <= 11)
                {
                    cargoTruck += cargo;
                }
                else
                {
                    cargoTrain += cargo;
                }
                load += cargo;
            }
            Console.WriteLine($"Средната цена на тон е: {(cargoBus * 200 + cargoTruck * 175 + cargoTrain * 120) / load:F2}");
            Console.WriteLine($"{cargoBus / load:P} от товара се превозва с микробус.");
            Console.WriteLine($"{cargoTruck / load:P} от товара се превозва с камион.");
            Console.WriteLine($"{cargoTrain / load:P} от товара се превозва с влак.");
        }
    }
}
