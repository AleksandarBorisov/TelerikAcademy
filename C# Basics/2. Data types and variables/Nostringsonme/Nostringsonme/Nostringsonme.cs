using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nostringsonme
{
    class Nostringsonme
    {
        static void Main(string[] args)
        {
            int a=5;
            int b=10;
            Console.WriteLine(a);
            Console.WriteLine(b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a new value is: " + a);
            Console.WriteLine("b new value is: " + b);
        }
    }
}
