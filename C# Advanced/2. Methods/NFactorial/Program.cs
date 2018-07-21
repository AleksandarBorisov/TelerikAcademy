using System;

namespace NFactorial
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string factorial = "1";//Първият множител е 1
            for (int multiplier = 2; multiplier <= n; multiplier++)
            {
                factorial = Multiplication(factorial.ToCharArray(), multiplier);
            }
            char[] result = factorial.ToCharArray();
            Array.Reverse(result);
            Console.WriteLine(new string(result));
        }

        static string Multiplication(char[] factorial, int digitMultiplier)
        {
            string result = "";
            int countOneUp = 0;
            for (int i = 0; i < factorial.Length; i++)
            {
                result += ((factorial[i] - '0') * digitMultiplier + countOneUp) % 10;//Старият резултат трябва да е отляво
                countOneUp = ((factorial[i] - '0') * digitMultiplier + countOneUp) / 10;//Махаме единиците, останалото ще пробавим на следващото умножение
            }
            while (countOneUp > 0)
            {//Останалото може да е и двуцифрено число
                result += countOneUp % 10;//Добавяме цифрите му последователно отдясно
                countOneUp /= 10;
            }
            return result;
        }
    }
}
