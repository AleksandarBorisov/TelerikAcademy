using System;

namespace _11.ArraySearch
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            // Първи начин
            char[] array = Console.ReadLine().Replace(",", "").ToCharArray();
            bool[] found = new bool[array.Length];
            string result = "";
            for (int i = 0; i < array.Length; i++)
            {
                if (found[array[i] - '0' - 1] == false)
                {
                    found[array[i] - '0' - 1] = true;
                }
            }
            for (int i = 0; i < found.Length; i++)
            {
                if (found[i] == false)
                {
                    result += i + 1 + ",";
                }
            }
            Console.WriteLine(result.Trim(','));

            // Втори начин
            //int[] numbers = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            //bool[] abscentNumbers = new bool[numbers.Length + 1];
            //StringBuilder result = new StringBuilder();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    abscentNumbers[numbers[i]] = true;
            //}
            //for (int i = 1; i < abscentNumbers.Length; i++)
            //{
            //    if (!abscentNumbers[i])
            //    {
            //        result.Append(i);
            //        result.Append(",");
            //    }
            //}
            //if (result.Capacity > 1)
            //{
            //    result.Remove(result.Length - 1, 1);
            //}
            //Console.WriteLine(result.ToString());
        }
    }
}
