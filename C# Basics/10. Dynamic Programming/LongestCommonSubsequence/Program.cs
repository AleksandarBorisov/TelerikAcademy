using System;

namespace LongestCommonSubsequence
{
    class Program
    {
        static void Main()
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();
            int[,] currentSeq = new int[firstString.Length + 1, secondString.Length + 1];
            for (int firstIndex = 1; firstIndex <= firstString.Length; firstIndex++)
            {//Изместваме индексирането на стриговете, за да сумилираме нулев стринг в началото им
                for (int secondIndex = 1; secondIndex <= secondString.Length; secondIndex++)
                {//По този начин в двумерния масив ще започваме да пишем от индекс 1, а не от 0
                    if (firstString[firstIndex - 1] == secondString[secondIndex - 1])//Четем елементите на позиции 0
                    {
                        currentSeq[firstIndex, secondIndex] = currentSeq[firstIndex - 1, secondIndex - 1] + 1;
                    }//Пишем резултата на позиции 1 в двумерния масив
                    else
                    {
                        currentSeq[firstIndex, secondIndex] = Math.Max(currentSeq[firstIndex , secondIndex - 1], currentSeq[firstIndex - 1, secondIndex]);
                    }
                }
            }
            Console.WriteLine(currentSeq[firstString.Length,secondString.Length]);
        }
    }
}
