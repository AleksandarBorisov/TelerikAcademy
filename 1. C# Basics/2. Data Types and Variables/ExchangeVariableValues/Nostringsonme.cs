using System;

namespace ExchangeVariableValues
{
    class Nostringsonme
    {
        static void Main()
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
