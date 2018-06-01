using System;

namespace _3.ElectronicMessage
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            int symbol = Console.Read();
            int counter = 0;
            int maxCount = 0;
            while (symbol != '.')
            {
                if (char.IsDigit((char)symbol)|| char.IsLetter((char)symbol)|| symbol == ' ')
                {
                    counter = 0;
                }
                else
                {
                    counter++;
                }
                maxCount = Math.Max(counter, maxCount);
                symbol = Console.Read();
            }
            Console.WriteLine(maxCount);
        }
    }
}
