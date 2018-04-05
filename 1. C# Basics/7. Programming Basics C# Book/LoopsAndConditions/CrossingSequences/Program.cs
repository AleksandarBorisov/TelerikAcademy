using System;

namespace CrossingSequences
{
    class Program
    {
        static void Main()
        {
            long tribonacciFirst = long.Parse(Console.ReadLine());
            long tribonacciSecond = long.Parse(Console.ReadLine());
            long tribonacciThird = long.Parse(Console.ReadLine());
            long startingNumber = long.Parse(Console.ReadLine());
            long step = long.Parse(Console.ReadLine());
            int stepMult = 1;
            int stepCounter = 0;
            long tribonacciForth = tribonacciFirst;//Трябва да започнем от първото число, защото ако започнем от третото и първите три числа са в
            //намаляваща редица ще изпуснем число(например 5, 2, 1 и зададено първо число на спиралата 3 със стъпка 1)
            while (tribonacciThird <= 1000000 && startingNumber <= 1000000)
            {
                if (tribonacciFirst == startingNumber || tribonacciSecond == startingNumber ||
                    tribonacciThird == startingNumber)
                {
                    Console.WriteLine(startingNumber);
                    return;
                }
                else if (tribonacciForth < startingNumber)
                {
                    tribonacciForth = tribonacciFirst + tribonacciSecond + tribonacciThird;
                    tribonacciFirst = tribonacciSecond;
                    tribonacciSecond = tribonacciThird;
                    tribonacciThird = tribonacciForth;
                }
                else
                {
                    startingNumber += stepMult * step;
                    stepCounter++;
                    if (stepCounter == 2)
                    {
                        stepMult++;
                        stepCounter = 0;
                    }
                }
            }
            Console.WriteLine("No");
        }
    }
}
