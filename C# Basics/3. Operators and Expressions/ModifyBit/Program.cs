using System;

namespace ModifyBit
{
    class Program
    {
        static void Main()
        {
            ulong n = ulong.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString(n,2));
            int p = int.Parse(Console.ReadLine());
            ulong v = ulong.Parse(Console.ReadLine());
            p = (p > 63 ? 0 : p);
            ulong mask = (v == (ulong)1) ? ((ulong)1 << p) : ~((ulong)1 << p);
            ulong rezult = v == 1 ? (mask | n) : (mask & n);
            Console.WriteLine(rezult);
        }
    }
}
