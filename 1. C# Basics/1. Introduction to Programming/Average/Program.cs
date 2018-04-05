using System;

namespace Sum
{
    class Program
    {
        static void Main()
        {
            for (int i = 2; i <= 11; i++)
            {
                int a = i % 2 == 0 ? i : i * -1;
                Console.WriteLine(a + " ");
            }
        }
    }
}
