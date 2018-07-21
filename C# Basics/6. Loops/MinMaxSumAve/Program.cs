using System;

namespace MinMaxSumAve
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double biggestNumber = double.MinValue;
            double smalestNumber = double.MaxValue;
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double newNumber = double.Parse(Console.ReadLine());
                if (biggestNumber < newNumber)
                {
                    biggestNumber = newNumber;
                }
                if (smalestNumber > newNumber)
                {
                    smalestNumber = newNumber;
                }
                sum += newNumber;
            }
            Console.WriteLine("min={0:F2}", smalestNumber);
            Console.WriteLine("max={0:F2}", biggestNumber);
            Console.WriteLine("sum={0:F2}", sum);
            Console.WriteLine("avg={0:F2}", sum / n);
        }
    }
}
