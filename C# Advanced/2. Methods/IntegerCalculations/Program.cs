using System;

namespace IntegerCalculations
{
    class Program
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);
            int c = int.Parse(numbers[2]);
            int d = int.Parse(numbers[3]);
            int e = int.Parse(numbers[4]);
            Console.WriteLine(Minimum(a, b, c, d, e));
            Console.WriteLine(Maximum(a, b, c, d, e));
            Console.WriteLine("{0:F2}", Average(a, b, c, d, e));
            Console.WriteLine(Sum(a, b, c, d, e));
            Console.WriteLine(Product(a, b, c, d, e));
        }

        static int Minimum(params int[] numbers)
        {
            int min = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }

        static int Maximum(params int[] numbers)
        {
            int max = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        static double Average(params int[] numbers)
        {
            double sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Length;
        }

        static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        static int Product(params int[] numbers)
        {
            int product = 1;
            foreach (int number in numbers)
            {
                product *= number;
            }
            return product;
        }
    }
}
