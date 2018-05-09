using System;

namespace SubsetWithSumS
{
    class Program
    {
        static void Main()
        {
            //Теорията е обяснена в лекцията за Maximal Increasing Subsequence(Remove Elements From Array)
            int s = int.Parse(Console.ReadLine());
            string[] line = Console.ReadLine().Split(' ');
            int[] numbers = new int[line.Length];
            int negElements = 0;
            int posElements = 0;
            for (int i = 0; i < line.Length; i++)
            {
                numbers[i] = int.Parse(line[i]);
                if (numbers[i] < 0)
                {
                    negElements += numbers[i];
                }
                else
                {
                    posElements += numbers[i];
                }
            }
            int offSet = Math.Abs(negElements);//Отместването е равно на сумата от всички отрицателни числа
            bool[] newSums = new bool[posElements + offSet + 1];//Всички съществуващи суми ще бъдат отбелязвани тук с true
            bool[] oldSums = new bool[posElements + offSet + 1];
            int minPos = numbers[0] + offSet;//Елементите от масива numbers ще бъдат индекси в масива newSums
            int maxPos = numbers[0] + offSet;
            int newMinPos = minPos;
            int newMaxPos = maxPos;
            for (int index = 0; index < numbers.Length; index++)
            {
                for (int i = minPos; i <= maxPos; i++)
                {//Обхождаме индексите в масива newSums
                    if (oldSums[i])
                    {//Ако намерим сума, прибавяме към нея настоящия елемент от масива numbers и получаваме следващата сума
                        newSums[i + numbers[index]] = true;
                        if (i + numbers[index] < minPos)
                        {//Ако новата сума е по-малка от досегашната долна граница
                            newMinPos = i + numbers[index];
                        }
                        if (i + numbers[index] > maxPos)
                        {//Ако новата сума е по-голяма от досегашната горна граница
                            newMaxPos = i + numbers[index];
                        }
                    }
                }
                newSums[numbers[index] + offSet] = true;//Добавяме новия елемент като сума
                Array.Copy(newSums, oldSums, posElements + offSet + 1);
                minPos = Math.Min(numbers[index] + offSet, newMinPos);//Проверявае дали елемента като стойност влиза в границите
                maxPos = Math.Max(numbers[index] + offSet, newMaxPos);
            }
            if (0 <= (s + offSet) && (s + offSet) < newSums.Length)//Ако търсената сума е в границите на масива
            {
                Console.WriteLine(newSums[s + offSet] ? "yes" : "no");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
