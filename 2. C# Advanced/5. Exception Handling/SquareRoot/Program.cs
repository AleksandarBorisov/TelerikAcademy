using System;

namespace SquareRoot
{
    class Program
    {
        static void Main()
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    throw new FormatException();
                }
                double sqrt = Math.Sqrt(n);
                Console.WriteLine($"{sqrt:F3}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Invalid number");

            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
