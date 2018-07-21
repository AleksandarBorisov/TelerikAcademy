using System;

namespace _1.LocalFunction
{
    class Program
    {
        static void Main()
        {
            //Деклариране на локална функция
            double first = 1.22;
            double second = 3.27;
            double Result(double a, double b)
            {
                return a + b;
            }
            Console.WriteLine(Result(first, second));
            //Локалните функции имат достъп до променливи, които се използват в съдържащия ги метод
            string output = "I am a local function";
            void PrintOutPut()
            {
                Console.WriteLine(output);
            }
            PrintOutPut();
        }
    }
}
