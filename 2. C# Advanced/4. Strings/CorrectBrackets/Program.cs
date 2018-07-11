using System;

namespace CorrectBrackets
{
    class Program
    {
        static void Main()
        {
            string expression = Console.ReadLine();
            int lastIndexOfOpenBracket = expression.LastIndexOf("(");//Последната отваряща скоба
            int firstIndexOFClosingBracket = expression.IndexOf(")");//Първата затваряща скоба
            while (expression.Contains("(") && expression.Contains(")") &&//Докато се съдържат в стринга и
                lastIndexOfOpenBracket < firstIndexOFClosingBracket)//Отварящата е преди затварящата
            {
                if ((char.IsDigit(expression[lastIndexOfOpenBracket + 1]) || char.IsLetter(expression[lastIndexOfOpenBracket + 1])) &&
                    (char.IsDigit(expression[firstIndexOFClosingBracket - 1]) || char.IsLetter(expression[firstIndexOFClosingBracket - 1])))
                {//Ако след отварящата скоба имаме буква или цифра и преди затварящата имаме буква или цифра
                    //Изтриваме скобите
                    expression = expression.Remove(lastIndexOfOpenBracket, 1);
                    expression = expression.Remove(firstIndexOFClosingBracket - 1, 1);
                }
                else
                {
                    break;
                }
                lastIndexOfOpenBracket = expression.LastIndexOf("(");
                firstIndexOFClosingBracket = expression.IndexOf(")");
            }
            if (lastIndexOfOpenBracket != -1 || firstIndexOFClosingBracket != -1)
            {//Ако са останали някакви скоби след цикъла, то те са поставени грешно
                Console.WriteLine("Incorrect");
            }
            else
            {
                Console.WriteLine("Correct");
            }
        }
    }
}
