using System;

namespace DecToBin
{
    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            string binary = " ";
            if (n == 0)
            {
                Console.WriteLine(n);
            }
            else
            {
                for (long i = n; i > 0; i /= 2)
                {
                    if (i % 2 != 0)
                    {
                        binary = '1' + binary;
                    }
                    else
                    {
                        binary = '0' + binary;
                    }
                }
                binary = binary.Trim(' ');
                Console.WriteLine(binary);
            }
        }
    }
}
