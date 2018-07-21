using System;

namespace _4.ThrowingExceptions
{
    class Program
    {
        static void Main()
        {
            try
            {
                Sqrt(-1);
                Console.WriteLine("text");
                Console.WriteLine("moar text");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.Error.WriteLine("Error: {0}", ex.Message);
                throw;
            }
        }

        public static double Sqrt(double value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Sqrt for negative numbers is undefined!");
            }
            return Math.Sqrt(value);
        }
    }
}
