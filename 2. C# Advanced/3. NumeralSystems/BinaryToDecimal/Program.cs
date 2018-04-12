using System;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main()
        {
            string binary = Console.ReadLine();
            ulong result = 0;
            foreach (char digit in binary)
            {
                result = result * 2 + (ulong)(digit - '0');
            }
            Console.WriteLine(result);
            Main();
        }
    }
}
