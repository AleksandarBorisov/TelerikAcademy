using System;

namespace SortByStringLength
{
    class Program
    {
        static void Main()
        {
            string[] arrayOfStrings = Console.ReadLine().Split(' ');
            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                int indexSmallestLength = i;
                int minLength = arrayOfStrings[i].Length;
                for (int j = i + 1; j < arrayOfStrings.Length; j++)
                {
                    if (arrayOfStrings[j].Length < minLength)
                    {
                        minLength = arrayOfStrings[j].Length;
                        indexSmallestLength = j;
                    }
                }
                string swap = arrayOfStrings[i];
                arrayOfStrings[i] = arrayOfStrings[indexSmallestLength];
                arrayOfStrings[indexSmallestLength] = swap;
            }
            //Array.Sort(arrayOfStrings);//Подрежда лексикографски масиви от string-ове, не по дължина
            Console.WriteLine(String.Join(" ", arrayOfStrings));
        }
    }
}
