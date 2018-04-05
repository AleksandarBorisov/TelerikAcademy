using System;

namespace OddOrEven
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int rezult = n % 2;
            Console.WriteLine(rezult == 0 ? "even {0}" : "odd {0}",n);
        }
    }
}
