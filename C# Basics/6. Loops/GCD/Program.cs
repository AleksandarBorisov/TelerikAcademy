using System;

namespace GCD
{
    class Program
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            Console.WriteLine(a);
            //Main();
            //Алгоритъма на Евклид гласи че за две числа а и b са в сила равенствата:
            //1. a = b * q + r;(r е с остатъкът при деление a / b, ако го разпишем, накрая ще получим r = r * q + 0)
            //2. GCD(a, b) = GCD(b, r);(Като го разпишем докрай получаваме че GCD(a, b)=GCD(r, 0))
            //т. е. винаги накрая получаваме остатък и 0, чийто най-голям общ делител е самия остатък
        }
    }
}
