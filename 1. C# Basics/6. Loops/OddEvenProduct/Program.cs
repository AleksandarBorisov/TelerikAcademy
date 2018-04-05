using System;

namespace OddEvenProduct
{
    class Program
    {
        static void Main()
        {
                int n = int.Parse(Console.ReadLine());
                string line = Console.ReadLine();
                string[] numbers = line.Split(' ');
                double odd = 1;
                double even = 1;
                for (int i = 0; i < n; i++)
                {
                    double number = double.Parse(numbers[i]);
                    if (i % 2 == 0)
                    {
                        odd *= number;//Защото броим от 1 до n
                    }
                    else
                    {
                        even *= number;
                    }
                }
                Console.WriteLine(even == odd ? "yes " + even : "no " + odd + " " + even);
        }
    }
}
