using System;

namespace _11.ArraySearch
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
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
        }
    }
}
