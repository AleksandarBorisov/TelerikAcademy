using System;

namespace SolveTasks
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose action:");
            Console.WriteLine("1 - Reverse the digits of a number");
            Console.WriteLine("2 - Calculate the average of a sequence of integers");
            Console.WriteLine("3 - Solve a linear equation a * x + b = 0");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                string numberAsString = Console.ReadLine();
                while (decimal.Parse(numberAsString) < 0)
                {
                    Console.WriteLine("Please enter non-negative number!");
                    numberAsString = Console.ReadLine();
                }
                Console.WriteLine(Reverse(numberAsString));
            }
            else if (choice == 2)
            {
                string[] numbers = Console.ReadLine().Split(' ');
                while (numbers.Length == 0)
                {
                    Console.WriteLine("You've entered empty string!");
                    numbers = Console.ReadLine().Split(' ');
                }
                Console.WriteLine("{0:F2}", Average(numbers));
            }
            else if (choice == 3)
            {
                string[] coefficients = Console.ReadLine().Split(' ');
                int a = int.Parse(coefficients[0]);
                while (a == 0)
                {
                    Console.WriteLine("coefficient a must be different from 0!");
                    coefficients = Console.ReadLine().Split(' ');
                    a = int.Parse(coefficients[0]);
                }
                int b = int.Parse(coefficients[1]);
                Console.WriteLine(Solve(a, b));
            }
            else
            {
                Console.WriteLine("Choice is an illusion. Please choose option 1-3.");
            }
            Main();
        }

        static string Reverse(string number)
        {
            string newNumber = "";
            foreach (var digit in number)
            {
                newNumber = digit + newNumber;
            }
            return newNumber;
        }

        static double Average(string[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += double.Parse(numbers[i]);
            }
            return sum / numbers.Length;
        }

        static double Solve(int a, int b)
        {
            double result = (double)(-b) / a;
            return result;
        }
    }
}
