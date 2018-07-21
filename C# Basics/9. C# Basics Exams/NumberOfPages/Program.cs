using System;

namespace NumberOfPages
{
    class Program
    {
        static void Main()
        {
            int digits = int.Parse(Console.ReadLine());
            int pages = 0;
            int countingDigits = 0;
            while (digits != countingDigits)
            {
                pages++;
                int currentPage = pages;
                while (currentPage != 0)
                {
                    currentPage /= 10;
                    countingDigits++;
                }
            }
            //while (digits != 0)
            //{
            //    pages++;//Но този вариант е по-бавен и изисква повече памет
            //    digits -= pages.ToString().Length;
            //}
            Console.WriteLine(pages);
        }
    }
}
