using System;

namespace CompareCharArrays
{
    class Program
    {
        static void Main()
        {
            char[] firstArray = Console.ReadLine().ToCharArray();
            char[] secondArray = Console.ReadLine().ToCharArray();
            int row = 0;
            int minLength = Math.Min(firstArray.Length, secondArray.Length);
            while (row < minLength)
            {
                if (firstArray[row] != secondArray[row])
                {
                    Console.WriteLine(firstArray[row] > secondArray[row] ? '>' : '<');
                    break;
                }
                row++;
            }
            if (row == minLength)
            {//Проверяваме дали сме обходили по-късия масив
                if (firstArray.Length == secondArray.Length)
                {
                    Console.WriteLine('=');
                }
                else
                {
                    Console.WriteLine(firstArray.Length > secondArray.Length ? '>' : '<');
                }
            }
        }
    }
}
