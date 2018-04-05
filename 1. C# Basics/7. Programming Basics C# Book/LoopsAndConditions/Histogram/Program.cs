using System;

namespace Histogram
{
    class Program
    {
        static void Main()
        {
            //Console.Write("Въведете брой числа: ");
            int n = int.Parse(Console.ReadLine());
            double percentage1 = 0;
            double percentage2 = 0;
            double percentage3 = 0;
            double percentage4 = 0;
            double percentage5 = 0;
            for (int i = 1; i <= n; i++)
            {
                //Console.Write("Моля въведете {0} число: ", i);
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber < 200)
                {
                    percentage1++;
                }
                else if ((currentNumber >= 200) && (currentNumber < 400))
                {
                    percentage2++;
                }
                else if ((currentNumber >= 400) && (currentNumber < 600))
                {
                    percentage3++;
                }
                else if ((currentNumber >= 600) && (currentNumber < 800))
                {
                    percentage4++;
                }
                else if (currentNumber >= 800)
                {
                    percentage5++;
                }
            }
            Console.WriteLine("{0:P}", percentage1 / n);
            Console.WriteLine("{0:P}", percentage2 / n);
            Console.WriteLine("{0:P}", percentage3 / n);
            Console.WriteLine("{0:P}", percentage4 / n);
            Console.WriteLine("{0:P}", percentage5 / n);
        }
    }
}
