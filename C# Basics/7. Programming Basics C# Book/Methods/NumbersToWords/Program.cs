using System;

namespace NumbersToWords
{
    class Program
    {
        static void Main()
        {
            int numberCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberCount; i++)
            {
                Letterize();
            }
        }
        static void Letterize()
        {
            int number = int.Parse(Console.ReadLine());
            if (number > 999)
            {
                Console.WriteLine("too large");
            }
            else if (number < -999)
            {
                Console.WriteLine("too small");
            }
            else if (number > 99 || number < -99)
            {//Гарантира че числото е съставено от три цифри
                if (number < 0)
                {
                    Console.Write("minus ");
                    number *= -1;
                }
                int hundreds = (number / 100) % 10;
                int tens = (number / 10) % 10;
                int units = (number / 1) % 10;
                PrintHundreds(hundreds);
                if (tens != 0 || units != 0)
                {//Проверяваме дали имаме десетици и единици
                    Console.Write("and ");
                }
                if (tens == 1)
                {
                    PrintFromTenToNineteen(units);
                }
                else if (tens > 1)
                {
                    PrintFromTwentyToNinety(tens);
                }
                if (tens != 1)
                {
                    PrintUnits(units);
                }
                Console.WriteLine();
            }
        }
        static void PrintHundreds(int hundreds)
        {
            switch (hundreds)
            {
                case 1: Console.Write("one-hundred "); break;
                case 2: Console.Write("two-hundred "); break;
                case 3: Console.Write("three-hundred "); break;
                case 4: Console.Write("four-hundred "); break;
                case 5: Console.Write("five-hundred "); break;
                case 6: Console.Write("six-hundred "); break;
                case 7: Console.Write("seven-hundred "); break;
                case 8: Console.Write("eight-hundred "); break;
                case 9: Console.Write("nine-hundred "); break;
                default: return;
            }
        }
        static void PrintFromTenToNineteen(int units)
        {
            switch (units)
            {
                case 0: Console.Write("ten"); break;
                case 1: Console.Write("eleven"); break;
                case 2: Console.Write("twelve"); break;
                case 3: Console.Write("thirteen"); break;
                case 4: Console.Write("fourteen"); break;
                case 5: Console.Write("fifteen"); break;
                case 6: Console.Write("sixteen"); break;
                case 7: Console.Write("seventeen"); break;
                case 8: Console.Write("eighteen"); break;
                case 9: Console.Write("nineteen"); break;
            }
        }
        static void PrintFromTwentyToNinety(int tens)
        {
            switch (tens)
            {
                case 2: Console.Write("twenty "); break;
                case 3: Console.Write("thirty "); break;
                case 4: Console.Write("fourty "); break;
                case 5: Console.Write("fifty "); break;
                case 6: Console.Write("sixty "); break;
                case 7: Console.Write("seventy "); break;
                case 8: Console.Write("eighty "); break;
                case 9: Console.Write("ninety "); break;
            }
        }
        static void PrintUnits(int units)
        {
            switch (units)
            {
                case 1: Console.Write("one"); break;
                case 2: Console.Write("two"); break;
                case 3: Console.Write("three"); break;
                case 4: Console.Write("four"); break;
                case 5: Console.Write("five"); break;
                case 6: Console.Write("six"); break;
                case 7: Console.Write("seven"); break;
                case 8: Console.Write("eight"); break;
                case 9: Console.Write("nine"); break;
                default: return;
            }
        }
    }
}
