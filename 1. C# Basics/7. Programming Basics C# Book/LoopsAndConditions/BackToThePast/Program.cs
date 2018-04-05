using System;

namespace BackToThePast
{
    class Program
    {
        static void Main()
        {
            //Console.Write("Въведете колко е наследството на Иванчо: ");
            double inheritance = double.Parse(Console.ReadLine());
            //Console.Write("Въведете въпросна година: ");
            int finalYear = int.Parse(Console.ReadLine());
            int age = 18;
            int expense = 0;
            for (int startingYear = 1800; startingYear <= finalYear; startingYear++)
            {
                expense = (startingYear % 2 == 0) ? 12000 : 12000 + 50 * age;
                inheritance -= expense;
                age++;
            }
            Console.WriteLine(inheritance >= 0 ? $"Yes! He will live a carefree life and will have {inheritance:0.00} dollars left." :
            $"He will need {(inheritance * -1):0.00} dollars to survive.");
        }
    }
}
