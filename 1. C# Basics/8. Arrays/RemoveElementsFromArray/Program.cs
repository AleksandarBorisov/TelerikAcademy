using System;

namespace RemoveElementsFromArray
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] unsortedArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                unsortedArray[i] = int.Parse(Console.ReadLine());
            }
            int maxCount = 0;
            int[] currentMaxSeq = new int[n];//Съхранява максималната последователност до съответния елемент
            for (int rightIndex = 0; rightIndex < n; rightIndex++)//Елемента, с който ще сравним всички наляво от него
            {
                maxCount = 0;//Винаги започваме да броим от 0;
                for (int leftIndex = 0; leftIndex < n; leftIndex++)
                {
                    if (unsortedArray[leftIndex] <= unsortedArray[rightIndex] &&
                        currentMaxSeq[leftIndex] >= maxCount)//Ако до този индекс сме имали по-голяма от натрупаната
                    {//до момента бройка вземаме нейната стойност, това условие ни изключва всички елементи на масива с малки
                     //малки бройки, както и такива които все още са с бройка 0
                        maxCount = currentMaxSeq[leftIndex];
                    }
                }
                currentMaxSeq[rightIndex] = maxCount + 1;//Запазваме максималната бройка до съответния индекс като
                //добавяме и елемента, който стои на този индекс
            }
            maxCount = 0;
            for (int i = 0; i < n; i++)
            {
                if (currentMaxSeq[i] > maxCount)//Взимаме най-голямата бройка
                {
                    maxCount = currentMaxSeq[i];
                }
            }
            Console.WriteLine(n - maxCount);
        }
    }
}
