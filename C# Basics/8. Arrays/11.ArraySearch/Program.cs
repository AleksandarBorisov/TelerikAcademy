using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;

namespace _11.ArraySearch
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            // Първи начин
            //int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            //bool[] found = new bool[array.Length];
            //StringBuilder result = new StringBuilder();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    found[array[i] - 1] = true;
            //}
            //for (int i = 0; i < found.Length; i++)
            //{
            //    if (!found[i])
            //    {
            //        result.Append(i + 1);
            //        result.Append(",");
            //    }
            //}
            //if (result.Length > 1)
            //{
            //    result.Remove(result.Length - 1, 1);
            //}
            //Console.WriteLine(result);

            // Втори начин
            Queue<int> numbers = new Queue<int>(Console.ReadLine().Split(',').Select(int.Parse));
            Queue<int> numbersInRange = new Queue<int>(Enumerable.Range(1, numbers.Count));
            Console.WriteLine(string.Join(",",numbersInRange.Except(numbers)));
        }
    }
}
