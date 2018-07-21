using System;

namespace BullsAndCows
{
    class Program
    {
        static void Main()
        {
            int secretNumber = int.Parse(Console.ReadLine());
            int bulls = int.Parse(Console.ReadLine());
            int cows = int.Parse(Console.ReadLine());
            bool isSupposedNumber = false;
            for (int digit1 = 1; digit1 <= 9; digit1++)
            {
                for (int digit2 = 1; digit2 <= 9; digit2++)
                {
                    for (int digit3 = 1; digit3 <= 9; digit3++)
                    {
                        for (int digit4 = 1; digit4 <= 9; digit4++)
                        {
                            int thousands = (secretNumber / 1000);
                            int hundreds = (secretNumber / 100) % 10;
                            int tents = (secretNumber / 10) % 10;
                            int units = (secretNumber / 1) % 10;
                            int digitToCheck1 = digit1;
                            int digitToCheck2 = digit2;
                            int digitToCheck3 = digit3;
                            int digitToCheck4 = digit4;
                            int bullsCounter = 0;
                            int cowsCounter = 0;
                            if (digitToCheck1 == thousands)
                            {
                                bullsCounter++;
                                thousands = -1;//Затваряме позицията в секретното число, защото сме я открили
                                digitToCheck1 = -2;//Затваряме позицията в предполагаемото число, защото сме я открили
                            }
                            if (digitToCheck2 == hundreds)
                            {
                                bullsCounter++;
                                hundreds = -1;
                                digitToCheck2 = -2;
                            }
                            if (digitToCheck3 == tents)
                            {
                                bullsCounter++;
                                tents = -1;
                                digitToCheck3 = -2;
                            }
                            if (digitToCheck4 == units)
                            {
                                bullsCounter++;
                                units = -1;
                                digitToCheck4 = -2;
                            }
                            if (digitToCheck1 == hundreds)
                            {//Ако не сме намерили бик, провеяваме за крави
                                cowsCounter++;
                                hundreds = -1;//Затваряме позицията в секретното число, за да не участва като крава
                            }//в друга позиция, а позицията в предполагаемото число няма да бъде сравнявана повече защото сме в else-if конструкция
                            else if (digitToCheck1 == tents)
                            {
                                cowsCounter++;
                                tents = -1;
                            }
                            else if (digitToCheck1 == units)
                            {
                                cowsCounter++;
                                units = -1;
                            }
                            if (digitToCheck2 == thousands)
                            {
                                cowsCounter++;
                                thousands = -1;
                            }
                            else if (digitToCheck2 == tents)
                            {
                                cowsCounter++;
                                tents = -1;
                            }
                            else if (digitToCheck2 == units)
                            {
                                cowsCounter++;
                                units = -1;
                            }
                            if (digitToCheck3 == thousands)
                            {
                                cowsCounter++;
                                thousands = -1;
                            }
                            else if (digitToCheck3 == hundreds)
                            {
                                cowsCounter++;
                                hundreds = -1;
                            }
                            else if (digitToCheck3 == units)
                            {
                                cowsCounter++;
                                units = -1;
                            }
                            if (digitToCheck4 == thousands)
                            {
                                cowsCounter++;
                                thousands = -1;
                            }
                            else if (digitToCheck4 == hundreds)
                            {
                                cowsCounter++;
                                hundreds = -1;
                            }
                            else if (digitToCheck4 == tents)
                            {
                                cowsCounter++;
                                tents = -1;
                            }
                            if (bullsCounter == bulls && cowsCounter == cows)
                            {
                                if (isSupposedNumber)
                                {
                                    Console.Write(" ");

                                }
                                Console.Write($"{digit1}{digit2}{digit3}{digit4}");
                                isSupposedNumber = true;
                            }
                        }
                    }
                }
            }
            if (!isSupposedNumber)
            {
                Console.Write("No");
            }
            Console.WriteLine();
        }
    }
}
