using System;

namespace ExtractSentences
{
    class Program
    {
        static void Main()
        {
            string word = " " + Console.ReadLine() + " ";
            string text = Console.ReadLine();
            int startIndex = 0;
            int dotIndex = text.IndexOf(".");
            while (startIndex != text.Length)
            {//startIndex ни показва откъде да започнем търсенето не индекса на думата
                if (text.IndexOf(word, startIndex) < dotIndex)
                {
                    Console.Write(text.Substring(startIndex, dotIndex + 1 - startIndex));
                }
                startIndex = dotIndex + 1;
                dotIndex = text.IndexOf(".", startIndex);
            }
            Console.WriteLine();
        }
    }
}
