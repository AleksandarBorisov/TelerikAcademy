using System;


namespace _1.ListsMemoryExplanation
{
    class Program
    {
        static void Main()
        {//Задача от урока за масиви
            var array = new int[0];
            int count = 0;
            Console.WriteLine("Fast Add");
            for (int i = 0; i < 1000000; i++)
            {
                if (array.Length == 0)
                {
                    array = new int[4];
                }
                else if (count == array.Length)
                {
                    int newSize = array.Length * 2;
                    var newArray = new int[newSize];
                    for (int j = 0; j < array.Length; j++)
                    {
                        newArray[j] = array[j];
                    }
                    array = newArray;//освобождаваме мястото където са старите клетки и мястото където са старите и има място за нови
                }
                array[count] = i;//i е новата стойност която добавяме
                ++count;
            }
            //Console.WriteLine(string.Join(" ", array));


            array = new int[0];
            count = 0;
            Console.WriteLine("Slow Add");
            for (int i = 0; i < 1000000; i++)
            {
                int newSize = array.Length + 1;
                var newArray = new int[newSize];
                for (int j = 0; j < array.Length; j++)
                {
                    newArray[j] = array[j];
                }
                array = newArray;
                array[count] = i;
                ++count;
            }
        }
    }
}
