using System;

namespace PrintingInHex
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.Write("{0,-10:X}", a);
            Console.Write("{0,-10}", Convert.ToString(a, 2).PadLeft(8,'0'));
            Console.Write("{0,10:F2}", b);
            Console.Write("{0,-10:F3}", c);
            Console.WriteLine();
        }
    }
}
