using System;

namespace _1.ExceptionHandling
{
    class Program
    {
        static void Main()
        {
            try
            {
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(5 / a);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
