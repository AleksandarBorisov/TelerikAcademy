using System;

namespace JoroTheRabbit
{
    class Program
    {
        static void Main()
        {
            string[] terrainWithNumbers = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[terrainWithNumbers.Length];
            for (int i = 0; i < terrainWithNumbers.Length; i++)
            {
                numbers[i] = int.Parse(terrainWithNumbers[i]);
            }
            int maxCount = 1;
            for (int startIndex = 0; startIndex < numbers.Length; startIndex++)
            {
                for (int step = 1; step < numbers.Length; step++)
                {
                    int currentMax = 1;
                    int currentIndex = (startIndex + step) % numbers.Length;
                    int previousIndex = startIndex;
                    while (numbers[currentIndex] > numbers[previousIndex])
                    {
                        currentMax++;
                        previousIndex = currentIndex;
                        currentIndex = (currentIndex + step) % numbers.Length;
                    }
                    maxCount = currentMax > maxCount ? currentMax : maxCount;
                }
            }
            Console.WriteLine(maxCount);
            //Реших проблема с времето за изпълнение като махнах булевия масив, който следеше кои клетки сме посетили.
            //Той беше излишен, защото ако се върнем на клетка която сме посетили, условието елемента в нея да е по-голям
            //от елемента преди нея няма как да бъде изпълнено.
        }
    }
}
