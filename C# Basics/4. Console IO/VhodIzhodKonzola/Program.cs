using System;

namespace VhodIzhodKonzola
{
    class Program
    {
        static void Main()
        {
            float a = 0;
            float b = 2;
            int counter = 0;
            float sum = 1;
            float prev = 0;
            while (Math.Abs(sum - prev) > 0.001)
            {
                a = 1 / (b);
                prev = sum;
                if (b % 2 != 0)
                {
                    sum -= a;
                }
                if (b % 2 == 0)
                {
                    sum += a;
                }
                b++;
                counter++;
            }
            Console.WriteLine("На {0}-ия член сумата достигна търсената точност и е: {1:F3}", counter, sum);
        }
    }
}

