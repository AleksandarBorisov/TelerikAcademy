using System;

namespace NthBit
{
    class Program
    {
        static void Main()
        {
            long p = long.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString(p, 2));
            int n = int.Parse(Console.ReadLine());
            n = (n > 63 ? 0 : n);//ако p беше от тип int условието е n > 31
            long mask = (long)1 << n;
            long rezult = (p & mask) >> n;
            Console.WriteLine(rezult != 0 ? 1 : 0);
        }
    }
}
