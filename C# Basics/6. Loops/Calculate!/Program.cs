using System;

namespace Calculate_
{
    class Program
    {
        static void Main()
        {
                double n = double.Parse(Console.ReadLine());
                double x = double.Parse(Console.ReadLine());
                double sum = 1;
                double faktorial = 1;
                double product = 1;
                for (double i = 1; i <= n; i++)
                {
                    faktorial *= i;
                    product *= x;
                    sum += faktorial / product;
                }
                Console.WriteLine("{0:F5}",sum);
        }
    }
}
