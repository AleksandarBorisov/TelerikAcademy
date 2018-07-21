using System;

namespace _4.DigitsInText
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            string text = Console.ReadLine();
            int sum = 0;
            bool digitFound = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    sum += text[i] - '0';
                    digitFound = true;
                }
            }
            Console.WriteLine(digitFound ? sum  : -1);
        }
    }
}
