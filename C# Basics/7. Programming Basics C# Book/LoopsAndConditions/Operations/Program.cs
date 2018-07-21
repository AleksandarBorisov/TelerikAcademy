using System;

namespace Operations
{
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            char mathOperator = char.Parse(Console.ReadLine());
            string forPrinting = string.Format("Cannot divide {0} by zero", firstNumber);
            decimal result = 0m;
            if (secondNumber != 0 || (mathOperator != '/' && mathOperator != '%'))
            {//Обратното на: secondNumber == 0 && (mathOperator == '/' || mathOperator == '%')
                switch (mathOperator)
                {
                    case '+': result = firstNumber + secondNumber; break;
                    case '-': result = firstNumber - secondNumber; break;
                    case '*': result = firstNumber * secondNumber; break;
                    case '/': result = firstNumber / (decimal)secondNumber; break;
                    case '%': result = firstNumber % secondNumber; break;
                }
                if (mathOperator == '/')
                {
                    forPrinting = string.Format("{0} {1} {2} = {3:F2}", firstNumber, mathOperator, secondNumber, result);
                }
                else if (mathOperator == '%')
                {
                    forPrinting = string.Format("{0} {1} {2} = {3}", firstNumber, mathOperator, secondNumber, result);
                }
                else
                {
                    forPrinting = string.Format("{0} {1} {2} = {3} - {4}",
                    firstNumber, mathOperator, secondNumber, result, result % 2 == 0 ? "even" : "odd");
                }
            }
            Console.WriteLine(forPrinting);
            //Main();
        }
    }
}
