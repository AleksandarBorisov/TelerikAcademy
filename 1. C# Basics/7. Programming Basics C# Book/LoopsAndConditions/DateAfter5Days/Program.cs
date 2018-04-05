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
            //Console.WriteLine("{0}.{1:D2}",after5Days.Day ,after5Days.Month);
            int daysOfMonth = 31;
            if (m == 2)
            {
                daysOfMonth = 28;
            }
            if (m == 4 || m == 6 || m == 9 || m == 11)
            {
                daysOfMonth = 30;
            }
            d += 5;
            if (d > daysOfMonth)
            {
                d -= daysOfMonth;
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
