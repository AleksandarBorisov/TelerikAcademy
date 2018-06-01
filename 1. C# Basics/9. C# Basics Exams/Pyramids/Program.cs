using System;

namespace Pyramids
{
    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            int counter = 1;
            for (long i = 0; i < n; i += counter)
            {
                counter++;
            }
            Console.WriteLine(counter - 1);
            //Main();
            //Като разпишем пирамидата в следния вид
            // о    о    о о    о о   о о   о о о   о о о   о о о   о о о   о о о о
            //      о    о      о     о о   о о     о о     о о     о о о   о о о
            //                  о     о     о       о       о о     о о     о о
            //                                      о       о       о       о
            //Виждаме за всеки увеличаващ се интервал от числа колко колони имаме
            //1-2(1), 3-5(2), 6-9(3), 10-14(4) и т. н.
        }
    }
}
