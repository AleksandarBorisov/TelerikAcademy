using System;

namespace MergeSort
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
            //Итерацийте показват дължината на елементите на които ще мърджваме, т. е. 2^(iteration-1), например 1,2,4,8...
            for (int iteration = 1; iteration < n; iteration *= 2)
            {//result трябва да го дефинираме наново на всяка итерация, за да сочи към различни елементи от паметта
                int[] result = new int[n];//Помощен масив, в който ще записваме променените стойности
                for (int leftStart = 0; leftStart < unsortedArray.Length; leftStart += 2 * iteration)//начало на левия елемент
                {
                    int rightStart = Math.Min(leftStart + iteration, unsortedArray.Length);//начало на десния елемент
                    int rightEnd = Math.Min(leftStart + (2 * iteration), unsortedArray.Length);//край на десния елемент
                    int leftEnd = rightStart - 1;//край на левия елемент
                    int leftStartDynamic = leftStart;//Въвеждаме го само защото leftStart трябва да остане непроменено
                    for (int resultIndex = leftStartDynamic; resultIndex < rightEnd; resultIndex++)
                    {
                        //Ако не сме изчерпали левия край и (сме изчерпали десния или левия елемент < десния елемент)
                        if (leftStartDynamic <= leftEnd && 
                           (rightStart >= rightEnd || unsortedArray[leftStartDynamic] <= unsortedArray[rightStart]))
                        {//Когато rightStart >= rightEnd е true тогава другото условия в || конструкцията въобще не се
                         //проверява, затова когато rightStart е извън границите на масива не ни връща exception
                            result[resultIndex] = unsortedArray[leftStartDynamic];
                            leftStartDynamic++;
                        }
                        //Ако не сме изчерпали десния край и сме изчерпали левия или левия елемент > десния елемент
                        else
                        {
                            result[resultIndex] = unsortedArray[rightStart];
                            rightStart++;
                        }
                    }
                }
                unsortedArray = result;//на първоначалния масив присвояваме променения
            }
            foreach (int number in unsortedArray)
            {
                Console.WriteLine(number);
            }
        }
    }
}
