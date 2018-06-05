using System;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main()
        {
            string binary = Console.ReadLine();
            long result = 0;
            foreach (char digit in binary)
            {
                result = result * 2 + (digit - '0');
            }
            Console.WriteLine(result);
            //Main();
        }
    }
}
