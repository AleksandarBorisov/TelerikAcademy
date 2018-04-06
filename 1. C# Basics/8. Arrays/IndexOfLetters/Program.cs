using System;

namespace IndexOfLetters
{
    class Program
    {
        static void Main()
        {
            char[] alphabet = new char['z'-'a'+1];//задаваме големината да е колкото са всички букви от азбуката
            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabet[i - 'a'] = i;
            }
            string word = Console.ReadLine();
            foreach (var letter in word)
            {
                Console.WriteLine("Letter '{0}' - index in the alphabet => {1,2} and the ASCII code => {2}",letter,Array.IndexOf(alphabet,letter),(int)letter);
            }

            //int position = 0;
            //for (char letter = firstLetter; letter <= lastLetter; letter++)
            //{
            //    alphabet[position] = letter;
            //    position++;
            //}
            //char[] word = Console.ReadLine().ToCharArray();
            //for (int smallLetter = 0; smallLetter < word.Length; smallLetter++)
            //{
                
            //    for (position = 0; position < lastLetter - firstLetter + 1; position++)
            //    {
            //        if (word[smallLetter]==alphabet[position])
            //        {
            //            Console.WriteLine(position);
            //        }
            //    }
            //}
            //Console.WriteLine(string.Join(" ",alphabet));
        }
    }
}
