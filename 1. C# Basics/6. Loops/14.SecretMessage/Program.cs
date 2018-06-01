using System;

namespace _14.SecretMessage
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            string message = Console.ReadLine();
            for (int i = message.Length - 1; i >= 0; i--)
            {
                if (char.IsLetter(message[i]))
                {
                    Console.Write(message[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
