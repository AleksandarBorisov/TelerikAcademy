using System;

namespace StringRepeater
{
    class Program
    {
        static void Main()
        {
            string stringForRepeating = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string repeating = RepeatString(stringForRepeating,count);
            Console.WriteLine(repeating);
        }
        static string RepeatString(string str, int count)
        {
            //string repeatedString = string.Empty;
            //for (int i = 0; i < count; i++)
            //{
            //    repeatedString += str;
            //}
            //return repeatedString;
            return new String('*', count).Replace("*", str);
        }
    }
}
