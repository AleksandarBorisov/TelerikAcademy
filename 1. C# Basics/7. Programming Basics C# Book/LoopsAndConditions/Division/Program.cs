using System;

namespace Division
{
    class Program
    {
        static void Main()
        {
            //Console.Write("Въведете брой цели числа за проверка: ");
            int n = int.Parse(Console.ReadLine());
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            for (int i = 1; i <= n; i++)
            {
                //Console.Write($"Въведете {i}-о число: ");
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber % 2 == 0)
                {
                    p2++;
                }
                if (currentNumber % 3 == 0)
                {
                    p3++;
                }
                if (currentNumber % 4 == 0)
                {
                    p4++;
                }
            }
            Console.WriteLine($"Делящи без остатък на 2: {p2 / n:P}");
            Console.WriteLine($"Делящи без остатък на 3: {p3 / n:P}");
            Console.WriteLine($"Делящи без остатък на 4: {p4 / n:P}");
        }
    }
}
