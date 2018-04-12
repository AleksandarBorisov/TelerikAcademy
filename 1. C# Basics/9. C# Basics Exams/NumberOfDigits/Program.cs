using System;

namespace NumberOfDigits
{
    class Program
    {
        static void Main()
        {
            int pages = int.Parse(Console.ReadLine());
            int digits = 0;
            int currentPage = 0;
            while (currentPage != pages)
            {
                currentPage++;
                int currentDigit = currentPage;
                while (currentDigit != 0)
                {
                    currentDigit /= 10;
                    digits++;
                }
            }
            Console.WriteLine(digits);
        }
    }
}
