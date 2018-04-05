using System;

namespace Bricks
{
    class Program
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Ceiling((double)x/(w*m)));
        }
    }
}
