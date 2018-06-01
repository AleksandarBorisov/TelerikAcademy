using System;

namespace OddEven
{
    class Program
    {
        static void Main()
        {
            //while (true)
            //{
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            if (input == "")
            {
                numbers = new string[0];
            }
            decimal oddMin = decimal.MaxValue;
            decimal oddMax = decimal.MinValue;
            decimal oddSum = 0;
            decimal evenMin = decimal.MaxValue;
            decimal evenMax = decimal.MinValue;
            decimal evenSum = 0;
            bool checkerOdd = false;
            bool checkerEven = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                decimal number = decimal.Parse(numbers[i]);
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
                Console.Write("OddSum={0:0.#################}, OddMin={1:0.#################}, OddMax={2:0.#################}, ", oddSum, oddMin, oddMax);
            }
            else
            {
                Console.Write("OddSum={0}, OddMin={0}, OddMax={0}, ", "No"); ;
            }
            if (checkerEven)
            {
                Console.Write("EvenSum={0:0.#################}, EvenMin={1:0.#################}, EvenMax={2:0.#################}", evenSum, evenMin, evenMax);
            }
            else
            {
                Console.Write("EvenSum={0}, EvenMin={0}, EvenMax={0}", "No"); ;
            }
            Console.WriteLine();
            //}
        }
    }
}
