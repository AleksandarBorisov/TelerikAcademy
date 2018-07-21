using System;

namespace _10.SmallestDigit
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            char smallestDigit = '9';
            if (word[0] != '0' && word[0] < smallestDigit)
            {
                smallestDigit = word[0];
            }
            if (word[1] != '0' && word[1] < smallestDigit)
            {
                smallestDigit = word[1];
            }
            if (word[2] != '0' && word[2] < smallestDigit)
            {
                smallestDigit = word[2];
            }
            if (word[3] != '0' && word[3] < smallestDigit)
            {
                smallestDigit = word[3];
            }
            Console.WriteLine(smallestDigit);
        }
    }
}
