using System;

namespace BalancedNumbers
{
    class Program
    {
        static void Main()
        {
            int sum = 0;
            int n = int.Parse(Console.ReadLine());
            int a = n / 100;
            int b = (n / 10) % 10;
            int c = n % 10;
            while (b == a + c)
            {
                sum += n;
                n = int.Parse(Console.ReadLine());
                a = n / 100;
                b = (n / 10) % 10;
                c = n % 10;
            }

            //Това решение е с една стотна по-бавно от първото
            //int a = Console.Read() - '0';
            //int b = Console.Read() - '0';
            //int c = Console.Read() - '0';
            //while (b == a + c)
            //{
            //    sum += (a * 100 + b * 10 + c);
            //    //Console.Read();//Явно системата, която тества поставя само един знак за нов ред
            //    Console.Read();
            //    a = Console.Read() - '0';
            //    b = Console.Read() - '0';
            //    c = Console.Read() - '0';
            //}

            Console.WriteLine(sum);
        }
    }
}
