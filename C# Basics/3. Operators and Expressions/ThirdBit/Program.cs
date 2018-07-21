using System;

namespace ThirdBit
{
    class Program
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            int i = 1 << 3;
            Console.WriteLine((i & n) != 0 ? 1 : 0);
        }
    }
}
