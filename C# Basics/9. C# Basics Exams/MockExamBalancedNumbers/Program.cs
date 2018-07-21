using System;

namespace MockExamBalancedNumbers
{
    class Program
    {
        static void Main()
        {
            //string number = Console.ReadLine();
            //int hundreds = (int)char.GetNumericValue(number[0]);
            //int tens = (int)char.GetNumericValue(number[1]);
            //int units = (int)char.GetNumericValue(number[2]);
            //int sum = 0;
            //while (tens == hundreds + units)
            //{
            //    sum += int.Parse(number);
            //    number = Console.ReadLine();
            //    hundreds = (int)char.GetNumericValue(number[0]);
            //    tens = (int)char.GetNumericValue(number[1]);
            //    units = (int)char.GetNumericValue(number[2]);
            //}
            //Console.WriteLine(sum);

            int number = int.Parse(Console.ReadLine());
            int onesAndHundreds = number / 100 + number % 10;
            int tens = (number / 10) % 10;
            int sum = 0;
            while (tens == onesAndHundreds)
            {
                sum += number;
                number = int.Parse(Console.ReadLine());
                onesAndHundreds = number / 100 + number % 10;
                tens = (number / 10) % 10;
            }
            Console.WriteLine(sum);
        }
    }
}
