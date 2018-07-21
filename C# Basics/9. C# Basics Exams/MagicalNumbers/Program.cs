using System;

namespace MagicalNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int hundreds = (n / 100) % 10;
            int tens = (n / 10) % 10;
            int units = (n / 1) % 10;
            double result = 0;
            if (units == 0)
            {
                result = 0;
            }
            else if (tens % 2 == 0)
            {
                result = (hundreds + tens) * units;
            }
            else
            {
                result = (double)(hundreds * tens) / units;
            }
            Console.WriteLine("{0:F2}", result);
        }
    }
}
