using System;
namespace GCD
{
    class Program
    {
        static void Main()
        {
                string[] numbers = Console.ReadLine().Split(' ');
                int? a = int.Parse(numbers[0]);
                int? b = int.Parse(numbers[1]);
                while ((a != b) && (a > 0) && (b > 0))
                {
                    if (a > b)
                    {
                        a = a - b;
                    }
                    else
                    {
                        b = b - a;
                    }
                }
                Console.WriteLine((a ?? b));
            
        }
    }
}
