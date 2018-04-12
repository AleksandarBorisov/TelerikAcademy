using System;

namespace OddEven
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                string[] numbers = Console.ReadLine().Split(' ');
                double oddMin = double.MaxValue;
                double oddMax = double.MinValue;
                double oddSum = 0;
                double evenMin = double.MaxValue;
                double evenMax = double.MinValue;
                double evenSum = 0;
                bool checkerOdd = false;
                bool checkerEven = false;

                for (int i = 0; i < numbers.Length; i++)
                {
                    double number = double.Parse(numbers[i]);
                    if (i % 2 == 0)
                    {
                        oddMin = (oddMin < number ? oddMin : number);
                        oddMax = (oddMax > number ? oddMax : number);
                        oddSum += number;
                        checkerOdd = true;
                    }
                    if (i % 2 != 0)
                    {
                        evenMin = (evenMin < number ? evenMin : number);
                        evenMax = (evenMax > number ? evenMax : number);
                        evenSum += number;
                        checkerEven = true;
                    }
                }
                if (checkerOdd)
                {
                    Console.Write("OddSum={0:#.#################}, OddMin={1:#.#################}, OddMax={2:#.#################}, ", oddSum, oddMin, oddMax);
                }
                else
                {
                    Console.Write("OddSum={0}, OddMin={0}, OddMax={0}, ", "No"); ;
                }
                if (checkerEven)
                {
                    Console.Write("EvenSum={0:#.#################}, EvenMin={1:#.#################}, EvenMax={2:#.#################}", evenSum, evenMin, evenMax);
                }
                else
                {
                    Console.Write("EvenSum={0}, EvenMin={0}, EvenMax={0}", "No"); ;
                }
                Console.WriteLine();
            }
        }
    }
}
