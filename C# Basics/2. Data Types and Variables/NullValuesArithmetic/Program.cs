using System;

namespace NullValuesArithmetic
{
    class Program
    {
        static void Main()
        {
            int? zeroint = null;
            double? zerodouble = null;
            zeroint = 5;
            Console.WriteLine(zeroint+5);
            Console.WriteLine(zerodouble+1.3);
        }
    }
}
