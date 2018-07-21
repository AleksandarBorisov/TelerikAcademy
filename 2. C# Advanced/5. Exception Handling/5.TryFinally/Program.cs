using System;

namespace _5.TryFinally
{
    class Program
    {
        static void Main()
        {
            PerformTryFinally();
        }

        static void PerformTryFinally()
        {
            Console.WriteLine("Code executed before try-finally.");
            try
            {
                Console.Write("Enter a number: ");
                string number = Console.ReadLine();
                int.Parse(number);
                Console.WriteLine("Parsing was successful.");
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("Parsing failed!");
            }
            finally
            {
                Console.WriteLine("This cleanup code is always executed.");
            }
            Console.WriteLine("This code is after the try-finally block");
        }
    }
}
