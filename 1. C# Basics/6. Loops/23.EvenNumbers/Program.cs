using System;

namespace _23.EvenNumbers
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            string[] declaration = Console.ReadLine().Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
            int maxEven = -1;
            foreach (string word in declaration)
            {
                string number = "";
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    if (char.IsNumber(word[i]))
                    {
                        number = word[i] + number;
                    }
                    else
                    {
                        number = "";
                    }
                    if (Int32.TryParse(number, out int evenNumber))
                    {
                        if (evenNumber % 2 == 0)
                        {
                            maxEven = evenNumber > maxEven ? evenNumber : maxEven;
                        }
                    }
                }
            }
            Console.WriteLine($"{maxEven}");
        }
    }
}
