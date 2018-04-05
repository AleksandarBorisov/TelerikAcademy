using System;

namespace NFactorial
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string number = "1";//Първият множител е 1
            string forPrinting = "";
            for (int multiplier = 2; multiplier <= n; multiplier++)
            {
                int countZeroes = 0;
                string resultAdd = "";//Резултата от събирането на двете умножения
                int currentMultiplier = multiplier;
                while (currentMultiplier > 0)//Докато множителя има още цифри
                {
                    int digitMultiplier = currentMultiplier % 10;
                    string resultMult = Multiplication(number.ToCharArray(), digitMultiplier);
                    resultMult = new string('0', countZeroes) + resultMult;//Отместваме следващите събираеми на правилната 
                    resultAdd = Addition(resultAdd, resultMult);//позиция(десетици,стотици т.н.) и ги подаваме на метода
                    currentMultiplier /= 10;
                    countZeroes++;//Брои колко нули ще добавим отляво за да отместим следващите събираеми на правилната позиция
                }
                number = resultAdd;//Новото число е резултата от събирането
            }
            foreach (var digit in number)
            {
                forPrinting = digit + forPrinting;
            }
            Console.WriteLine(forPrinting);
            Main();
        }

        static string Multiplication(char[] number, int digitMultiplier)
        {
            string result = "";
            int countOneUp = 0;
            for (int i = 0; i < number.Length; i++)
            {
                result += ((number[i] - '0') * digitMultiplier + countOneUp) % 10;//Старият резултат трябва да е отляво
                countOneUp = ((number[i] - '0') * digitMultiplier + countOneUp) / 10;//Проверява за десетици, които ще пробавим на следващото умножение
            }
            result += countOneUp;//Последната стойност я добавяме отдясно
            return result = result.TrimEnd('0');
        }

        static string Addition(string previousResult, string currentResult)
        {
            string result = "";
            previousResult = previousResult.PadRight(currentResult.Length, '0');//Подсигуряваме стринга на единиците да има толкова стойности, 
            int countOneUp = 0;//колкото този на десетиците, но само ако се налага
            for (int i = 0; i < previousResult.Length; i++)
            {
                result += (((previousResult[i] - '0') + (currentResult[i] - '0') + countOneUp) % 10).ToString();
                countOneUp = ((previousResult[i] - '0') + (currentResult[i] - '0') + countOneUp) / 10;//Това е добавянето на ум
            }
            result += countOneUp;//За последната стойност
            return result = result.TrimEnd('0');//Ако е 0, я махаме
        }
    }
}
