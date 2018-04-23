using System;

namespace MagicDates
{
    class Program
    {
        static void Main()
        {
            int startYear = int.Parse(Console.ReadLine());
            int endYear = int.Parse(Console.ReadLine());
            int weightNumber = int.Parse(Console.ReadLine());
            DateTime startDate = new DateTime(startYear, 1, 1);
            DateTime endDate = new DateTime(endYear, 12, 31);
            bool dateFound = false;
            for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {//Условието може да бъде и currentDate.Year <= endYear тъй като това няма да се изпълни чак когато влезнем в другата година
                int d1 = currentDate.Day / 10;
                int d2 = currentDate.Day % 10;
                int d3 = currentDate.Month / 10;
                int d4 = currentDate.Month % 10;
                int d5 = currentDate.Year / 1000;
                int d6 = (currentDate.Year / 100) % 10;
                int d7 = (currentDate.Year / 10) % 10;
                int d8 = currentDate.Year % 10;
                int currentWeight = d1 * (d2 + d3 + d4 + d5 + d6 + d7 + d8) + d2 * (d3 + d4 + d5 + d6 + d7 + d8)
                    + d3 * (d4 + d5 + d6 + d7 + d8) + d4 * (d5 + d6 + d7 + d8) + d5 * (d6 + d7 + d8) + d6 * (d7 + d8) + d7 * d8;
                //string dateAsString = currentDate.ToString("ddMMyyyy");
                //int currentWeight = 0;
                //for (int j = 0; j < dateAsString.Length; j++)
                //{
                //    for (int k = j + 1; k < dateAsString.Length; k++)
                //    {
                //        currentWeight += ((dateAsString[j] - '0') * (dateAsString[k] - '0'));
                //    }
                //}
                if (currentWeight == weightNumber)
                {
                    //Console.WriteLine("{0:dd-MM-yyyy}", currentDate);//Важно, обърни внимание че са еквивалентни двата реда
                    Console.WriteLine(currentDate.ToString("dd-MM-yyyy"));
                    dateFound = true;
                }
            }
            if (!dateFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}
