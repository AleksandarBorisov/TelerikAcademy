using System;

namespace MythicalNumbers
{
    class Program
    {
        static void Main()
        {
            //string number = Console.ReadLine();
            //int a = number[0] - '0';
            //int b = number[1] - '0';
            //int c = number[2] - '0';

            int number = int.Parse(Console.ReadLine());
            int a = (number / 100) % 10;//% 10 се налага в случаи, в които имаме число с повече от 3 цифри
            int b = (number / 10) % 10;
            int c = (number / 1) % 10;
            double product = 0;
            if (c == 0)
            {
                product = a * b;
            }
            else if (c <= 5)
            {
                product = (a * b) / (double)c;
            }
            else if (c > 5)
            {
                product = (a + b) * c;
            }
            Console.WriteLine("{0:F2}", product);
        }
    }
}
