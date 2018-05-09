using System;

namespace _2.Matrix
{
    class Program
    {
        static void PrintMatrix(int[,] matrix)//Вкарваме матрицата за разпечатване
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void PrintMatrix(int[,] matrix, ConsoleColor color)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            PrintMatrix(matrix);
            Console.ForegroundColor = defaultColor;
        }

        static int[,] ReadMatrix(int rows, int columns)//Вкарваме броя на редовете и колоните
        {
            int[,] result = new int[rows, columns];//Тук ще записваме данните, които ще връщаме
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return result;
        }

        static int IndexOf(char[] symbols, char seekedValue)
        {
            for (int i = 0; i < symbols.Length; i++)
            {
                if (symbols[i] == seekedValue)
                {
                    return i;
                }
            }
            return -1;
        }

        static int ParseInt(string numberAsString)
        {
            int result = 0;

            //for (int i = 0; i < numberAsString.Length; i++)
            //{
            //    int digit = numberAsString[i] - '0';
            //    result += (int)(digit * Math.Pow(10, numberAsString.Length - 1 - i));//Обаче при големи числа неточностите на Math.Pow избиват
            //}

            foreach (char digit in numberAsString)
            {
                result = result * 10 + digit - '0';
            }

            return result;
        }

        static string Join(int[] numbers, string separator = ",", string suffix = "")
        {//Въвели сме default-ен separator, който ще се използва ако не подадем нещо друго
         //Параметрите със заданена начална стойност са незадължителни(опционални), защото вече имат стойност
         //А тези които нямат зададена начална стойност са задължителни, защото трябва да им пададем стойност
         //В C# неможем да имаме задължителен параметър след опционален, т.е. такъв без стойност след такъв, който вече има стойност
            string result = "";//еквивалентно на string.Empty
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
                if (i != numbers.Length - 1)
                {
                    result += separator;
                }
            }
            return result + suffix;
        }

        static int Product(params int[] numbers)
        {//Използваме ключовата дума params, когато не знаем точния брой параметри, които ще се подадат на метода
            int product = 1;

            foreach (int number in numbers)
            {
                product *= number;
            }

            return product;
        }
        static void Main()
        {
            //Методи с числа
            //int r = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //int[,] matrixFromConsole = ReadMatrix(r, c);
            //PrintMatrix(matrixFromConsole);
            //PrintMatrix(matrixFromConsole, ConsoleColor.DarkGreen);

            //Методи със символи
            //char[] symbols = "Sasho shte stane programist".ToCharArray();
            //int indexOfA = Array.IndexOf(symbols, 'a');
            //int indexOfO = Array.IndexOf(symbols, 'o');
            //int indexOfZ = Array.IndexOf(symbols, 'z');

            //Console.WriteLine("a - {0}", indexOfA);
            //Console.WriteLine("o - {0}", indexOfO);
            //Console.WriteLine("z - {0}", indexOfZ);

            //int number = ParseInt(r);
            //Console.WriteLine(number + 5);

            int[] numbers = { 1, 2, 3, 10, 15, 33 };
            Console.WriteLine(Join(numbers, suffix: "Ivan", separator: "club"));//Пишейки (името на паратетъра): компилатора знае точно кой параметър подаваме, иначе кара подред

            //int pArray = Product(new int[] { 1, 32, 5 });
            //int p1 = Product(1, 2, 10, 15);
            //Console.WriteLine(p1);
            //Console.WriteLine(pArray);
            //Main();//За бързо тестване на програмата, прави ни безкраен цикъл
        }
    }
}
