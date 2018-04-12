using System;

namespace _3_6_9
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                int result = 0;
                if (b == 3)
                {
                    result = a + c;
                }
                else if (b == 6)
                {
                    result = a * c;
                }
                else if (b == 9)
                {
                    result = a % c;
                }
                if (result % 3 == 0)
                {
                    Console.WriteLine(result / 3);
                }
                else
                {
                    Console.WriteLine(result % 3);
                }
                Console.WriteLine(result);
            }
            
        }
    }
}
