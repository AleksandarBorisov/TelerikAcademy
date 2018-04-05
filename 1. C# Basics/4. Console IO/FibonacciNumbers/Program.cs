using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long a = 1;
            long b = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write((i==n?"{0}":"{0}, "), b);
                b = a + b;
                a = b - a;
            }
            Console.WriteLine();
        }
    }
}
