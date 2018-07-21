using System;

namespace FromBookMonths
{
    class Program
    {
        static string GetMonth(int month)
        {
            string monthName;
            if (1 <= month && month <= 12)
            {
                DateTime newMonth = new DateTime(2018, month, 13);
                monthName = string.Format("{0:MMMM}", newMonth);//Извеждаме месеца с пълното му наименование
            }
            else
            {
                monthName = "Invalid month!";
            }
            return monthName;
        }
        static void SayPeriod(int startMonth, int endMonth)
        {
            int period = endMonth - startMonth;
            if (period < 0)
            {//Fix negative distance
                period += 12;
            }
            Console.WriteLine("There is {0} months period from {1} to {2}.", period, GetMonth(startMonth), GetMonth(endMonth));
        }
        static void Main()
        {
            Console.Write("First month (1-12): ");
            int firstMonth = int.Parse(Console.ReadLine());
            Console.Write("Second month (1-12): ");
            int secondMonth = int.Parse(Console.ReadLine());
            SayPeriod(firstMonth, secondMonth);

            //Console.WriteLine("{0}", month.DayOfYear);//Кой номер е деня измежду 1 и 365
            //int day = int.Parse(Console.ReadLine());//Number between 0 and 6 inclusive
            //DayOfWeek today =  (DayOfWeek)day;//Кастваме int към тип DayOfWeek
            //Console.WriteLine(today);
            //Main();
        }
    }
}
