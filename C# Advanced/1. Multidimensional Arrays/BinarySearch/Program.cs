using System;

namespace BinarySearchHomework
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            Console.WriteLine(String.Join(" ", array));
            if (Array.BinarySearch(array, k) >= 0)//Проверяваме дали методът ни е намерил елемента
            {
                Console.WriteLine(Array.BinarySearch(array, k));
            }
            else if (Array.BinarySearch(array, k) == -1)//Побитовия отрицателен еквивалент на индекс 0 е -1
            {
                Console.WriteLine("There is no smaller number than K({0}).", k);
            }
            else//Ако няма елемент, равен на търсения
            {
                Console.WriteLine(~(Array.BinarySearch(array, k)) - 1);//Вадим 1 за да преминем от индекса на 
            }//по-големия към индекса по-малкия от търсения елемент
        }
    }
}
