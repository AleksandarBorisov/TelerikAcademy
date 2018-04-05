using System;

namespace MinMethod
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            var min = GetMin(GetMin(a, b), c);
            Console.WriteLine(min);
        }
        static int GetMin(int a, int b)
        {
            return Math.Min(a, b);
        }
    }
}
