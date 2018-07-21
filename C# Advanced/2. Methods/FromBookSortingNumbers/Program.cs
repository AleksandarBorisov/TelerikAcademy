using System;

namespace FromBookSortingNumbers
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Sort(10, 3, 5, -1, 0, 12, 8);//Присвояваме резултата от работата на метода на масива
            PrintNumbers(numbers);//Разпечатваме масива
        }

        static void PrintNumbers(params int[] numbers)
        {
            Console.WriteLine(String.Join(", ", numbers));
        }

        static int[] Sort(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)//Външния цикъл върти от първия до предпоследния елемент
            {
                for (int j = i + 1; j < numbers.Length; j++)//Вътрешния цикъл върти от следващия до последния елемент(тук е несортираната част от масива)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int swap = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = swap;
                    }
                }
            }
            return numbers;
        }
    }
}
