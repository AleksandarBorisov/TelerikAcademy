using System;

namespace FourDigits
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int a = number / 1000;
            int b = (number / 100) % 10;
            int c = (number / 10) % 10;
            int d = number % 10;
            int sum = a + b + c + d;
            string reversed = d.ToString() + c.ToString() + b.ToString() + a.ToString();
            string inFront = d.ToString() + a.ToString() + b.ToString() + c.ToString();
            string scramble = a.ToString() + c.ToString() + b.ToString() + d.ToString();
            Console.WriteLine(sum);
            Console.WriteLine(reversed);
            Console.WriteLine(inFront);
            Console.WriteLine(scramble);
        }
    }
}
