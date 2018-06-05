using System;

namespace DecimalToHexadecimal
{
    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            string result = "";
            string digits = "0123456789ABCDEF";
            do
            {
                int digitValue = (int)(n % 16);
                n /= 16;
                result = digits[digitValue] + result;
            } while (n != 0);
            Console.WriteLine(result);
        }
    }
}
