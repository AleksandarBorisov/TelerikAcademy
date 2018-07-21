using System;

namespace _9.HarmoniousWords
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };
            int vowelCount = 0;
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                if (Array.IndexOf(vowels, word[i]) != -1)
                {
                    vowelCount++;
                }
            }
            if (vowelCount == word.Length / 2)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine(vowelCount + " " + (word.Length - vowelCount));
            }
        }
    }
}
