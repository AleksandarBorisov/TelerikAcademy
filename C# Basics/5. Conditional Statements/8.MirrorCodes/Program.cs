using System;

namespace _8.MirrorCodes
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');
            int firstNumber = int.Parse("" + line[0][2] + line[0][1] + line[0][0]);
            int secondNumber = int.Parse("" + line[1][2] + line[1][1] + line[1][0]);
            if (firstNumber > secondNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else
            {
                Console.WriteLine(secondNumber);
            }
        }
    }
}
