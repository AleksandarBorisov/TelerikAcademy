using System;

namespace SumOfnumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double k = double.Parse(Console.ReadLine());
                sum += k;
            }
            Console.WriteLine(sum);
        }
    }
}
