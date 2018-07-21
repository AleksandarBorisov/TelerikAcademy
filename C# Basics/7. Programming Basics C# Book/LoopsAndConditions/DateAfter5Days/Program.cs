using System;

namespace DateAfter5Days
{
    class Program
    {
        static void Main()
        {
            int d = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            //DateTime now = new DateTime(DateTime.Now.Year, m, d);
            //DateTime after5Days = now.AddDays(5);
            //Console.WriteLine("{0}.{1:D2}",after5Days.Day ,after5Days.Month);//Форматиращия стринг може да бъде:("{0:d.MM}",now)
            int daysInMonth = 31;
            if (m == 2)
            {
                daysInMonth = 28;
            }
            if (m == 4 || m == 6 || m == 9 || m == 11)
            {
                daysInMonth = 30;
            }
            d += 5;
            if (d > daysInMonth)
            {
                d -= daysInMonth;
                m++;
                if (m > 12)
                {
                    m = 1;
                }
            }
            Console.WriteLine("{0}.{1:D2}", d, m);

        }
    }
}
