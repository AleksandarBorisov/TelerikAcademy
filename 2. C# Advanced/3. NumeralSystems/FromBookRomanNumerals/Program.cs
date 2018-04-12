using System;

namespace FromBookRomanNumerals
{
    class Program
    {
        static void Main()
        {
            string romanNumber = Console.ReadLine();
            int resultInDecimal = 0;
            int previousValue = int.MaxValue;
            foreach (var digit in romanNumber)
            {
                int valueIndecimal = 0;
                switch (digit)
                {
                    case 'I': valueIndecimal = 1; break;
                    case 'V': valueIndecimal = 5; break;
                    case 'X': valueIndecimal = 10; break;
                    case 'L': valueIndecimal = 50; break;
                    case 'C': valueIndecimal = 100; break;
                    case 'D': valueIndecimal = 500; break;
                    case 'M': valueIndecimal = 1000; break;
                }
                if (previousValue >= valueIndecimal)
                {//Ако числата са в намалящ ред ги събираме
                    resultInDecimal += valueIndecimal;
                    previousValue = valueIndecimal;
                }
                else
                {//Ако обаче се окаже че настоящата цифра е по-голямо от предходното пр. IX
                    resultInDecimal -= previousValue;//Изващдаме предходната цифра от общия сбор
                    resultInDecimal += (valueIndecimal - previousValue);//Изваждаме стойността ѝ от настоящата цифра и тогава прибавяме към общия сбор
                    previousValue = valueIndecimal;
                }
            }
            Console.WriteLine(resultInDecimal);
            Main();
        }
    }
}
