using System;

namespace AddingPolynomials
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            string firstLine = Console.ReadLine();
            int[] firstPol = ConvertToint(firstLine);
            string secondLine = Console.ReadLine();
            int[] secondPol = ConvertToint(secondLine);
            int[] Sum = Adding(firstPol, secondPol);
            Console.WriteLine(String.Join(" ", Sum));
            int[] Difference = Substracting(firstPol, secondPol);
            Console.WriteLine(String.Join(" ", Difference));
            int[] Product = Multiplying(firstPol, secondPol);
            Console.WriteLine(String.Join(" ", Product));
        }

        static int[] ConvertToint(string line)
        {
            string[] numbersAsStrings = line.Split(' ');
            int[] numbers = new int[numbersAsStrings.Length];
            for (int i = 0; i < numbersAsStrings.Length; i++)
            {
                numbers[i] = int.Parse(numbersAsStrings[i]);
            }
            return numbers;
        }

        static int[] Adding(int[] firstArray, int[] secondArray)
        {
            int[] result = new int[firstArray.Length];
            for (int i = 0; i < firstArray.Length; i++)
            {
                result[i] = firstArray[i] + secondArray[i];
            }
            return result;
        }

        static int[] Substracting(int[] firstArray, int[] secondArray)
        {
            int[] result = new int[firstArray.Length];
            for (int i = 0; i < firstArray.Length; i++)
            {
                result[i] = firstArray[i] - secondArray[i];
            }
            return result;
        }

        static int[] Multiplying(int[] firstArray, int[] secondArray)
        {//Просто винаги трябва да има поне един застъпен елемент при събиране на произведенията, затова дължината е такава
            int[] result = new int[firstArray.Length + secondArray.Length - 1];
            for (int secondIndex = 0; secondIndex < secondArray.Length; secondIndex++)
            {
                for (int firstIndex = 0; firstIndex < firstArray.Length; firstIndex++)
                {
                    result[firstIndex + secondIndex] += firstArray[firstIndex] * secondArray[secondIndex];
                }//Сбора от индексите ни гарантира че индекса ще се увеличава с 1 на всяко завъртане
            }//Така прибавяме новата стойност, точно където трябва
            return result;
        }
    }
}
