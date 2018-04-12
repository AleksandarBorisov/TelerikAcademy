using System;

namespace AmericanPie
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            long resultNominator = a * d + c * b;
            long resultDenominator = b * d;
            if (resultNominator >= resultDenominator)
            {
                Console.WriteLine(resultNominator / resultDenominator);
            }
            else
            {
                Console.WriteLine("{0:F20}", resultNominator / (decimal)resultDenominator);
            }
            Console.WriteLine(resultNominator + "/" + resultDenominator);
        }
    }
}
