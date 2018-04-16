using System;
using System.Globalization;
using System.Threading;

namespace Age
{
    class HelloCSharp
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            DateTime birthDay;
            int difference = 0;
            bool parseSuccess = DateTime.TryParse(Console.ReadLine(), out birthDay);
            if(parseSuccess&& birthDay.Month >= 11)
            {
                difference = 2016 - birthDay.Year - 1;
            }
            else if(parseSuccess && birthDay.Month < 11)
            {
                difference = 2016 - birthDay.Year;  
            }
            else if(parseSuccess==false)
            {
                difference = 2016;
            }
            Console.WriteLine(difference);
            Console.WriteLine(difference + 10);
            //DateTime age = DateTime.Now.AddYears(difference=-birthDay.Year);
            //Console.WriteLine(age.AddYears(10).Year);
        }
    }
}

